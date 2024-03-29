﻿using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Infra.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace ListaExerciciosMariana.Infra.ModuloQuestao
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@MATERIA_ID", registro.Materia.id);
            comando.Parameters.AddWithValue("@ENUNCIADO", registro.Enunciado);
            comando.Parameters.AddWithValue("@RESPOSTACERTA", registro.RespostaCerta);
        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["QUESTAO_ID"]);
            string enunciado = Convert.ToString(leitorRegistros["QUESTAO_ENUNCIADO"])!;
            string respostaCerta = Convert.ToString(leitorRegistros["QUESTAO_RESPOSTA"])!;

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            return new Questao(id, materia, enunciado, respostaCerta);
        }

        public Alternativa ConverterParaAlternativa(SqlDataReader leitorAlternativa)
        {
            int id = Convert.ToInt32(leitorAlternativa["ALTERNATIVA_ID"]);
            string resposta = Convert.ToString(leitorAlternativa["ALTERNATIVA_RESPOSTA"]);
            bool correta = Convert.ToBoolean(leitorAlternativa["ALTERNATIVA_VERDADEIRO"]);

            Questao questao = ConverterRegistro(leitorAlternativa);

            return new Alternativa(questao, resposta, correta);
        }
    }
}
