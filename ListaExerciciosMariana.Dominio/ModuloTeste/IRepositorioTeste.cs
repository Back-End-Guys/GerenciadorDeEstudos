using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorioBase<Teste>
    {
        public void Inserir(Teste novoRegistro, List<Questao> questoesAdicionadas);
        public void AdicionarQuestao(Teste teste, Questao questao);
    }
}
