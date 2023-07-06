namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipTeste { get; }

        public virtual string ToolTipListagem { get; }

        public virtual string ToolTipPDF { get; }

        public virtual string ToolTipDuplicar { get; }

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool TesteHabilitado { get { return false ; } }

        public virtual bool ListagemHabilitado { get { return false ; } }

        public virtual bool PDFHabilitado { get { return false ; } }

        public virtual bool DuplicarHabilitado { get { return false ; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Listagem() { }

        public virtual void Duplicar() { }

        public virtual void Teste() { }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}
