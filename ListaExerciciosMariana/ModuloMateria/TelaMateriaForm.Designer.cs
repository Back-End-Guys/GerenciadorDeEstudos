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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbDisciplina = new ComboBox();
            cbAno = new ComboBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Snow;
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(124, 76);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(223, 32);
            txtNome.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightSteelBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(235, 232);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 56);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.None;
            btnGravar.BackColor = Color.LightSteelBlue;
            btnGravar.Cursor = Cursors.Hand;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(123, 232);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 56);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(124, 27);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(223, 32);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 9;
            label2.Text = "Nome :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 8;
            label1.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 130);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 14;
            label3.Text = "Disciplina :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 181);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 16;
            label4.Text = "Ano :";
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.Snow;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(124, 126);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(223, 33);
            cbDisciplina.TabIndex = 17;
            // 
            // cbAno
            // 
            cbAno.BackColor = Color.Snow;
            cbAno.FormattingEnabled = true;
            cbAno.Location = new Point(124, 177);
            cbAno.Name = "cbAno";
            cbAno.Size = new Size(223, 33);
            cbAno.TabIndex = 18;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(408, 311);
            Controls.Add(cbAno);
            Controls.Add(cbDisciplina);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label3;
        private Label label4;
        private ComboBox cbDisciplina;
        private ComboBox cbAno;
    }
}