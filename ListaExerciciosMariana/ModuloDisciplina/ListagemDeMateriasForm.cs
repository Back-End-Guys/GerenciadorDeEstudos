using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class ListagemDeMateriasForm : Form
    {
        public ListagemDeMateriasForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void Listagem(Disciplina disciplinaSelecionada)
        {
            lblDisciplina.Text = disciplinaSelecionada.Nome;

            listagemMaterias.AtualizarListaDeMaterias(disciplinaSelecionada.ListMaterias);
        }
    }
}
