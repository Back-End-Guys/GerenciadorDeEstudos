namespace ListaExerciciosMariana.Dominio.ModuloQuestao
{
    public class Alternativa : EntidadeBase<Alternativa>
    {
        public string AlternativaResposta { get; set; }
        public bool Verdadeiro { get; set; }

        public Questao Questao { get; set; }

        public Alternativa() { }

        public Alternativa(Questao questao, string resposta, bool verdadeiro)
        {
            Verdadeiro = verdadeiro;
            Questao = questao;
            AlternativaResposta = resposta;
        }

        public override void AtualizarInformacoes(Alternativa registroAtualizado)
        {
            this.AlternativaResposta = registroAtualizado.AlternativaResposta;
            this.Verdadeiro = registroAtualizado.Verdadeiro;
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
