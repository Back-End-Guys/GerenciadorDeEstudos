using ListaExerciciosMariana.Dominio.ModuloMateria;
using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private TabelaQuestaoControl _tabelaQuestao;
        private IRepositorioQuestao _repositorioQuestao;
        private IRepositorioMateria _repositorioMateria;

        public ControladorQuestao(IRepositorioQuestao repositorio, IRepositorioMateria repositorioMateria)
        {
            this._repositorioQuestao = repositorio;
            this._repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir nova questão";

        public override string ToolTipEditar => "Editar questão existente";

        public override string ToolTipExcluir => "Excluir questão existente";

        public override void Inserir()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(_repositorioMateria.SelecionarTodos());

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                _repositorioQuestao.Inserir(questao);
            }
            CarregarQuestoes();
        }

        public override void Editar()
        {
            Questao questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro", "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(_repositorioMateria.SelecionarTodos());
            telaQuestao.Text = "Editar questão existente";

            telaQuestao.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                _repositorioQuestao.Editar(questao.id, questao);
            }

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma questão primeiro!",
                    "Exclusão de Questões",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão '{questao.id}'?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioQuestao.Excluir(questao);
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
            return "Registro de Questão";
        }
    }
}
