﻿using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;

namespace ListaExerciciosMariana.Infra.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : RepositorioBaseEmSql<Questao, MapeadorQuestao>, IRepositorioQuestao
    {
        protected override string sqlInserir => @"INSERT INTO[DBO].[QUESTAO]
                                                    (
                                                        [ENUNCIADO]
                                                       ,[MATERIA_ID]
                                                       ,[RESPOSTA]
                                                    )
                                                 VALUES
                                                    (
                                                        @ENUNCIADO
                                                       ,@MATERIA_ID
                                                       ,@RESPOSTACERTA
                                                    );
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => @"UPDATE[QUESTAO]
                                               SET
                                                   [MATERIA_ID] = @MATERIA_ID
                                                  ,[ENUNCIADO] = @ENUNCIADO
                                                  ,[RESPOSTA] = @RESPOSTACERTA
                                             WHERE [ID] = @ID;";

        protected override string sqlExcluir => @"DELETE FROM [QUESTAO]
                                                    WHERE 
                                                        [ID] = @ID";

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        Q.[ID]                QUESTAO_ID 
	                                                       ,Q.[ENUNCIADO]         QUESTAO_ENUNCIADO
	                                                       ,Q.[MATERIA_ID]        MATERIA_ID
                                                           ,Q.[RESPOSTA]          QUESTAO_RESPOSTA
                                                           ,M.[NOME]              MATERIA_NOME
                                                           ,M.[SERIE]             MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID]     DISCIPLINA_ID
                                                           ,D.[NOME]              DISCIPLINA_NOME
                                                        FROM 
	                                                        [QUESTAO] AS Q
                                                        INNER JOIN [TBMATERIA] AS M
                                                                ON Q.[MATERIA_ID] = M.ID
                                                        INNER JOIN [DISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID";

        protected override string sqlSelecionarPorId => @"SELECT 
	                                                        Q.[ID]                QUESTAO_ID 
	                                                       ,Q.[MATERIA_ID]        MATERIA_ID
	                                                       ,Q.[ENUNCIADO]         QUESTAO_ENUNCIADO
                                                           ,Q.[RESPOSTA]          QUESTAO_RESPOSTA
                                                           ,M.[NOME]              MATERIA_NOME
                                                           ,M.[SERIE]             MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID]     DISCIPLINA_ID
                                                           ,D.[NOME]   DISCIPLINA_NOME
                                                    FROM 
	                                                        [QUESTAO] AS Q
                                                        INNER JOIN [TBMATERIA] AS M
                                                                ON Q.[MATERIA_ID] = M.ID
                                                        INNER JOIN [DISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID
                                                    WHERE 
                                                        Q.[ID] = @ID";

        private string sqlAdicionarAlternativa =>
            @"INSERT INTO [TBAlternativa]
                (
                    [QUESTAO_ID]
                   ,[RESPOSTA]
                   ,[VERDADEIRO]
                )
            VALUES
                (
                   @QUESTAO_ID
                   ,@RESPOSTA
                   ,@VERDADEIRO
                )";

        private string sqlCarregarAlternativas =>
            @"SELECT 
                A.ID            ALTERNATIVA_ID, 
                A.RESPOSTA      ALTERNATIVA_RESPOSTA,
                A.VERDADEIRO    ALTERNATIVA_VERDADEIRO,
                A.QUESTAO_ID    QUESTAO_ID,

                Q.MATERIA_ID    MATERIA_ID,
                Q.ENUNCIADO     QUESTAO_ENUNCIADO,
                Q.RESPOSTA      QUESTAO_RESPOSTA,

                M.NOME           MATERIA_NOME,
                M.DISCIPLINA_ID  DISCIPLINA_ID,
                M.SERIE          MATERIA_SERIE,

                D.NOME           DISCIPLINA_NOME
            FROM 
                TBALTERNATIVA A

                INNER JOIN QUESTAO Q

                    ON Q.ID = A.QUESTAO_ID

                INNER JOIN TBMATERIA M

                    ON Q.MATERIA_ID = M.ID

                INNER JOIN DISCIPLINA D

                    ON M.DISCIPLINA_ID = D.ID
            WHERE 

                A.QUESTAO_ID = @QUESTAO_ID AND Q.MATERIA_ID = @MATERIA_ID AND M.DISCIPLINA_ID = @DISCIPLINA_ID";

        private const string sqlRemoverAlternativas =
            @"DELETE FROM [TBALTERNATIVA]
                WHERE
                    [QUESTAO_ID] = @QUESTAO_ID";

        private const string sqlRemoverQuestoes = @"DELETE FROM [TBQUESTAO_TBTESTE]
                                                          WHERE
                                                        [QUESTAO_ID] = @QUESTAO_ID";

        public override List<Questao> SelecionarTodos()
        {
            List<Questao> questoes = base.SelecionarTodos();

            return questoes;
        }

        public void Inserir(Questao questao, List<Alternativa> alternativasAdicionadas)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            MapeadorQuestao mapeador = new MapeadorQuestao();
            mapeador.ConfigurarParametros(comandoInserir, questao);

            object id = comandoInserir.ExecuteScalar();

            questao.id = Convert.ToInt32(id);

            conexaoComBanco.Close();

            foreach (Alternativa alternativa in alternativasAdicionadas)
            {
                AdicionarAlternativa(alternativa, questao);
            }
        }

        public void Editar(int id, Questao questao, List<Alternativa> alternativas)
        {
            foreach (Alternativa alternativaParaAdicionar in alternativas)
            {
                if (questao.Existe(alternativaParaAdicionar))
                    continue;

                AdicionarAlternativa(alternativaParaAdicionar, questao);
                questao.AdicionarAlternativa(alternativaParaAdicionar);
            }

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoEditar = conexaoComBanco.CreateCommand();
            comandoEditar.CommandText = sqlEditar;

            MapeadorQuestao mapeador = new MapeadorQuestao();
            mapeador.ConfigurarParametros(comandoEditar, questao);

            comandoEditar.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void Excluir(Questao questao, List<Teste> testes)
        {
            RemoverAlternativa(questao);

            if (testes.Exists(t => t.ListQuestoes.Contains(questao)))
            {
                RemoverQuestao(questao);
            }
                SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

                SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

                comandoExclusao.Parameters.AddWithValue("ID", questao.id);

                conexaoComBanco.Open();

                int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

                conexaoComBanco.Close();
        }

        private void RemoverQuestao(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlRemoverQuestoes, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("QUESTAO_ID", questao.id);

            conexaoComBanco.Open();
            comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public override Questao SelecionarPorId(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarPorId = conexaoComBanco.CreateCommand();
            comandoSelecionarPorId.CommandText = sqlSelecionarPorId;

            comandoSelecionarPorId.Parameters.AddWithValue("ID", id);

            SqlDataReader leitorTemas = comandoSelecionarPorId.ExecuteReader();

            Questao questao = null;

            if (leitorTemas.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();
                questao = mapeador.ConverterRegistro(leitorTemas);
            }

            conexaoComBanco.Close();

            if (questao != null)
            {
                CarregarAlternativas(questao);
            }

            return questao;
        }

        private void AdicionarAlternativa(Alternativa alternativa, Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlAdicionarAlternativa;

            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoInserir.Parameters.AddWithValue("RESPOSTA", alternativa.AlternativaResposta);
            comandoInserir.Parameters.AddWithValue("VERDADEIRO", alternativa.Verdadeiro);

            comandoInserir.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        private void RemoverAlternativa(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlRemoverAlternativas, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("QUESTAO_ID", questao.id);

            conexaoComBanco.Open();
            comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();
        }

        public void CarregarAlternativas(Questao questao)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            SqlCommand comandoSelecionarAlternativas = conexaoComBanco.CreateCommand();
            comandoSelecionarAlternativas.CommandText = sqlCarregarAlternativas;

            comandoSelecionarAlternativas.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoSelecionarAlternativas.Parameters.AddWithValue("MATERIA_ID", questao.Materia.id);
            comandoSelecionarAlternativas.Parameters.AddWithValue("DISCIPLINA_ID", questao.Materia.Disciplina.id);

            SqlDataReader leitorAlternativa = comandoSelecionarAlternativas.ExecuteReader();

            while (leitorAlternativa.Read())
            {
                MapeadorQuestao mapeador = new MapeadorQuestao();

                Alternativa alternativa = mapeador.ConverterParaAlternativa(leitorAlternativa);

                questao.AdicionarAlternativa(alternativa);
            }

            conexaoComBanco.Close();
        }
    }
}
