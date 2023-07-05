using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            gridDisciplina.ConfigurarGridLinhas();
            gridDisciplina.ConfigurarGridSomenteLeitura();
            ConfigurarColunas();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            gridDisciplina.Rows.Clear();
            disciplinas.ForEach(d => gridDisciplina.Rows.Add(d.id, d.Nome, d.ListMaterias.Count + " matérias"));
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

            gridDisciplina.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridDisciplina.SelectedRows[0].Cells["ID"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
