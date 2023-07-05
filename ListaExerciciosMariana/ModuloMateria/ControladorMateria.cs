using ListaExerciciosMariana.Dominio.ModuloDisciplina;
using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioDisciplina _repositorioDisciplina;
        private IRepositorioMateria _repositorioMateria;
        private TabelaMateriaControl _tabelaMateria;

        public ControladorMateria(IRepositorioDisciplina repositorioDisciplina, IRepositorioMateria repositorioMateria)
        {
            this._repositorioDisciplina = repositorioDisciplina;
            this._repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir Matéria";

        public override string ToolTipEditar => "Editar Matéria";

        public override string ToolTipExcluir => "Excluir Matéria";

        public override void Inserir()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(_repositorioDisciplina.SelecionarTodos());

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();

                _repositorioMateria.Inserir(materia);
            }

            CarregarMaterias();
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateriaForm = new TelaMateriaForm(_repositorioDisciplina.SelecionarTodos());

            Materia materiaSelecionada = ObterMateriaSelecionada();

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

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a matéria {materiaSelecionada.Nome}?", "Exclusão de Matérias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                _repositorioMateria.Excluir(materiaSelecionada);
            }

            CarregarMaterias();
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = _repositorioMateria.SelecionarTodos();

            _tabelaMateria.AtualizarRegistros(materias);
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
            return "Cadastro de Matérias";
        }
    }
}

