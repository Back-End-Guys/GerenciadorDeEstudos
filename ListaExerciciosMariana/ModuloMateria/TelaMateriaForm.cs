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
            disciplinas.ForEach(d => cbDisciplina.Items.Add(d));
        }

        private void CarregarAnos(List<AnosEnum> anos)
        {
            cbAno.Items.Clear();
            anos.ForEach(a => cbAno.Items.Add(a));
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            AnosEnum ano = (AnosEnum)cbAno.SelectedItem;

            return new Materia(id, nome, disciplina, ano);
        }

        public void ConfigurarTela(Materia materiaSelecionada)
        {
            txtId.Text = materiaSelecionada.id.ToString();
            txtNome.Text = materiaSelecionada.Nome;
            cbDisciplina.SelectedItem = materiaSelecionada.Disciplina;
            cbAno.SelectedItem = materiaSelecionada.Ano;
        }
    }
}

