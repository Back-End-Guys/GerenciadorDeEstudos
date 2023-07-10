using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public partial class TelaQuestaoForm : Form
    {
        private Questao _questao;
        private List<Questao> _questoes;
        private int alternativaCount = 0;

        public TelaQuestaoForm(List<Materia> materias, List<Questao> questoes)
        {
            this._questoes = questoes;

            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarCbMateria(materias);
        }

        public void ConfigurarCbMateria(List<Materia> materias)
        {
            materias.ForEach(m => cbMateria.Items.Add(m));
        }
        public Questao ObterQuestao()
        {
            int id = int.Parse(txtId.Text);
            string enunciado = txtEnunciado.Text;
            Materia materia = (Materia)cbMateria.SelectedItem;
            string respostaCerta;

            _questao = new Questao(id, materia, enunciado);

            if (chListAlternativas.Items.Count == 0)
                return null;

            if (chListAlternativas.CheckedItems.Count == 0)
                respostaCerta = "erro";
            else
                respostaCerta = chListAlternativas.CheckedItems[0].ToString()!;

            _questao.RespostaCerta = respostaCerta;

            foreach (Alternativa alternativa in ObterAlternativasDesmarcadas())
            {
                _questao.AdicionarAlternativa(alternativa);
            }

            foreach (Alternativa alternativaMarcada in ObterAlternativas())
            {
                Alternativa alternativa = new Alternativa(_questao, respostaCerta, true);
                alternativa.Verdadeiro = true;
                _questao.AdicionarAlternativa(alternativa);
            }

            return _questao;
        }
        public Alternativa ObterAlternativa(Questao questao)
        {
            string resposta = txtResposta.Text;

            return new Alternativa(questao, resposta, false);
        }

        public void ConfigurarTela(Questao questao)
        {

            txtId.Text = questao.id.ToString();
            txtEnunciado.Text = questao.Enunciado;
            txtAno.Text = questao.Materia.Ano;

            cbMateria.Text = questao.Materia.ToString();

            foreach (Alternativa alternativa in questao.ListAlternativas)
            {
                chListAlternativas.Items.Add(alternativa);
            }

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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Alternativa alternativa = ObterAlternativa(_questao);

            if (alternativa.AlternativaResposta == "")
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("É necessário ter uma resposta");
                return;
            }

            alternativaCount++;

            chListAlternativas.Items.Add(alternativa);
            txtResposta.Text = string.Empty;
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            chListAlternativas.Items.Remove(chListAlternativas.SelectedItem);
        }
        private void chListAlternativas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = chListAlternativas.SelectedIndex;

            int count = chListAlternativas.Items.Count;

            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    chListAlternativas.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        public List<Alternativa> ObterAlternativas()
        {
            return chListAlternativas.Items.Cast<Alternativa>().ToList();
        }
        public List<Alternativa> ObterAlternativasDesmarcadas()
        {
            return chListAlternativas.Items.Cast<Alternativa>()
                .Except(ObterAlternativas()).ToList();
        }

        private void cbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
            txtAno.Text = materiaSelecionada.Ano.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Questao questao = ObterQuestao();

            if (questao == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Nenhuma alternativa foi marcada");
                DialogResult = DialogResult.None;
                return;
            }

            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Questao q in _questoes)
            {
                if (questao.Enunciado.ToUpper() == q.Enunciado.ToUpper() && questao.id != q.id)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O enunciado ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }   

        //public void ConfigurarListBoxAlternativa(List<Alternativa> aternativas)
        //{
        //    chListAlternativas.Items.Clear();
        //    chListAlternativas.SelectionMode = SelectionMode.One;

        //    chListAlternativas.Items.AddRange(aternativas.ToArray());
        //}
    }
}
