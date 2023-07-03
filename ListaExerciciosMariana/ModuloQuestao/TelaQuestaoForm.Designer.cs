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
            groupBox1 = new GroupBox();
            btnRemover = new Button();
            chListAlternativas = new CheckedListBox();
            btnAdicionar = new Button();
            txtResposta = new TextBox();
            label4 = new Label();
            txtEnunciado = new TextBox();
            label3 = new Label();
            cbMateria = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(chListAlternativas);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 183);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(9, 22);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 17;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // chListAlternativas
            // 
            chListAlternativas.FormattingEnabled = true;
            chListAlternativas.Location = new Point(6, 51);
            chListAlternativas.Name = "chListAlternativas";
            chListAlternativas.Size = new Size(274, 112);
            chListAlternativas.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(226, 91);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 27;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(81, 91);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(139, 23);
            txtResposta.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 94);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 25;
            label4.Text = "Resposta";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(81, 52);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(220, 23);
            txtEnunciado.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 23;
            label3.Text = "Enunciado";
            // 
            // cbMateria
            // 
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(81, 13);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(129, 23);
            cbMateria.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 16);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 21;
            label2.Text = "Materia";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(282, 13);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(19, 23);
            txtId.TabIndex = 20;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 16);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 19;
            label1.Text = "id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(121, 329);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(87, 37);
            btnGravar.TabIndex = 18;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(214, 329);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 37);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 380);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(label4);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaQuestaoForm";
            Text = "TelaQuestaoForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRemover;
        private CheckedListBox chListAlternativas;
        private Button btnAdicionar;
        private TextBox txtResposta;
        private Label label4;
        private TextBox txtEnunciado;
        private Label label3;
        private ComboBox cbMateria;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}