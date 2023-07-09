using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia _materia;
        private List<Materia> _materiaList;

        public TelaMateriaForm(List<Materia> materias, List<Disciplina> disciplinas, List<AnosEnum> anos)
        {
            this._materiaList = materias;
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
            CarregarAnos(anos);
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                cbDisciplina.Items.Add(disciplina);
            }
        }

        private void CarregarAnos(List<AnosEnum> anos)
        {
            cbAno.Items.Clear();

            List<string> anosFormatados = new List<string>();

            anos.ForEach(a =>
            {
                int ano = (int)a;
                string anoFormatado = $"{ano}º ano";

                if (a >= AnosEnum.PrimeiroAnoEm && a <= AnosEnum.TerceiroAnoEm)
                {
                    ano -= 10;
                    anoFormatado = $"{ano}º ano Ensino Médio";
                }

                anosFormatados.Add(anoFormatado);
            });

            anosFormatados.ForEach(a => cbAno.Items.Add(a));
        }

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            string ano = (string)cbAno.SelectedItem;

            return new Materia(id, nome, disciplina, ano);
        }

        public void ConfigurarTela(Materia materiaSelecionada)
        {
            txtId.Text = materiaSelecionada.id.ToString();
            txtNome.Text = materiaSelecionada.Nome;
            cbDisciplina.Text = materiaSelecionada.Disciplina.ToString();
            cbAno.SelectedItem = materiaSelecionada.Ano;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materia materia = ObterMateria();

            string[] erros = materia.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Materia m in _materiaList)
            {
                if (materia.Nome.ToUpper() == m.Nome.ToUpper() && materia.id != m.id)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}

