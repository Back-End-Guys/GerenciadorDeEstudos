using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class TelaGabaritoForm : Form
    {
        public TelaGabaritoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void Listagem(Teste testeSelecionado)
        {
            lblTitulo.Text = testeSelecionado.Titulo;
            listagem.AtualizarListagemGabarito(testeSelecionado.ListQuestoes);
        }
    }
}
