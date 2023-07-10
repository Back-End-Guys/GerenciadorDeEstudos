using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;
using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl _tabelaQuestao;
        private IRepositorioQuestao _repositorioQuestao;
        private IRepositorioMateria _repositorioMateria;
        private IRepositorioTeste _repositorioTeste;

        public ControladorQuestao(IRepositorioQuestao repositorio, IRepositorioMateria repositorioMateria, IRepositorioTeste repositorioTeste)
        {
            this._repositorioTeste = repositorioTeste;
            this._repositorioQuestao = repositorio;
            this._repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir Questão";

        public override string ToolTipEditar => "Editar Questão";

        public override string ToolTipExcluir => "Excluir Questão";

        public override void Inserir()
        {
            TelaQuestaoForm telaQuestaoForm = new TelaQuestaoForm(_repositorioMateria.SelecionarTodos(), _repositorioQuestao.SelecionarTodos());

            DialogResult opcaoEscolhida = telaQuestaoForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestaoForm.ObterQuestao();

                _repositorioQuestao.Inserir(questao, questao.ListAlternativas);
            }

            CarregarQuestoes();
        }

        public override void Editar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(_repositorioMateria.SelecionarTodos(), _repositorioQuestao.SelecionarTodos());
            Questao questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro", "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            telaQuestao.Text = "Editar questão existente";

            telaQuestao.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                List<Alternativa> alternativasMarcadas = telaQuestao.ObterAlternativas();

                List<Alternativa> alternativasDesmarcadas = telaQuestao.ObterAlternativasDesmarcadas();

                _repositorioQuestao.Editar(questao.id, questao, alternativasMarcadas);
            }

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma questão primeiro!", "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão \"{questao.id}\"?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                try
                {
                _repositorioQuestao.Excluir(questao, _repositorioTeste.SelecionarTodos());
                }
                catch (Microsoft.Data.SqlClient.SqlException)
                {
                    MessageBox.Show($"Questão está em um teste! Não pode ser Excluída", "Exclusão de Questões", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            CarregarQuestoes();
        }

        private Questao ObterQuestaoSelecionada()
        {
            int id = _tabelaQuestao.ObterIdSelecionado();
            return _repositorioQuestao.SelecionarPorId(id);
        }

        private void CarregarQuestoes()
        {
            List<Questao> listaQuestoes = _repositorioQuestao.SelecionarTodos();
            _tabelaQuestao.AtualizarRegistros(listaQuestoes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {listaQuestoes.Count} questões");
        }

        public override UserControl ObterListagem()
        {
            if (_tabelaQuestao == null)
                _tabelaQuestao = new TabelaQuestaoControl();

            CarregarQuestoes();

            return _tabelaQuestao;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Questão";
        }
    }
}
