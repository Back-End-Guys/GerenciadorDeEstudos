using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class FazerTesteForm : Form
    {
        private int _questaoAtual = 0;
        private List<Questao> _questoes;

        public FazerTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            _questoes = testeSelecionado.ListQuestoes;

            ConfigurarProgressBar(testeSelecionado);
            ConfigurarQuestao(_questoes);
        }

        public void ConfigurarQuestao(List<Questao> questaoSelecionada)
        {
            lblEnunciado.Text = questaoSelecionada[_questaoAtual].Enunciado;
            rb1.Text = $"A) {questaoSelecionada[_questaoAtual].ListAlternativas[0]}";
            rb2.Text = $"B) {questaoSelecionada[_questaoAtual].ListAlternativas[1]}";
            rb3.Text = $"C) {questaoSelecionada[_questaoAtual].ListAlternativas[2]}";
            rb4.Text = $"D) {questaoSelecionada[_questaoAtual].ListAlternativas[3]}";
            rb5.Text = $"E) {questaoSelecionada[_questaoAtual].ListAlternativas[4]}";
        }

        private void ConfigurarProgressBar(Teste testeSelecionado)
        {
            lblProgresso.Text = $"{_questaoAtual}/{testeSelecionado.ListQuestoes.Count}";
            progressBar.Minimum = _questaoAtual;
            progressBar.Maximum = testeSelecionado.ListQuestoes.Count;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            _questaoAtual += 1;
        }
    }
}
