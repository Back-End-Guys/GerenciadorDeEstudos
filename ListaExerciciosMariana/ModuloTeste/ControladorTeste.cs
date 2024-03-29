﻿using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using ListaExerciciosMariana.WinForm.ModuloPdf;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private TabelaTesteControl _tabelaTeste;
        private ListagemGabaritoControl _listagemGabarito;
        private IRepositorioTeste _repositorioTeste;
        private IRepositorioDisciplina _repositorioDisciplina;
        private IRepositorioMateria _repositorioMateria;
        private IRepositorioQuestao _repositorioQuestao;

        public ControladorTeste(IRepositorioTeste repositorio, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this._repositorioTeste = repositorio;
            this._repositorioMateria = repositorioMateria;
            this._repositorioDisciplina = repositorioDisciplina;
            this._repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir Teste";

        public override string ToolTipEditar => "";

        public override string ToolTipExcluir => "Excluir Teste";

        public override string ToolTipListagem => "Listagem detalhes Teste";

        public override string ToolTipPDF => "Fazer PDF Teste";

        public override string ToolTipDuplicar => "Duplicar Teste";

        public override bool EditarHabilitado => false;

        public override bool ListagemHabilitado => true;

        public override bool PDFHabilitado => true;

        public override bool DuplicarHabilitado => true;

        public override void Inserir()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(duplicar: false, _repositorioMateria.SelecionarTodos(), _repositorioDisciplina.SelecionarTodos(),
                _repositorioQuestao.SelecionarTodos(), _repositorioTeste.SelecionarTodos(), _repositorioMateria);
            telaTeste.Text = "Cadastrar novo teste";

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                _repositorioTeste.Inserir(teste, telaTeste.ObterQuestoesSorteadas());
            }

            CarregarTeste();
        }

        public override void Editar() { }

        public override void Excluir()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro!", "Exclução de teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o teste \"{testeSelecionado.Titulo}\"?", "Exclusão de teste",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                _repositorioTeste.Excluir(testeSelecionado);
            }

            CarregarTeste();
        }

        public override void Listagem()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro!", "Listagem detalhes teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaDetalhesForm telaDetalhes = new TelaDetalhesForm(this);
            telaDetalhes.Text = "Exibir detalhes do teste";

            telaDetalhes.ConfigurarTelaDetalhes(testeSelecionado);
            telaDetalhes.ShowDialog();
        }

        public override void Duplicar()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro!", "Duplicar teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTesteForm telaTeste = new TelaTesteForm(duplicar: true, _repositorioMateria.SelecionarTodos(), _repositorioDisciplina.SelecionarTodos(),
                _repositorioQuestao.SelecionarTodos(), _repositorioTeste.SelecionarTodos(), _repositorioMateria);
            telaTeste.Text = "Duplicar teste existente";

            telaTeste.ConfigurarTela(testeSelecionado);

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.ObterTeste();
                _repositorioTeste.Inserir(teste, telaTeste.ObterQuestoesSorteadas());
            }

            CarregarTeste();
        }

        public void ExibirGabarito()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            TelaGabaritoForm telaGabarito = new TelaGabaritoForm();
            telaGabarito.Text = "Questões com gabarito";

            telaGabarito.Listagem(testeSelecionado);
            telaGabarito.ShowDialog();
        }

        public override void GerarPdf()
        {
            Teste testeSelecionado = ObterTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro!", "Gerar PDF do teste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaGerarPdfForm telaEscolha = new TelaGerarPdfForm(testeSelecionado, _repositorioQuestao);
            telaEscolha.Text = $"Gerar PDF do {testeSelecionado.Titulo}";

            telaEscolha.ShowDialog();
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
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {testes.Count} testes");
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
            return "Cadastro de Teste";
        }
    }
}
