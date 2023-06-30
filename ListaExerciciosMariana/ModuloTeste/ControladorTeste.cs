namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        public override string ToolTipInserir => "Inserir novo Teste";

        public override string ToolTipEditar => "Editar teste existente";

        public override string ToolTipExcluir => "Excluir teste existente";

        public override bool TesteHabilitado => true;

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
            return "Cadastro de teste";
        }
    }
}
