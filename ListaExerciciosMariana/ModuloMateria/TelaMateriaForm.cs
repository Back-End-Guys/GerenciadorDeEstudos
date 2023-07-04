using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        public TelaMateriaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            CarregarDisciplinas(disciplinas);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                cbDisciplina.Items.Add(disciplina);
            }
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            int ano = 0;

            if (rdbPrimeiro.Checked)
            {
                ano = 1;
            }
            if (rdbSegundo.Checked)
            {
                ano = 2;
            }

            return new Materia(id, nome, disciplina, ano);
        }

        public void ConfigurarTela(Materia materiaSelecionada)
        {
            txtId.Text = materiaSelecionada.id.ToString();
            txtNome.Text = materiaSelecionada.Nome;
            cbDisciplina.SelectedItem = materiaSelecionada.Disciplina;

            if (materiaSelecionada.Serie == 1)
                rdbPrimeiro.Checked = true;
            if (materiaSelecionada.Serie == 2)
                rdbSegundo.Checked = true;
        }
    }
}

