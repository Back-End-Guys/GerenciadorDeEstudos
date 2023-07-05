using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExercicioMariana.Infra.Memoria.ModuloDisciplina
{
    public class RepositorioDisciplinaEmMemoria : RepositorioMemoriaBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmMemoria(List<Disciplina> listaCadastros) : base(listaCadastros)
        {
        }
    }
}
