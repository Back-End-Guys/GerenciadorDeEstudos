using ListaExerciciosMariana.Dominio.Compartilhado;

namespace ListaExercicioMariana.Infra.Memoria.Compartilhado
{
    public abstract class RepositorioMemoriaBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> listaCadastros;
        protected int contadorCadastro = 0;

        public RepositorioMemoriaBase(List<TEntidade> listaCadastros)
        {
            this.listaCadastros = listaCadastros;
        }

        public virtual List<TEntidade> SelecionarTodos() { return listaCadastros.OrderByDescending(x => x.id).ToList(); }   

        public int Quantidade() { return listaCadastros.Count;}

        public virtual TEntidade SelecionarPorId(int id) 
        {
            if(listaCadastros.Exists(c => c.id == id))
                return listaCadastros.First(c => c.id == id);

            return null;
        }

        public virtual void Inserir(TEntidade cadastro)
        {
            contadorCadastro++;
            cadastro.id = contadorCadastro;

            listaCadastros.Add(cadastro);
        }

        public virtual void Editar(int id, TEntidade cadastroEditado)
        {
            TEntidade cadastroSelecionado = SelecionarPorId(id);
            cadastroSelecionado.AtualizarInformacoes(cadastroEditado);
        }

        public virtual void Editar(TEntidade cadastroSelecionado, TEntidade cadastroEditado)
        {
            cadastroSelecionado.AtualizarInformacoes(cadastroEditado);
        }

        public virtual void Excluir(int id)
        {
            TEntidade cadastroSelecionado = SelecionarPorId(id);

            if (cadastroSelecionado != null)
                listaCadastros.Remove(cadastroSelecionado);
        }

        public virtual void Excluir(TEntidade selecionarCadastro)
        {
            listaCadastros.Remove(selecionarCadastro);
        }
    }
}
