namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public static class GridExtensions
    {
        public static void ConfigurarGridLinhas(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhas = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(45, 45, 45),
                SelectionForeColor = Color.White
            };

            grid.RowsDefaultCellStyle = linhas;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

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
