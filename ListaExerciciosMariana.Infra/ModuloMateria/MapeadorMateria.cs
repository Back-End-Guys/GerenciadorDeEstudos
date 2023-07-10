using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Infra.ModuloDisciplina;
using Microsoft.Data.SqlClient;

namespace ListaExerciciosMariana.Infra.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("@ID", registro.id);
            comando.Parameters.AddWithValue("@NOME", registro.Nome);
            comando.Parameters.AddWithValue("@DISCIPLINA_ID", registro.Disciplina.id);
            comando.Parameters.AddWithValue("@SERIE", registro.Ano);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);
            string serie = leitorRegistros["MATERIA_SERIE"].ToString();

            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            return new Materia(id, nome, disciplina, serie);
        }

        public Materia ConverterRegistro2(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["ID"]);
            string nome = Convert.ToString(leitorRegistros["NOME"]);
            string ano = Convert.ToString(leitorRegistros["SERIE"]);

            //Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);

            return new Materia(id, nome, ano);
        }
    }
}

