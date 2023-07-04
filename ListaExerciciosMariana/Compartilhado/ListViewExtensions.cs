namespace ListaExerciciosMariana.WinForm.Compartilhado
{
    public static class ListViewExtensions
    {
        public static void ConfigurarListView(this ListView lista)
        {
            lista.View = View.Details;
            lista.HideSelection = true;
            lista.FullRowSelect = false;
            lista.LabelEdit = false;
            lista.GridLines = true;

            Font font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lista.Font = font;
            lista.BackColor = Color.Snow;

            lista.ItemSelectionChanged += lista_ItemSelectionChanged;
        }

        private static void lista_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item.Selected = false;
            e.Item.Focused = false;
        }
    }
}
