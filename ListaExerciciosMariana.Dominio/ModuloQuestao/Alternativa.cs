namespace ListaExerciciosMariana.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string AlternativaResposta { get; set; }
        public bool RespostaCerta { get; set; }

        public Alternativa() { }

        public override void AtualizarInformacoes(Alternativa registroAtualizado)
        {
            this.AlternativaResposta = registroAtualizado.AlternativaResposta;
            this.RespostaCerta = registroAtualizado.RespostaCerta;
        }

        public override string ToString()
        {
            return AlternativaResposta;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (AlternativaResposta == null)
                erros.Add("O campo \"Alternativa\" é obrigatório");

            return erros.ToArray();
        }
    }
}
