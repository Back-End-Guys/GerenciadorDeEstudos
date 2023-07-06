using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina _disciplina;
        private List<Disciplina> _disciplinas;

        public TelaDisciplinaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this._disciplinas = disciplinas;
        }

        public Disciplina ObterDisciplina()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;

            _disciplina = new Disciplina(id, nome);
            _disciplina.id = id;

            return _disciplina;
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

            foreach (Disciplina d in _disciplinas)
            {
                if (disciplina.Nome == d.Nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
