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
            btnCancelar = new Button();
            btnGravar = new Button();
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
            txtNome.Location = new Point(91, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 27);
            txtNome.TabIndex = 11;
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
            txtId.Location = new Point(91, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(47, 27);
            txtId.TabIndex = 10;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 9;
            label2.Text = "Nome :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 8;
            label1.Text = "ID :";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightSteelBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(191, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.LightSteelBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnGravar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGravar.Location = new Point(93, 263);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(98, 42);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // disciplina
            // 
            disciplina.AutoSize = true;
            disciplina.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            disciplina.Location = new Point(5, 130);
            disciplina.Name = "disciplina";
            disciplina.Size = new Size(77, 20);
            disciplina.TabIndex = 14;
            disciplina.Text = "Disciplina:";
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.Snow;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(91, 127);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(196, 23);
            cbDisciplina.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 183);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 16;
            label3.Text = "Ano:";
            // 
            // rdbPrimeiro
            // 
            rdbPrimeiro.AutoSize = true;
            rdbPrimeiro.Location = new Point(102, 185);
            rdbPrimeiro.Name = "rdbPrimeiro";
            rdbPrimeiro.Size = new Size(36, 19);
            rdbPrimeiro.TabIndex = 17;
            rdbPrimeiro.TabStop = true;
            rdbPrimeiro.Text = "1°";
            rdbPrimeiro.UseVisualStyleBackColor = true;
            // 
            // rdbSegundo
            // 
            rdbSegundo.AutoSize = true;
            rdbSegundo.Location = new Point(179, 185);
            rdbSegundo.Name = "rdbSegundo";
            rdbSegundo.Size = new Size(36, 19);
            rdbSegundo.TabIndex = 18;
            rdbSegundo.TabStop = true;
            rdbSegundo.Text = "2°";
            rdbSegundo.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 328);
            Controls.Add(rdbSegundo);
            Controls.Add(rdbPrimeiro);
            Controls.Add(label3);
            Controls.Add(cbDisciplina);
            Controls.Add(disciplina);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
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
        private Button btnCancelar;
        private Button btnGravar;
        private Label disciplina;
        private ComboBox cbDisciplina;
        private Label label3;
        private RadioButton rdbPrimeiro;
        private RadioButton rdbSegundo;
    }
}