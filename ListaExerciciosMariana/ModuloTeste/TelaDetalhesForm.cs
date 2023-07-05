using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class TelaDetalhesForm : Form
    {
        private ControladorTeste _controlador;

        public TelaDetalhesForm(ControladorTeste controlador)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this._controlador = controlador;    
        }

        public void ConfigurarTelaDetalhes(Teste testeSelecionado)
        {
            txtId.Text = testeSelecionado.id.ToString();
            chbRecuperacao.Checked = testeSelecionado.ProvaRecuperacao;
            txtTitulo.Text = testeSelecionado.Titulo;
            txtDisciplina.Text = testeSelecionado.Disciplina.ToString();
            txtMateria.Text = testeSelecionado.Materia.ToString();
            txtAno.Text = testeSelecionado.Materia.Ano.ToString();
            txtQnt.Text = testeSelecionado.QuantidadeQuestoes.ToString();
        }

        private void btnGabarito_Click(object sender, EventArgs e)
        {
            _controlador.ExibirGabarito();
        }
    }
}
