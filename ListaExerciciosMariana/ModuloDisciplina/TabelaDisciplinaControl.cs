using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            grid.ConfigurarGridLinhas();
            grid.ConfigurarGridSomenteLeitura();

            ConfigurarColunas();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            grid.Rows.Clear();

            disciplinas.ForEach(d => grid.Rows.Add(d.id, d.Nome, d.ListMaterias.Count + " matérias"));
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "NOME"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "qtdMaterias",
                    HeaderText = "QUANTIDADE DE MATÉRIAS"
                }
           };

            grid.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
