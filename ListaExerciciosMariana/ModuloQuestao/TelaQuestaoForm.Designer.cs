namespace ListaExerciciosMariana.WinForm.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            chListAlternativas = new CheckedListBox();
            label4 = new Label();
            txtEnunciado = new TextBox();
            label3 = new Label();
            cbMateria = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            label5 = new Label();
            btnRemover = new Button();
            btnAdicionar = new Button();
            txtResposta = new TextBox();
            txtAno = new TextBox();
            SuspendLayout();
            // 
            // chListAlternativas
            // 
            chListAlternativas.BackColor = Color.Snow;
            chListAlternativas.Cursor = Cursors.Hand;
            chListAlternativas.FormattingEnabled = true;
            chListAlternativas.Location = new Point(124, 304);
            chListAlternativas.Margin = new Padding(4, 5, 4, 5);
            chListAlternativas.Name = "chListAlternativas";
            chListAlternativas.Size = new Size(553, 166);
            chListAlternativas.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 25;
            label4.Text = "Resposta :";
            // 
            // txtEnunciado
            // 
            txtEnunciado.BackColor = Color.Snow;
            txtEnunciado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnunciado.Location = new Point(124, 58);
            txtEnunciado.Margin = new Padding(4, 5, 4, 5);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.PlaceholderText = "Inserir enunciado";
            txtEnunciado.ScrollBars = ScrollBars.Vertical;
            txtEnunciado.Size = new Size(553, 87);
            txtEnunciado.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 23;
            label3.Text = "Enunciado :";
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.Snow;
            cbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMateria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(124, 8);
            cbMateria.Margin = new Padding(4, 5, 4, 5);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(245, 33);
            cbMateria.TabIndex = 22;
            cbMateria.SelectedValueChanged += cbMateria_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 21;
            label2.Text = "Matéria :";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(626, 9);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(51, 32);
            txtId.TabIndex = 20;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(579, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 19;
            label1.Text = "ID :";
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
            btnCancelar.Location = new Point(408, 479);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 56);
            btnCancelar.TabIndex = 30;
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
            btnGravar.Location = new Point(281, 479);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 56);
            btnGravar.TabIndex = 29;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(378, 11);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 31;
            label5.Text = "Ano :";
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.None;
            btnRemover.BackColor = SystemColors.GradientInactiveCaption;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnRemover.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemover.Location = new Point(408, 251);
            btnRemover.Margin = new Padding(3, 4, 3, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(269, 44);
            btnRemover.TabIndex = 34;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Anchor = AnchorStyles.None;
            btnAdicionar.BackColor = SystemColors.GradientInactiveCaption;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnAdicionar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(124, 251);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(269, 44);
            btnAdicionar.TabIndex = 33;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtResposta
            // 
            txtResposta.BackColor = Color.Snow;
            txtResposta.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtResposta.Location = new Point(124, 155);
            txtResposta.Margin = new Padding(4, 5, 4, 5);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.PlaceholderText = "Inserir alternativas";
            txtResposta.ScrollBars = ScrollBars.Vertical;
            txtResposta.Size = new Size(553, 87);
            txtResposta.TabIndex = 35;
            // 
            // txtAno
            // 
            txtAno.BackColor = SystemColors.GradientActiveCaption;
            txtAno.Enabled = false;
            txtAno.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAno.ForeColor = SystemColors.MenuText;
            txtAno.Location = new Point(441, 8);
            txtAno.Margin = new Padding(4, 5, 4, 5);
            txtAno.Name = "txtAno";
            txtAno.ReadOnly = true;
            txtAno.Size = new Size(136, 32);
            txtAno.TabIndex = 36;
            // 
            // TelaQuestaoForm
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(727, 547);
            Controls.Add(txtAno);
            Controls.Add(chListAlternativas);
            Controls.Add(txtResposta);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label4);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaQuestaoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox chListAlternativas;
        private Label label4;
        private TextBox txtEnunciado;
        private Label label3;
        private ComboBox cbMateria;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label5;
        private Button btnRemover;
        private Button btnAdicionar;
        private TextBox txtResposta;
        private TextBox txtAno;
    }
}