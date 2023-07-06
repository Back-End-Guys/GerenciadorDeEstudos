namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public static class GridExtensions
    {
        public static void ConfigurarGridLinhas(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhas = new DataGridViewCellStyle
            {
                Font = font,
                BackColor = Color.Snow,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightSteelBlue,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhas;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;

            grid.Cursor = Cursors.Hand;
            grid.BackgroundColor = Color.FromArgb(255, 255, 255);
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Color.LightSteelBlue;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}
