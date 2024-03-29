﻿using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using ListaExerciciosMariana.Infra.ModuloDisciplina;
using ListaExerciciosMariana.Infra.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace ListaExerciciosMariana.Infra.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@TITULO", registro.Titulo);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.Disciplina.id);
            //comando.Parameters.AddWithValue("@MATERIA_ID", registro.Materia.id);
            comando.Parameters.AddWithValue("@QUANTIDADEQUESTOES", registro.QuantidadeQuestoes);
            comando.Parameters.AddWithValue("@PROVARECUPERACAO", registro.ProvaRecuperacao);

            if (registro.Materia == null)
                comando.Parameters.AddWithValue("@MATERIA_ID", DBNull.Value);
            else
                comando.Parameters.AddWithValue("@MATERIA_ID", registro.Materia.id);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["TESTE_ID"]);
            string titulo = Convert.ToString(leitorRegistros["TESTE_TITULO"]);
            int quantidadeQuestoes = Convert.ToInt32(leitorRegistros["TESTE_QUANTIDADEQUESTOES"]);
            bool provaRecuperacao = Convert.ToBoolean(leitorRegistros["TESTE_PROVARECUPERACAO"]);

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            Materia materia = null;

            if (leitorRegistros["MATERIA_ID"] != DBNull.Value)
            {
                materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);
            }

            return new Teste(id, titulo, disciplina, materia, quantidadeQuestoes, provaRecuperacao);
        }
    }
}
