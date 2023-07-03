using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        TabelaQuestaoControl tabelaQuestao;
        private IRepositorioQuestao repositorioQuestao;

        public override string ToolTipInserir => "Inserir nova questão";

        public override string ToolTipEditar => "Editar questão existente";

        public override string ToolTipExcluir => "Excluir questão existente";

        public override void Inserir()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.ObterQuestao();

                repositorioQuestao.Inserir(questao);
            }
            CarregarQuestoes();
        }


        public override void Editar()
        {
            Questoes questaoSelecionada = ObterQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro", "Edição de Questão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaQuestoesForm telaQuestao = new TelaQuestoesForm();
            telaQuestao.Text = "Editar questão existente";

            telaQuestao.ConfigurarTela(questaoSelecionada);

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questoes questao = telaQuestao.ObterQuestao();

                repositorioQuestoes.Editar(questao.id, questao);
            }

            CarregarQuestoes();
        }

        public override void Excluir()
        {
            Questoes questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma questao primeiro!",
                    "Exclusão de Questões",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a questão?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestoes.Excluir(questao);
            }

            CarregarQuestoes();
        }

        private Questoes ObterQuestaoSelecionada()
        {
            int id = tabelaQuestao.ObterIdSelecionado();

            return repositorioQuestoes.SelecionarPorId(id);
        }


        private void CarregarQuestoes()
        {
            List<Questoes> listaQuestoes = repositorioQuestoes.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(listaQuestoes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestao;
        }

        public override string ObterTipoCadastro()
        {
            return "Registro de Questão";
        }
    }
}
