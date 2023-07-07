using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioDisciplina _repositorioDisciplina;
        private IRepositorioMateria _repositorioMateria;
        private TabelaMateriaControl _tabelaMateria;
        private List<AnosEnum> _anosEnum;   

        public ControladorMateria(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            this._repositorioDisciplina = repositorioDisciplina;
            this._repositorioMateria = repositorioMateria;
            _anosEnum = new List<AnosEnum>(Enum.GetValues(typeof(AnosEnum)).Cast<AnosEnum>());
        }

        public override string ToolTipInserir => "Inserir Matéria";

        public override string ToolTipEditar => "Editar Matéria";

        public override string ToolTipExcluir => "Excluir Matéria";

        public override void Inserir()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(_repositorioMateria.SelecionarTodos(), _repositorioDisciplina.SelecionarTodos(), _anosEnum);
            telaMateria.Text = "Cadastrar nova matéria";

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();

                _repositorioMateria.Inserir(materia);
                materia.Disciplina.ListMaterias.Add(materia);
            }

            CarregarMaterias();
        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObterMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro!", "Edição de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaMateriaForm telaMateriaForm = new TelaMateriaForm(_repositorioMateria.SelecionarTodos(), _repositorioDisciplina.SelecionarTodos(), _anosEnum);
            telaMateriaForm.Text = "Edição de matéria";

            telaMateriaForm.ConfigurarTela(materiaSelecionada);

            DialogResult opcaoEscolhida = telaMateriaForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateriaForm.ObterMateria();

                _repositorioMateria.Editar(materia.id, materia);
            }

            CarregarMaterias();
        }


        public override void Excluir()
        {
            Materia materiaSelecionada = ObterMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro!", "Edição de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materiaSelecionada.Nome}?", "Exclusão de Matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioMateria.Excluir(materiaSelecionada);
                materiaSelecionada.Disciplina.ListMaterias.Remove(materiaSelecionada);
            }

            CarregarMaterias();
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = _repositorioMateria.SelecionarTodos();
            _tabelaMateria.AtualizarRegistros(materias);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} matérias");
        }

        public override UserControl ObterListagem()
        {
            if (_tabelaMateria == null)
                _tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return _tabelaMateria;
        }

        private Materia ObterMateriaSelecionada()
        {
            int id = _tabelaMateria.ObterIdSelecionado();

            return _repositorioMateria.SelecionarPorId(id);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Matéria";
        }
    }
}

