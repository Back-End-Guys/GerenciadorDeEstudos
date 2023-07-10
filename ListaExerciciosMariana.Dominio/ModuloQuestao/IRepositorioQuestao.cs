namespace ListaExerciciosMariana.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao :  IRepositorioBase<Questao>
    {
        void Inserir(Questao questao, List<Alternativa> alternativasAdicionadas);

        void Editar(int id, Questao questao, List<Alternativa> alternativas);

        void CarregarAlternativas(Questao questao);
    }
}
