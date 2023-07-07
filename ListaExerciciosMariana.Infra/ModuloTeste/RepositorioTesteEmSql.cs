using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using ListaExerciciosMariana.Infra.ModuloQuestao;
using Microsoft.Data.SqlClient;

namespace ListaExerciciosMariana.Infra.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioBaseEmSql<Teste, MapeadorTeste>, IRepositorioTeste
    {
        protected override string sqlInserir => @"INSERT INTO[DBO].[TBTESTE]
                                                    (
                                                        [TITULO]
                                                       ,[DISCIPLINA_ID]
                                                       ,[MATERIA_ID]
                                                       ,[QUANTIDADEQUESTOES]
                                                       ,[PROVARECUPERACAO]
                                                    )
                                                 VALUES
                                                    (
                                                        @TITULO
                                                       ,@DISCIPLINA_ID
                                                       ,@MATERIA_ID
                                                       ,@QUANTIDADEQUESTOES
                                                       ,@PROVARECUPERACAO
                                                    );
                                                 SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos => @"SELECT 
	                                                        T.[ID]                  TESTE_ID 
	                                                       ,T.[DISCIPLINA_ID]       TESTE_DISCIPLINA_ID
	                                                       ,T.[MATERIA_ID]          TESTE_MATERIA_ID
                                                           ,T.[QUANTIDADEQUESTOES]  TESTE_QUANTIDADEQUESTOES
                                                           ,T.[PROVARECUPERACAO]    TESTE_PROVARECUPERACAO
                                                           ,M.[NOME]                TESTE_MATERIA_NOME
                                                           ,M.[SERIE]               TESTE_MATERIA_SERIE
                                                           ,M.[DISCIPLINA_ID]       TESTE_DISCIPLINA_ID
                                                           ,D.[NOME]                TESTE_DISCIPLINA_NOME

                                                        FROM 
	                                                        [TBTESTE] AS T
                                                        INNER JOIN [TBMATERIA] AS M
                                                                ON T.[MATERIA_ID] = M.ID
                                                        INNER JOIN [TBDISCIPLINA] AS D
                                                                ON M.[DISCIPLINA_ID] = D.ID";

        protected override string sqlSelecionarPorId => throw new NotImplementedException();


        protected string sqlAdicionarQuestao => @"INSERT INTO [TbQuestao_TbTeste]
                                                              (
                                                                  [QUESTAO_ID]
                                                                 ,[TESTE_ID])
                                                          VALUES
                                                              (
                                                                  @QUESTAO_ID
                                                                 ,@TESTE_ID
                                                              )";


        public void Inserir(Teste novoTeste, List<Questao> questoesAdicionadas)
        {
            foreach (Questao questao in questoesAdicionadas)
            {
                novoTeste.AdicionarQuestao(questao);
            }

            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = sqlInserir;

            //adiciona os parâmetros no comando
            MapeadorTeste mapeador = new MapeadorTeste();
            mapeador.ConfigurarParametros(comandoInserir, novoTeste);

            //executa o comando
            object id = comandoInserir.ExecuteScalar();

            novoTeste.id = Convert.ToInt32(id);

            //encerra a conexão
            conexaoComBanco.Close();

            foreach (Questao questao in questoesAdicionadas)
            {
                AdicionarQuestao(novoTeste, questao);
            }
        }
    
        public Teste SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Teste> SelecionarTodos()
        {
            List<Teste> testes = base.SelecionarTodos();

            return testes;
        }

        public void AdicionarQuestao(Teste teste, Questao questao)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoAdicionarQuestao = conexaoComBanco.CreateCommand();
            comandoAdicionarQuestao.CommandText = sqlAdicionarQuestao;

            //adiciona os parâmetros no comando
            comandoAdicionarQuestao.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoAdicionarQuestao.Parameters.AddWithValue("TESTE_ID", teste.id);

            //executa o comando
            comandoAdicionarQuestao.ExecuteNonQuery();

            //fecha conexão
            conexaoComBanco.Close();
        }
        
    }
}
