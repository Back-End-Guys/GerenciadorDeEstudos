namespace ListaExerciciosMariana.WinForm.ModuloMateria
{
    partial class TelaMateriaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            disciplina = new Label();
            cbDisciplina = new ComboBox();
            label3 = new Label();
            rdbPrimeiro = new RadioButton();
            rdbSegundo = new RadioButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Snow;
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(118, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 32);
            txtNome.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(118, 25);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(196, 32);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 9;
            label2.Text = "Nome :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 8;
            label1.Text = "ID :";
            // 
            // disciplina
            // 
            disciplina.AutoSize = true;
            disciplina.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            disciplina.Location = new Point(14, 132);
            disciplina.Name = "disciplina";
            disciplina.Size = new Size(103, 25);
            disciplina.TabIndex = 14;
            disciplina.Text = "Disciplina :";
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.Snow;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(118, 129);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(196, 33);
            cbDisciplina.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 188);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 16;
            label3.Text = "Ano :";
            // 
            // rdbPrimeiro
            // 
            rdbPrimeiro.AutoSize = true;
            rdbPrimeiro.Location = new Point(118, 188);
            rdbPrimeiro.Name = "rdbPrimeiro";
            rdbPrimeiro.Size = new Size(50, 29);
            rdbPrimeiro.TabIndex = 17;
            rdbPrimeiro.TabStop = true;
            rdbPrimeiro.Text = "1°";
            rdbPrimeiro.UseVisualStyleBackColor = true;
            // 
            // rdbSegundo
            // 
            rdbSegundo.AutoSize = true;
            rdbSegundo.Location = new Point(195, 188);
            rdbSegundo.Name = "rdbSegundo";
            rdbSegundo.Size = new Size(50, 29);
            rdbSegundo.TabIndex = 18;
            rdbSegundo.TabStop = true;
            rdbSegundo.Text = "2°";
            rdbSegundo.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 328);
            Controls.Add(rdbSegundo);
            Controls.Add(rdbPrimeiro);
            Controls.Add(label3);
            Controls.Add(cbDisciplina);
            Controls.Add(disciplina);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TelaMateriaForm";
            Text = "TelaMateriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Label disciplina;
        private ComboBox cbDisciplina;
        private Label label3;
        private RadioButton rdbPrimeiro;
        private RadioButton rdbSegundo;
    }
}