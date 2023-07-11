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
        private List<Questao> _questoesSorteadas = new List<Questao>();
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
            int quantidade = (int)txtQnt.Value;
            Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;

            if (cbMateria.SelectedItem == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("É necessário selecionar uma Matéria");
                DialogResult = DialogResult.None;
                return;
            }

            if (quantidade < 0)
            {
                MessageBox.Show("Digite uma quantidade válida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Questao> questoesParaSortear;

            if (chbRecuperacao.Checked == false)
            {
                questoesParaSortear = _questoesDisponiveis.FindAll(x => x.Materia.id == materiaSelecionada.id);
            }
            else
            {
                questoesParaSortear = _questoesDisponiveis.FindAll(q => q.Materia.Disciplina.id == disciplina.id);
            }

            if (questoesParaSortear.Count < quantidade)
            {
                MessageBox.Show("Não há questões suficientes para a quantidade solicitada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _questoesSorteadas = SortearQuestoes(_questoesDisponiveis, quantidade);

            _questoesSorteadas.ForEach(q => listQuestoes.Items.Add(q));
        }

        private List<Questao> SortearQuestoes(List<Questao> questoesDisponiveis, int quantidade)
        {
            Random random = new Random();
            Materia materia = (Materia)cbMateria.SelectedItem;
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;

            List<Questao> questoesDaMateria;

            if (chbRecuperacao.Checked == false)
            {
                questoesDaMateria = _questoesDisponiveis.FindAll(x => x.Materia.id == materia.id);
            }
            else
            {
                questoesDaMateria = _questoesDisponiveis.FindAll(q => q.Materia.Disciplina.id == disciplina.id);
            }

            while (_questoesSorteadas.Count < quantidade)
            {
                int index = random.Next(questoesDaMateria.Count);
                _questoesSorteadas.Add(questoesDaMateria[index]);
                questoesDaMateria.RemoveAt(index);
            }

            return _questoesSorteadas;
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

            if (listQuestoes.Items.Count == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("É necessário sortear questões para o teste");
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

        private void ExibirAnoMateriaSelecionada()
        {
            if (cbMateria.SelectedItem != null)
            {
                Materia materiaSelecionada = (Materia)cbMateria.SelectedItem;
                txtAno.Text = materiaSelecionada.Ano.ToString();
            }

            else txtAno.Text = string.Empty;
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirAnoMateriaSelecionada();
        }
    }
}
