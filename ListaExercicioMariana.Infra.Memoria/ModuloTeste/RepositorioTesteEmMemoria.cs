using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExercicioMariana.Infra.Memoria.ModuloTeste
{
    public class RepositorioTesteEmMemoria : RepositorioMemoriaBase<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmMemoria(List<Teste> listaCadastros) : base(listaCadastros)
        {
        }

        public void AdicionarQuestao(Teste teste, Questao questao)
        {
            throw new NotImplementedException();
        }
    }
}
