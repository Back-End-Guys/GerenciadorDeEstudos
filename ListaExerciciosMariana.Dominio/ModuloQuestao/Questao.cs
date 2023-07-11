using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public string RespostaCerta { get; set; }
        public List<Alternativa> ListAlternativas { get; set; }

        public Questao(int id, Materia materia, string enunciado, string respostaCerta)
        {
            this.id = id;
            Materia = materia;
            Enunciado = enunciado;
            RespostaCerta = respostaCerta;
            ListAlternativas = new List<Alternativa>();
        }

        public Questao(int id, Materia materia, string enunciado)
        {
            this.id = id;
            this.Materia = materia;
            Enunciado = enunciado;
            ListAlternativas = new List<Alternativa>();
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            Materia = registroAtualizado.Materia;
            Enunciado = registroAtualizado.Enunciado;
            RespostaCerta = registroAtualizado.RespostaCerta;
            ListAlternativas = registroAtualizado.ListAlternativas;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            if (Materia == null)
                erros.Add("O campo \"Matéria\" é obrigatório");

            if (ListAlternativas.Count < 2)
                erros.Add("Mínimo 2 \"Altenativas\"");

            if (ListAlternativas.Count > 5)
                erros.Add("Máximo 5 \"Alternativas\"");

            if (string.IsNullOrEmpty(RespostaCerta))
                erros.Add("É necessário marcar uma resposta como certa");

            return erros.ToArray();
        }

        public void AdicionarAlternativa(Alternativa alternativa)
        {
            ListAlternativas.Add(alternativa);
        }

        public bool Existe(Alternativa alternativaParaAdicionar)
        {
            if (ListAlternativas.Exists(x => x.id == alternativaParaAdicionar.id))
                return true;

            return false;
        }
    }
}
