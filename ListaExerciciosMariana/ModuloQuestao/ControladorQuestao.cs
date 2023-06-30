namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        public override string ToolTipInserir => "Inserir nova questão";

        public override string ToolTipEditar => "Editar questão existente";

        public override string ToolTipExcluir => "Excluir questão existente";

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
            return "Cadastro de questão";
        }
    }
}
