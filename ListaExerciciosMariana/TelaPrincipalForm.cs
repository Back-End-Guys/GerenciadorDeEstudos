using ListaExercicioMariana.Infra.Memoria.ModuloDisciplina;
using ListaExercicioMariana.Infra.Memoria.ModuloMateria;
using ListaExercicioMariana.Infra.Memoria.ModuloQuestao;
using ListaExercicioMariana.Infra.Memoria.ModuloTeste;
using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using ListaExerciciosMariana.WinForm.ModuloDisciplina;
using ListaExerciciosMariana.WinForm.ModuloMateria;
using ListaExerciciosMariana.WinForm.ModuloQuestao;
using ListaExerciciosMariana.WinForm.ModuloTeste;

namespace ListaExerciciosMariana
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm _telaPrincipal;

        private ControladorBase _controlador;

        private IRepositorioDisciplina _repositorioDisciplina = new RepositorioDisciplinaEmMemoria(new List<Disciplina>());
        private IRepositorioMateria _repositorioMateria = new RepositorioMateriaEmMemoria(new List<Materia>());
        private IRepositorioQuestao _repositorioQuestao = new RepositorioQuestaoEmMemoria(new List<Questao>());
        private IRepositorioTeste _repositorioTeste = new RepositorioTesteEmMemoria(new List<Teste>());

        public TelaPrincipalForm()
        {
            InitializeComponent();
            _telaPrincipal = this;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (_telaPrincipal == null)
                    _telaPrincipal = new TelaPrincipalForm();

                return _telaPrincipal;
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            toolBar.Enabled = true;

            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarBarraFerramentas(_controlador);

            ConfigurarListagem(_controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnTeste.ToolTipText = controlador.ToolTipTeste;
            btnListagem.ToolTipText = controlador.ToolTipListagem;
        }

        private void ConfigurarBotoesHabilitados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnTeste.Enabled = controlador.TesteHabilitado;
            btnListagem.Enabled = controlador.ListagemHabilitado;
        }
        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolBar.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarBotoesHabilitados(controlador);
        }

        // Menu Items ---------------------------------------------------------------------------------------

        private void displinaMenuItem_Click(object sender, EventArgs e)
        {
            _controlador = new ControladorDisciplina(_repositorioDisciplina);

            ConfigurarTelaPrincipal(_controlador);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            _controlador = new ControladorMateria(_repositorioDisciplina, _repositorioMateria);

            ConfigurarTelaPrincipal(_controlador);
        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            _controlador = new ControladorQuestao(_repositorioQuestao, _repositorioMateria);

            ConfigurarTelaPrincipal(_controlador);
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controlador = new ControladorTeste(_repositorioTeste, _repositorioDisciplina, _repositorioQuestao);

            ConfigurarTelaPrincipal(_controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            _controlador.Inserir();
        }

        // Bot�es -------------------------------------------------------------------------------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controlador.Excluir();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            _controlador.Teste();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            _controlador.Listagem();
        }
    }
}