using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;
        private List<Disciplina> _disciplinas;

        public TelaDisciplinaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            this._disciplinas = disciplinas;
        }

        public Disciplina ObterDisciplina()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;

            disciplina = new Disciplina(id, nome);
            disciplina.id = id;

            return disciplina;
        }

        public void ConfigurarTela(Disciplina disciplinaSelecionada)
        {
            txtId.Text = disciplinaSelecionada.id.ToString();
            txtNome.Text = disciplinaSelecionada.Nome;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = ObterDisciplina();

            string[] erros = disciplina.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            _disciplinas.ForEach(d =>
            {
                if (disciplina.Nome == d.Nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome já está em uso");
                    DialogResult = DialogResult.None;
                }
            });
        }
    }
}
