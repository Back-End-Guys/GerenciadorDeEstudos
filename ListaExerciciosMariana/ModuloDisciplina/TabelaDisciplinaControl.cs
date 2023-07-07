using ListaExerciciosMariana.Dominio.ModuloDisciplina;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridDisciplina.ConfigurarGridLinhas();
            gridDisciplina.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            gridDisciplina.Rows.Clear();
            disciplinas.ForEach(d => gridDisciplina.Rows.Add(d.id, d.Nome));
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
