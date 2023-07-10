using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorioBase<Materia>
    {
        public List<Materia> CarregarMateriasDisciplina(Disciplina disciplina);
    }
}
