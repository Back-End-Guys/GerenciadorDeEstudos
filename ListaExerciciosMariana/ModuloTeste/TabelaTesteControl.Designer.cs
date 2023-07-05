namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    partial class TabelaTesteControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridTeste = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTeste).BeginInit();
            SuspendLayout();
            // 
            // gridTeste
            // 
            gridTeste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTeste.Dock = DockStyle.Fill;
            gridTeste.GridColor = Color.Snow;
            gridTeste.Location = new Point(0, 0);
            gridTeste.Name = "gridTeste";
            gridTeste.RowHeadersWidth = 51;
            gridTeste.RowTemplate.Height = 29;
            gridTeste.Size = new Size(675, 420);
            gridTeste.TabIndex = 0;
            // 
            // TabelaTesteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTeste);
            Name = "TabelaTesteControl";
            Size = new Size(675, 420);
            ((System.ComponentModel.ISupportInitialize)gridTeste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTeste;
    }
}
