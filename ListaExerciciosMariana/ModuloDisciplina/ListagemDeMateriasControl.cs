using ListaExerciciosMariana.Dominio.ModuloMateria;

namespace ListaExerciciosMariana.WinForm.ModuloDisciplina
{
    public partial class ListagemDeMateriasControl : UserControl
    {
        public ListagemDeMateriasControl()
        {
            InitializeComponent();
            lista.ConfigurarListView();
        }

        public void AtualizarListaDeMaterias(List<Materia> materias)
        {
            lista.Items.Clear();

            lista.Columns.Add("", 0, HorizontalAlignment.Left);
            lista.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lista.Columns.Add("NOME", 400, HorizontalAlignment.Left);

            materias.ForEach(m =>
            {
                ListViewItem listaMaterias = new ListViewItem();
                listaMaterias.SubItems.Add(m.id.ToString());
                listaMaterias.SubItems.Add(m.Nome);

                lista.Items.Add(listaMaterias);
            });
        }
    }
}
