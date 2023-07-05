namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public static class GridExtensions
    {
        public static void ConfigurarGridLinhas(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhas = new DataGridViewCellStyle
            {
                BackColor = Color.Snow,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightSteelBlue,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhas;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BackgroundColor = Color.AliceBlue;
            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;
        }
    }
}
