namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    partial class ListagemGabaritoControl
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
            lista = new ListView();
            SuspendLayout();
            // 
            // lista
            // 
            lista.BackColor = Color.Snow;
            lista.Dock = DockStyle.Fill;
            lista.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lista.Location = new Point(0, 0);
            lista.Name = "lista";
            lista.Size = new Size(828, 466);
            lista.TabIndex = 0;
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // ListagemGabaritoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lista);
            Name = "ListagemGabaritoControl";
            Size = new Size(828, 466);
            ResumeLayout(false);
        }

        #endregion

        private ListView lista;
    }
}
