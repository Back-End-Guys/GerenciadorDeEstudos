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

        public Questao(Materia materia, string enunciado, string respostaCerta, List<Alternativa> listAlternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            RespostaCerta = respostaCerta;
            ListAlternativas = listAlternativas;
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

            return erros.ToArray();
        }

        public void AdicionarAlternativa(Alternativa alternativa)
        {
            ListAlternativas.Add(alternativa);
        }

        public bool Contem(Alternativa alternativaParaAdicionar)
        {
            if (ListAlternativas.Contains(alternativaParaAdicionar))
                return true;

            return false;
        }

        public void RemoverAlternativa(Alternativa alternaticaParaRemover)
        {
            ListAlternativas.Remove(alternaticaParaRemover);
        }
    }
}
