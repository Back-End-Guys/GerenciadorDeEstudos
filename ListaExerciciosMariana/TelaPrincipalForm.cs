using ListaExerciciosMariana.WinForm.ModuloDisciplina;

namespace ListaExerciciosMariana
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm telaPrincipal;

        private ControladorBase controlador;

        //static ContextoDados contexto = new ContextoDados(carregarDados: true);

        //private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
        //private IRepositorioMateria repositorioMateria = new RepositorioMateriaEmArquivo(contexto);
        //private IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoEmArquivo(contexto);
        //private IRepositorioTeste repositorioTeste = new RepositorioTesteEmArquivo(contexto);

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
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

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
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
        }

        private void ConfigurarBotoesHabilitados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnEditar.Enabled = controlador.ExcluirHabilitado;
            btnTeste.Enabled = controlador.TesteHabilitado;
        }
        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolBar.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarBotoesHabilitados(controlador);
        }

        private void displinaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina();

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controlador);
        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controlador);
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            controlador.Teste();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            controlador.Listagem();
        }
    }
}