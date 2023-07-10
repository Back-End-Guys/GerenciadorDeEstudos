using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        private Disciplina disciplina;
        private Materia materia;
        private int qtdQuestoes;
        private bool recuperacao;

        public string Titulo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        public int QuantidadeQuestoes { get; set; }
        public bool ProvaRecuperacao { get; set; }
        public List<Questao> ListQuestoes { get; set; }

        public Teste(int id, string titulo, Disciplina disciplina, Materia materia, int quantidadeQuestoes, bool provaRecuperacao)
        {
            this.id = id;
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantidadeQuestoes = quantidadeQuestoes;
            ProvaRecuperacao = provaRecuperacao;
            ListQuestoes = new List<Questao>();
        }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int quantidadeQuestoes, bool provaRecuperacao, List<Questao> listQuestoes)
        {
            Titulo = titulo;
            Disciplina = disciplina;
            Materia = materia;
            QuantidadeQuestoes = quantidadeQuestoes;
            ProvaRecuperacao = provaRecuperacao;
            ListQuestoes = listQuestoes;
        }

        public Teste(string titulo, Disciplina disciplina, Materia materia, int qtdQuestoes, bool recuperacao)
        {
            Titulo = titulo;
            this.disciplina = disciplina;
            this.materia = materia;
            this.qtdQuestoes = qtdQuestoes;
            this.recuperacao = recuperacao;
        }

        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            this.Titulo = registroAtualizado.Titulo;
            this.Disciplina = registroAtualizado.Disciplina;
            this.Materia = registroAtualizado .Materia;
            this.QuantidadeQuestoes = registroAtualizado.QuantidadeQuestoes;
            this.ProvaRecuperacao = registroAtualizado.ProvaRecuperacao;
            this.ListQuestoes = registroAtualizado.ListQuestoes;
        }

        public void AdicionarQuestao(Questao questao)
        {
            if (ListQuestoes.Contains(questao) == false)
                ListQuestoes.Add(questao);
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo))
                erros.Add("O campo \"Título\" é obrigatório");

            if (Disciplina == null)
                erros.Add("O campo \"Disciplina\" é obrigatório");

            if (Materia == null)
                erros.Add("O campo \"Título\" é obrigatório");

            return erros.ToArray();
        }
    }
}
