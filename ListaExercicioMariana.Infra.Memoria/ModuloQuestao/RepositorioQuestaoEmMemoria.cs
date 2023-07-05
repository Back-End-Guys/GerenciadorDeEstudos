using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExercicioMariana.Infra.Memoria.ModuloQuestao
{
    public class RepositorioQuestaoEmMemoria : RepositorioMemoriaBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmMemoria(List<Questao> listaCadastros) : base(listaCadastros)
        {
        }
    }
}
