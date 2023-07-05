using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private TabelaTesteControl _tabelaTeste;
        private ListagemGabaritoControl _listagemGabarito;
        private IRepositorioTeste _repositorioTeste;
        private IRepositorioDisciplina _repositorioDisciplina;
        private IRepositorioQuestao _repositorioQuestao;

        public ControladorTeste(IRepositorioTeste repositorio, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao)
        {
            this._repositorioTeste = repositorio;
            this._repositorioDisciplina = repositorioDisciplina;
            this._repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir novo Teste";

        public override string ToolTipEditar => "Editar teste existente";

        public override string ToolTipExcluir => "Excluir teste existente";

        public override bool EditarHabilitado => false;

        public override bool TesteHabilitado => true;

        public override bool ListagemHabilitado => true;

        public override void Inserir()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(_repositorioTeste.SelecionarTodos(), _repositorioDisciplina.SelecionarTodos(), _repositorioQuestao.SelecionarTodos());
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

        }

        public override void Teste()
        {

        }

        public void ExibirGabarito()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            TelaGabaritoForm telaGabarito = new TelaGabaritoForm();
            telaGabarito.Text = "Questões com gabarito";

            telaGabarito.Listagem(testeSelecionado);
            telaGabarito.ShowDialog();
        }

        private Teste ObterTesteSelecionado()
        {
            int id = _tabelaTeste.ObterIdSelecionado();
            return _repositorioTeste.SelecionarPorId(id);
        }

        private void CarregarTeste()
        {
            List<Teste> testes = _repositorioTeste.SelecionarTodos();
            _tabelaTeste.AtualizarRegistros(testes);
        }

        public override UserControl ObterListagem()
        {
            if (_tabelaTeste == null)
                _tabelaTeste = new TabelaTesteControl();

            CarregarTeste();

            return _tabelaTeste;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de teste";
        }
    }
}
