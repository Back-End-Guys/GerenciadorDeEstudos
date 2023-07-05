using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            gridMateria.ConfigurarGridLinhas();

            gridMateria.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Materia> materias)
        {
            gridMateria.Rows.Clear();
            materias.ForEach(m => gridMateria.Rows.Add(m.id, m.Nome, m.Disciplina, m.Ano));            
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "nome",
                    HeaderText = "NOME"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "disciplina",
                    HeaderText = "DISCIPLINA"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "ano",
                    HeaderText = "ANO"
                }
            };

            gridMateria.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridMateria.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

