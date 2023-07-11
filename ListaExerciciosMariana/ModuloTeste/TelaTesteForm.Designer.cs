namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    partial class TelaTesteForm
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
            txtAno = new TextBox();
            btnSortearQuestoes = new Button();
            label5 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cbMateria = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            txtTítulo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            listQuestoes = new ListBox();
            cbDisciplina = new ComboBox();
            label6 = new Label();
            chbRecuperacao = new CheckBox();
            txtQnt = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtQnt).BeginInit();
            SuspendLayout();
            // 
            // txtAno
            // 
            txtAno.BackColor = SystemColors.GradientActiveCaption;
            txtAno.Enabled = false;
            txtAno.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAno.Location = new Point(119, 167);
            txtAno.Margin = new Padding(4, 5, 4, 5);
            txtAno.Name = "txtAno";
            txtAno.ReadOnly = true;
            txtAno.Size = new Size(195, 32);
            txtAno.TabIndex = 51;
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Anchor = AnchorStyles.None;
            btnSortearQuestoes.BackColor = SystemColors.GradientInactiveCaption;
            btnSortearQuestoes.Cursor = Cursors.Hand;
            btnSortearQuestoes.FlatAppearance.BorderSize = 0;
            btnSortearQuestoes.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnSortearQuestoes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSortearQuestoes.Location = new Point(119, 211);
            btnSortearQuestoes.Margin = new Padding(3, 4, 3, 4);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(507, 44);
            btnSortearQuestoes.TabIndex = 48;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = false;
            btnSortearQuestoes.Click += btnSortearQuestoes_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 171);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 47;
            label5.Text = "Ano :";
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
            btnCancelar.Location = new Point(377, 506);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 56);
            btnCancelar.TabIndex = 46;
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
            btnGravar.Location = new Point(250, 506);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 56);
            btnGravar.TabIndex = 45;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.Snow;
            cbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMateria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(446, 115);
            cbMateria.Margin = new Padding(4, 5, 4, 5);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(180, 33);
            cbMateria.TabIndex = 41;
            cbMateria.SelectedIndexChanged += cbMateria_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 40;
            label2.Text = "Matéria :";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(118, 14);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(244, 32);
            txtId.TabIndex = 39;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 38;
            label1.Text = "ID :";
            // 
            // txtTítulo
            // 
            txtTítulo.BackColor = Color.Snow;
            txtTítulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTítulo.Location = new Point(118, 65);
            txtTítulo.Margin = new Padding(3, 4, 3, 4);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.PlaceholderText = "Teste de...";
            txtTítulo.Size = new Size(508, 32);
            txtTítulo.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 68);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 52;
            label3.Text = "Título :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(322, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 54;
            label4.Text = "Quantidade :";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 25;
            listQuestoes.Location = new Point(122, 267);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(507, 204);
            listQuestoes.TabIndex = 56;
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.Snow;
            cbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisciplina.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(118, 115);
            cbDisciplina.Margin = new Padding(4, 5, 4, 5);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(196, 33);
            cbDisciplina.TabIndex = 59;
            cbDisciplina.SelectedIndexChanged += cbDisciplina_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 119);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 58;
            label6.Text = "Disciplina :";
            // 
            // chbRecuperacao
            // 
            chbRecuperacao.AutoSize = true;
            chbRecuperacao.BackColor = SystemColors.GradientInactiveCaption;
            chbRecuperacao.Location = new Point(381, 17);
            chbRecuperacao.Name = "chbRecuperacao";
            chbRecuperacao.RightToLeft = RightToLeft.Yes;
            chbRecuperacao.Size = new Size(242, 29);
            chbRecuperacao.TabIndex = 60;
            chbRecuperacao.Text = "?É prova de recuperação";
            chbRecuperacao.UseVisualStyleBackColor = false;
            // 
            // txtQnt
            // 
            txtQnt.Location = new Point(446, 167);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(180, 32);
            txtQnt.TabIndex = 61;
            // 
            // TelaTesteForm
            // 
            AcceptButton = btnGravar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(689, 575);
            Controls.Add(txtQnt);
            Controls.Add(listQuestoes);
            Controls.Add(chbRecuperacao);
            Controls.Add(cbDisciplina);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtTítulo);
            Controls.Add(label3);
            Controls.Add(txtAno);
            Controls.Add(btnSortearQuestoes);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TelaTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)txtQnt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAno;
        private Button btnSortearQuestoes;
        private Label label5;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cbMateria;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private TextBox txtTítulo;
        private Label label3;
        private Label label4;
        private ListBox listQuestoes;
        private ComboBox cbDisciplina;
        private Label label6;
        private CheckBox chbRecuperacao;
        private NumericUpDown txtQnt;
    }
}