using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; }
        public List<Materia> ListMaterias { get; set; }

        public Disciplina(int id, string nome)
        {
            this.id = id;
            Nome = nome;
            ListMaterias = new List<Materia>();
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.ListMaterias = registroAtualizado.ListMaterias;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo \"Nome\" é obrigatório");

            return erros.ToArray();
        }
    }
}
