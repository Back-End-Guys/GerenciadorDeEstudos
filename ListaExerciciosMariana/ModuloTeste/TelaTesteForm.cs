using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private List<Teste> _testes;
        private List<Questao> _questoesDisponiveis;
        private IRepositorioMateria _repositorioMateria;
        private bool _duplicar;

        public TelaTesteForm(bool duplicar, List<Materia> materias, List<Disciplina> disciplinas, List<Questao> questoes, List<Teste> testes, IRepositorioMateria repositorioMateria)
        {
            this._duplicar = duplicar;
            this._questoesDisponiveis = questoes;
            this._testes = testes;

            InitializeComponent();
            this.ConfigurarDialog();

            ConfigurarCbDisciplina(disciplinas);
            ConfigurarComboBoxMateria(materias);
            this._testes = testes;
            this._repositorioMateria = repositorioMateria;
        }

        public Teste ObterTeste()
        {
            int id = int.Parse(txtId.Text);
            string titulo = txtTítulo.Text;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;
            Materia materia = (Materia)cbMateria.SelectedItem;
            int qtdQuestoes = int.Parse(txtQnt.Text);
            bool recuperacao = chbRecuperacao.Checked;
            //List<Questao> questoes = listQuestoes.Items.Cast<Questao>().ToList();

            Teste teste = new Teste(id, titulo, disciplina, materia, qtdQuestoes, recuperacao);
            teste.id = id;

            return teste;
        }

        public void ConfigurarTela(Teste testeSelecionado)
        {
            txtId.Text = testeSelecionado.id.ToString();
            txtTítulo.Text = testeSelecionado.Titulo;
            txtQnt.Text = testeSelecionado.QuantidadeQuestoes.ToString();
            txtAno.Text = testeSelecionado.Materia.Ano.ToString();
            cbDisciplina.Text = testeSelecionado.Disciplina.ToString();
            cbMateria.Text = testeSelecionado.Materia.ToString();
            chbRecuperacao.Checked = testeSelecionado.ProvaRecuperacao;
        }

        private void ConfigurarCbDisciplina(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();
            disciplinas.ForEach(d => cbDisciplina.Items.Add(d));
        }

        public void ConfigurarComboBoxMateria(List<Materia> materias)
        {
            foreach (Materia materia in materias)
            {
                cbMateria.Items.Add(materia);
            }
        }

        public List<Questao> ObterQuestoesSorteadas()
        {
            return listQuestoes.Items.Cast<Questao>().ToList();
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
                        MessageBox.Show("Não há questões suficientes para a quantidade solicitada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                    MessageBox.Show("Digite uma quantidade válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
                MessageBox.Show("Selecione uma matéria!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private List<Questao> SortearQuestoes(List<Questao> questoesDisponiveis, int quantidade)
        {
            List<Questao> questoesSorteadas = new List<Questao>();
            Random random = new Random();
            Materia materia = (Materia)cbMateria.SelectedItem;

            List<Questao> questoesFiltradas = questoesDisponiveis.FindAll(x => x.Materia.id == materia.id);

            for (int i = 0; i < quantidade; i++)
            {
                if (questoesFiltradas.Count == 0)
                    break;

                int index = random.Next(questoesFiltradas.Count);
                questoesSorteadas.Add(questoesFiltradas[index]);
                questoesFiltradas.RemoveAt(index);
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
            foreach (Teste t in _testes)
            {
                if (teste.Titulo.ToUpper() == t.Titulo.ToUpper() && teste.id != t.id)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O título já esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
            ValidarDuplicacao(teste, _duplicar);
        }

        public void ValidarDuplicacao(Teste teste, bool duplicar)
        {
            if (duplicar == true)
            {
                foreach (Teste t in _testes)
                {
                    if (teste.Titulo.ToUpper() == t.Titulo.ToUpper())
                    {
                        TelaPrincipalForm.Instancia.AtualizarRodape("O título já esta em uso");

                        DialogResult = DialogResult.None;
                    }
                }
            }
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateria.Items.Clear();

            if (cbDisciplina.SelectedItem != null)
            {
                Disciplina disciplinaSelecionada = (Disciplina)cbDisciplina.SelectedItem;

                List<Materia> materiasRelacionadas = _repositorioMateria.CarregarMateriasDisciplina(disciplinaSelecionada);

                cbMateria.Items.AddRange(materiasRelacionadas.ToArray());
            }
        }

        //private void cbMateria_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    ExibirAnoMateriaSelecionada();
        //    AtualizarQuestoesDisponiveis();
        //}

        //private void ExibirAnoMateriaSelecionada()
        //{
        //    if (cbMateria.SelectedItem != null)
        //    {
        //        Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
        //        txtAno.Text = materiaSelecionada.Ano.ToString();
        //    }

        //    else txtAno.Text = string.Empty;
        //}

        //private void AtualizarQuestoesDisponiveis()
        //{
        //    listQuestoes.Items.Clear();

        //    Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;

        //    if (materiaSelecionada != null)
        //    {
        //        List<Questao> questoesFiltradas = _questoesDisponiveis
        //            .Where(q => q.Materia == materiaSelecionada)
        //            .ToList();

        //        questoesFiltradas.ForEach(q => listQuestoes.Items.Add($" → {q.Enunciado}\n"));
        //    }
        //}
    }
}
