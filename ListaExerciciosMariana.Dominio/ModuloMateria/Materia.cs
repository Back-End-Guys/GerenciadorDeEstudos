using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Ano { get; set; }

        public Materia(int id, string nome, Disciplina disciplina, int ano)
        {
            this.id = id;
            Nome = nome;
            Disciplina = disciplina;
            Ano = ano;
        }

        public override void AtualizarInformacoes(Materia registroAtualizado)
        {
            this.id += registroAtualizado.id;
            this.Nome = registroAtualizado.Nome;
            this.Disciplina = registroAtualizado.Disciplina;
            this.Ano = registroAtualizado.Ano;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo \"Nome\" é obrigatório");

            if (Nome.Length < 3)
                erros.Add("O campo \"Nome\" deve conter no mínimo 3 caracteres");

            if (Disciplina == null)
                erros.Add("O campo \"Disciplina\" é obrigatório");

            if (Ano == null)
                erros.Add("O campo \"Ano\" é obrigatório");

            return erros.ToArray();
        }
    }
}
