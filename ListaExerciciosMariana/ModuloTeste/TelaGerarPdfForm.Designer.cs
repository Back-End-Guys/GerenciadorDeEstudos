namespace ListaExerciciosMariana.WinForm.ModuloPdf
{
    partial class TelaGerarPdfForm
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
            rbQuestoes = new RadioButton();
            groupBox1 = new GroupBox();
            rbGabarito = new RadioButton();
            txtDiretorio = new TextBox();
            btnCancelar = new Button();
            btnGerar = new Button();
            btnDiretorio = new Button();
            panel1 = new Panel();
            txtNome = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbQuestoes
            // 
            rbQuestoes.AutoSize = true;
            rbQuestoes.Location = new Point(15, 49);
            rbQuestoes.Name = "rbQuestoes";
            rbQuestoes.Size = new Size(175, 29);
            rbQuestoes.TabIndex = 0;
            rbQuestoes.TabStop = true;
            rbQuestoes.Text = "Apenas questões";
            rbQuestoes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(rbGabarito);
            groupBox1.Controls.Add(rbQuestoes);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 104);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opções de PDF :";
            // 
            // rbGabarito
            // 
            rbGabarito.AutoSize = true;
            rbGabarito.Location = new Point(196, 49);
            rbGabarito.Name = "rbGabarito";
            rbGabarito.Size = new Size(228, 29);
            rbGabarito.TabIndex = 1;
            rbGabarito.TabStop = true;
            rbGabarito.Text = "Questões com gabarito";
            rbGabarito.UseVisualStyleBackColor = true;
            // 
            // txtDiretorio
            // 
            txtDiretorio.BackColor = Color.Snow;
            txtDiretorio.Enabled = false;
            txtDiretorio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiretorio.Location = new Point(17, 195);
            txtDiretorio.Margin = new Padding(3, 4, 3, 4);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.ReadOnly = true;
            txtDiretorio.Size = new Size(453, 32);
            txtDiretorio.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightSteelBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Lavender;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(292, 362);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 56);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGerar
            // 
            btnGerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGerar.BackColor = Color.LightSteelBlue;
            btnGerar.Cursor = Cursors.Hand;
            btnGerar.DialogResult = DialogResult.OK;
            btnGerar.FlatAppearance.BorderSize = 0;
            btnGerar.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnGerar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerar.Location = new Point(151, 362);
            btnGerar.Margin = new Padding(3, 4, 3, 4);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(135, 56);
            btnGerar.TabIndex = 7;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnDiretorio
            // 
            btnDiretorio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDiretorio.BackColor = SystemColors.GradientInactiveCaption;
            btnDiretorio.Cursor = Cursors.Hand;
            btnDiretorio.DialogResult = DialogResult.OK;
            btnDiretorio.FlatAppearance.BorderSize = 0;
            btnDiretorio.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnDiretorio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiretorio.Location = new Point(17, 248);
            btnDiretorio.Margin = new Padding(3, 4, 3, 4);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(453, 56);
            btnDiretorio.TabIndex = 11;
            btnDiretorio.Text = "Buscar diretório";
            btnDiretorio.UseVisualStyleBackColor = false;
            btnDiretorio.Click += btnDiretorio_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDiretorio);
            panel1.Controls.Add(txtDiretorio);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(33, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 321);
            panel1.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Snow;
            txtNome.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(127, 17);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(343, 32);
            txtNome.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 13;
            label2.Text = "Estudante :";
            // 
            // TelaEscolhaPdfForm
            // 
            AcceptButton = btnGerar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(560, 431);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGerar);
            Name = "TelaEscolhaPdfForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar pdf";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbQuestoes;
        private GroupBox groupBox1;
        private RadioButton rbGabarito;
        private Button btnCancelar;
        private Button btnGerar;
        private TextBox txtDiretorio;
        private Button btnDiretorio;
        private Panel panel1;
        private TextBox txtNome;
        private Label label2;
    }
}