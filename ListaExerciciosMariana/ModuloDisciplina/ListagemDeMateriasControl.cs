﻿using ListaExerciciosMariana.Dominio.ModuloMateria;

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
            lista.Columns.Add("ID", 80, HorizontalAlignment.Left);
            lista.Columns.Add("NOME", 300, HorizontalAlignment.Left);
            lista.Columns.Add("ANO", 280, HorizontalAlignment.Left);

            materias.ForEach(m =>
            {
                ListViewItem listaMaterias = new ListViewItem();
                listaMaterias.SubItems.Add(m.id.ToString());
                listaMaterias.SubItems.Add(m.Nome);
                listaMaterias.SubItems.Add(m.Ano);

                lista.Items.Add(listaMaterias);
            });
        }
    }
}
