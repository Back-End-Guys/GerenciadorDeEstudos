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
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarDisciplinas(disciplinas);
            CarregarAnos(anos);
            this._materiaList = materias;
        }

        private void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();
            disciplinas.ForEach(d => cbDisciplina.Items.Add(d));
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
            cbDisciplina.SelectedItem = materiaSelecionada.Disciplina;
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

            _materiaList.ForEach(m =>
            {
                if (_materia.Nome == m.Nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome já está em uso");
                    DialogResult = DialogResult.None;
                }
            });
        }
    }
}

