using ListaExerciciosMariana.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosMariana.Infra.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@TITULO", registro.Titulo);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.Disciplina.id);
            comando.Parameters.AddWithValue("@MATERIA_ID", registro.Materia.id);
            comando.Parameters.AddWithValue("@QUANTIDADEQUESTOES", registro.QuantidadeQuestoes);
            comando.Parameters.AddWithValue("@PROVARECUPERACAO", registro.ProvaRecuperacao);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            throw new NotImplementedException();
        }
    }
}
