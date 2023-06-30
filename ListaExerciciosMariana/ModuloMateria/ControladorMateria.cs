namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        public override string ToolTipInserir => "Inserir nova matéria";

        public override string ToolTipEditar => "Editar matéria existente";

        public override string ToolTipExcluir => "Excluir matéria existente";

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

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de matéria";
        }
    }
}
