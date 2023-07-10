using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExercicioMariana.Infra.Memoria.ModuloMateria
{
    public class RepositorioMateriaEmMemoria : RepositorioMemoriaBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmMemoria(List<Materia> listaCadastros) : base(listaCadastros)
        {
        }

        public void Inserir(Teste novoRegistro, List<Questao> questoesAdicionadas)
        {
            throw new NotImplementedException();
        }
        public List<Materia> CarregarMateriasDisciplina(Disciplina disciplina)
        {
            throw new NotImplementedException();
        }
    }
}
