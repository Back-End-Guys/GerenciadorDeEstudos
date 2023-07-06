using ListaExerciciosMariana.Dominio.ModuloQuestao;

namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    public partial class ListagemGabaritoControl : UserControl
    {
        public ListagemGabaritoControl()
        {
            InitializeComponent();
            lista.ConfigurarListView();
        }

        public void AtualizarListagemGabarito(List<Questao> questaos)
        {
            lista.Items.Clear();

            lista.Columns.Add("", 0, HorizontalAlignment.Left);
            lista.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lista.Columns.Add("ENUNCIADO", 400, HorizontalAlignment.Left);
            lista.Columns.Add("GABARITO", 380, HorizontalAlignment.Left);

            questaos.ForEach(q =>
            {
                ListViewItem listaMaterias = new ListViewItem();
                listaMaterias.SubItems.Add(q.id.ToString());
                listaMaterias.SubItems.Add(q.Enunciado);
                listaMaterias.SubItems.Add(q.RespostaCerta);

                lista.Items.Add(listaMaterias);
            });
        }
    }
}



