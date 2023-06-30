namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        public override string ToolTipInserir => "Inserir nova disciplina";

        public override string ToolTipEditar => "Editar disciplina existente";

        public override string ToolTipExcluir => "Excluir disciplina existente";

        public override string ToolTipListagem => "Listagem de matérias";

        public override bool ListagemHabilitado => true;

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Listagem()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de disciplina";
        }
    }
}
