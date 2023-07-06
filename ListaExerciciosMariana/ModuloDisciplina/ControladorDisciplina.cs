using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private ListagemDeMateriasControl _listagemMaterias;
        private IRepositorioDisciplina _repositorioDisciplina;
        private TabelaDisciplinaControl _tabelaDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorio)
        {
            this._repositorioDisciplina = repositorio;
        }

        public override string ToolTipInserir => "Inserir Disciplina";

        public override string ToolTipEditar => "Editar Disciplina";

        public override string ToolTipExcluir => "Excluir Disciplina";

        public override string ToolTipListagem => "Listagem de Matérias";

        public override bool ListagemHabilitado => true;

        public override void Inserir()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(_repositorioDisciplina.SelecionarTodos());
            telaDisciplina.Text = "Cadastrar nova disciplina";

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();
                _repositorioDisciplina.Inserir(disciplina);
            }

            CarregarDisciplina();
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if(disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro!", "Edição de disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(_repositorioDisciplina.SelecionarTodos());
            telaDisciplina.Text = "Editar disciplina existente";

            telaDisciplina.ConfigurarTela(disciplinaSelecionada);

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();
                _repositorioDisciplina.Editar(disciplina.id, disciplina);
            }

            CarregarDisciplina();
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro!", "Exclusão de disciplina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }           

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina \"{disciplinaSelecionada.Nome}\"?", "Exclusão de disciplina",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.Yes)
            {
                if (disciplinaSelecionada.ListMaterias.Count > 0)
                {
                    MessageBox.Show("Exclusão inválida! Disciplina possui matérias cadastradas.", "Exclusão de disciplina", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                _repositorioDisciplina.Excluir(disciplinaSelecionada);
            }

            CarregarDisciplina();
        }

        public override void Listagem()
        {
            Disciplina disciplinaSelecionada = ObterDisciplinaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro!", "listagem de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (disciplinaSelecionada.ListMaterias.Count <= 0)
            {
                MessageBox.Show($"A disciplina \"{disciplinaSelecionada.Nome}\" não possui matérias cadastradas!", "Listagem inexistente", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ListagemDeMateriasForm listagemMaterias = new ListagemDeMateriasForm();
            listagemMaterias.Text = "Listagem de matérias da disciplina";

            if(_listagemMaterias == null)
                _listagemMaterias = new ListagemDeMateriasControl();

            listagemMaterias.Listagem(disciplinaSelecionada);
            listagemMaterias.ShowDialog();
        }

        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = _tabelaDisciplina.ObterIdSelecionado();
            return _repositorioDisciplina.SelecionarPorId(id);
        }

        private void CarregarDisciplina()
        {
            List<Disciplina> disciplinas = _repositorioDisciplina.SelecionarTodos();
            _tabelaDisciplina.AtualizarRegistros(disciplinas);
        }

        public override UserControl ObterListagem()
        {
            if (_tabelaDisciplina == null)
                _tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplina();

            return _tabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Disciplina";
        }
    }
}
