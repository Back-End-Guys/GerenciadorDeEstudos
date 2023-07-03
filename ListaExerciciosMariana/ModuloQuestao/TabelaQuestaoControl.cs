using ListaExerciciosMariana.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "enunciado",
                    HeaderText = "Enunciado"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "Matéria"
                }
            };

            gridQuestao.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Questao> listaQuestoes)
        {
            gridQuestao.Rows.Clear();

            foreach (Questao questao in listaQuestoes)
            {
                gridQuestao.Rows.Add(questao.id, questao.Enunciado, questao.Materia.Nome);
            }
        }
        public int ObterIdSelecionado()
        {
            if (gridQuestao.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridQuestao.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
