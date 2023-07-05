using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExercicioMariana.Infra.Memoria.ModuloMateria
{
    public class RepositorioMateriaEmMemoria : RepositorioMemoriaBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmMemoria(List<Materia> listaCadastros) : base(listaCadastros)
        {
        }
    }
}
