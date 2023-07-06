using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;
using System.Collections.Generic;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private Teste _teste;
        private List<Teste> _testes;
        private List<Questao> _questoesDisponiveis;

        public TelaTesteForm(List<Teste> testes, List<Disciplina> disciplinas, List<Questao> questoes, List<Materia> materias)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this._testes = testes;
            this._questoesDisponiveis = questoes;
            ConfigurarCbDisciplina(disciplinas);
            ConfigurarComboBoxMateria(materias);
        }

        public Teste ObterTeste()
        {
            string titulo = txtTítulo.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            Materia materia = (Materia)cbMateria.SelectedItem;
            int qtdQuestoes = int.Parse(txtQnt.Text);
            bool recuperacao = chbRecuperacao.Checked;
            List<Questao> questoes = listQuestoes.Items.Cast<Questao>().ToList();

            _teste = new Teste(titulo, disciplina, materia, qtdQuestoes, recuperacao, questoes);

            return _teste;
        }

        public void ConfigurarTela(Teste testeSelecionado)
        {
            txtId.Text = testeSelecionado.id.ToString();
            txtTítulo.Text = testeSelecionado.Titulo;
            txtQnt.Text = testeSelecionado.QuantidadeQuestoes.ToString();
            txtAno.Text = testeSelecionado.Materia.Ano.ToString();
            cbDisciplina.Text = testeSelecionado.Disciplina.ToString();
            cbMateria.Text = testeSelecionado.Materia.ToString();
        }

        private void ConfigurarCbDisciplina(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();
            disciplinas.ForEach(d => cbDisciplina.Items.Add(d));
        }

        //private void cbDisciplina_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    MudarValorCbMateria();
        //}

        //private void MudarValorCbMateria()
        //{
        //    cbMateria.Items.Clear();

        //    Disciplina disciplinaSelecionada = (Disciplina)cbDisciplina.SelectedItem;

        //    if (disciplinaSelecionada != null)
        //        disciplinaSelecionada.ListMaterias.ForEach(m => cbMateria.Items.Add(m));
        //}

        public void ConfigurarComboBoxMateria(List<Materia> materias)
        {
            foreach (Materia materia in materias)
            {
                cbMateria.Items.Add(materia);
            }
        }

        private void cbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            ExibirAnoMateriaSelecionada();
            AtualizarQuestoesDisponiveis();
        }

        private void AtualizarQuestoesDisponiveis()
        {
            listQuestoes.Items.Clear();

            Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;

            if (materiaSelecionada != null)
            {
                List<Questao> questoesFiltradas = _questoesDisponiveis
                    .Where(q => q.Materia == materiaSelecionada)
                    .ToList();

                questoesFiltradas.ForEach(q => listQuestoes.Items.Add($" → {q.Enunciado}\n"));
            }
        }

        private void ExibirAnoMateriaSelecionada()
        {
            if (cbMateria.SelectedItem != null)
            {
                Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
                txtAno.Text = materiaSelecionada.Ano.ToString();
            }

            else txtAno.Text = string.Empty;
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQnt.Text);

            if (cbMateria.SelectedItem != null)
            {
                if (quantidade > 0)
                {
                    Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;

                    if (_questoesDisponiveis.Count >= quantidade)
                    {
                        List<Questao> questoesSorteadas = SortearQuestoes(_questoesDisponiveis, quantidade);

                        questoesSorteadas.ForEach(q => listQuestoes.Items.Add(q));
                    }

                    else
                        MessageBox.Show("Não há questões suficientes para a quantidade solicitada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                    MessageBox.Show("Digite uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
                MessageBox.Show("Selecione uma matéria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private List<Questao> SortearQuestoes(List<Questao> questoesDisponiveis, int quantidade)
        {
            List<Questao> questoesSorteadas = new List<Questao>();

            Random random = new Random();

            for (int i = 0; i < quantidade; i++)
            {
                int index = random.Next(questoesDisponiveis.Count);
                questoesSorteadas.Add(questoesDisponiveis[index]);
                questoesDisponiveis.RemoveAt(index);
            }

            return questoesSorteadas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();

            string[] erros = teste.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }


        }
    }
}
