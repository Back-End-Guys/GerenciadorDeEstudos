using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao _questao;
        private List<Questao> _questoes;

        public TelaQuestaoForm(List<Questao> questoes, List<Materia> materias)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarCbMateria(materias);
            this._questoes = questoes;
        }

        public Questao ObterQuestao()
        {
            int id = Convert.ToInt32(txtId.Text);
            string enunciado = txtEnunciado.Text;

            Materia materia = (Materia)cbMateria.SelectedItem;

            string respostaCerta = chListAlternativas.CheckedItems.ToString();

            List<Alternativa> listaAlaternativas = new List<Alternativa>();

            listaAlaternativas.AddRange(chListAlternativas.Items.Cast<Alternativa>());

            Questao questao = new Questao(materia, enunciado, respostaCerta, listaAlaternativas);

            if (id > 0)
                questao.id = id;

            return questao;
        }

        public void ConfigurarTela(Questao questao)
        {
            ConfigurarListBoxAlternativa(questao.ListAlternativas);

            txtId.Text = questao.id.ToString();
            txtEnunciado.Text = questao.Enunciado;
            txtAno.Text = questao.Materia.Ano;

            cbMateria.SelectedItem = questao.Materia.ToString();

            int i = 0;

            for (int j = 0; j < chListAlternativas.Items.Count; j++)
            {
                Alternativa alternativa = (Alternativa)chListAlternativas.Items[j];

                if (questao.ListAlternativas.Contains(alternativa))
                {
                    chListAlternativas.SetItemChecked(i, true);
                }

                i++;
            }
        }

        public void ConfigurarCbMateria(List<Materia> materias)
        {
            materias.ForEach(m => cbMateria.Items.Add(m));
        }

        private void cbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
            txtAno.Text = materiaSelecionada.Ano.ToString();
        }

        public void ConfigurarListBoxAlternativa(List<Alternativa> aternativas)
        {
            chListAlternativas.Items.Clear();
            chListAlternativas.SelectionMode = SelectionMode.One;

            chListAlternativas.Items.AddRange(aternativas.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Alternativa Alternativa = new Alternativa();
            Alternativa.AlternativaResposta = txtResposta.Text;

            chListAlternativas.Items.Add(Alternativa);
            txtResposta.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Alternativa alternativaSelecionada = (Alternativa)chListAlternativas.SelectedItem;
            chListAlternativas.Items.Remove(alternativaSelecionada);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Questao questao = ObterQuestao();

            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Questao q in _questoes)
            {
                if (questao.Enunciado == q.Enunciado && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
