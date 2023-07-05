using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
            gridQuestao.ConfigurarGridLinhas();
            gridQuestao.ConfigurarGridSomenteLeitura();
            ConfigurarColunas();
        }

        public void AtualizarRegistros(List<Questao> listaQuestoes)
        {
            gridQuestao.Rows.Clear();
            listaQuestoes.ForEach(q => gridQuestao.Rows.Add(q.id, q.Enunciado, q.Materia.Nome));
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
                    Name = "enunciado",
                    HeaderText = "ENUNCIADO"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "MATÉRIA"
                }
            };

            gridQuestao.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridQuestao.SelectedRows[0].Cells["ID"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
