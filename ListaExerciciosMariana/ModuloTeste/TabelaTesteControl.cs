using ListaExerciciosMariana.Dominio.ModuloTeste;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            gridTeste.ConfigurarGridLinhas();
            gridTeste.ConfigurarGridSomenteLeitura();
            ConfigurarColunas();
        }

        public void AtualizarRegistros(List<Teste> testes)
        {
            gridTeste.Rows.Clear();
            testes.ForEach(t => gridTeste.Rows.Add(t.id, t.Titulo, t.Materia.Ano, t.ListQuestoes.Count + " questões"));
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
                    Name = "titulo",
                    HeaderText = "TÍTULO"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "MATÉRIA"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "qtdQuestões",
                    HeaderText = "QUANTIDADE DE QUESTÕES"
                }
           };

            gridTeste.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridTeste.SelectedRows[0].Cells["ID"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
