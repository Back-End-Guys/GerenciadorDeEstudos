﻿namespace ListaExerciciosMariana.WinForm.ModuloTeste
{
    partial class TelaDetalhesForm
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
            checkBox1 = new CheckBox();
            cbDisciplina = new ComboBox();
            label6 = new Label();
            txtQnt = new TextBox();
            label4 = new Label();
            txtTítulo = new TextBox();
            label3 = new Label();
            txtAno = new TextBox();
            label5 = new Label();
            cbMateria = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.GradientInactiveCaption;
            checkBox1.Location = new Point(387, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(242, 29);
            checkBox1.TabIndex = 73;
            checkBox1.Text = "?É prova de recuperação";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.Snow;
            cbDisciplina.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(124, 140);
            cbDisciplina.Margin = new Padding(4, 5, 4, 5);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(196, 33);
            cbDisciplina.TabIndex = 72;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 71;
            label6.Text = "Disciplina :";
            // 
            // txtQnt
            // 
            txtQnt.BackColor = Color.Snow;
            txtQnt.Enabled = false;
            txtQnt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtQnt.Location = new Point(422, 200);
            txtQnt.Margin = new Padding(4, 5, 4, 5);
            txtQnt.Name = "txtQnt";
            txtQnt.PlaceholderText = "10";
            txtQnt.ReadOnly = true;
            txtQnt.Size = new Size(210, 32);
            txtQnt.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(294, 204);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 69;
            label4.Text = "Quantidade :";
            // 
            // txtTítulo
            // 
            txtTítulo.BackColor = Color.Snow;
            txtTítulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtTítulo.Location = new Point(124, 81);
            txtTítulo.Margin = new Padding(3, 4, 3, 4);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.PlaceholderText = "Teste de...";
            txtTítulo.ReadOnly = true;
            txtTítulo.Size = new Size(508, 32);
            txtTítulo.TabIndex = 68;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 84);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 67;
            label3.Text = "Título :";
            // 
            // txtAno
            // 
            txtAno.BackColor = SystemColors.GradientActiveCaption;
            txtAno.Enabled = false;
            txtAno.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAno.Location = new Point(125, 200);
            txtAno.Margin = new Padding(4, 5, 4, 5);
            txtAno.Name = "txtAno";
            txtAno.ReadOnly = true;
            txtAno.Size = new Size(161, 32);
            txtAno.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 204);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 65;
            label5.Text = "Ano :";
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.Snow;
            cbMateria.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(422, 140);
            cbMateria.Margin = new Padding(4, 5, 4, 5);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(210, 33);
            cbMateria.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(328, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 63;
            label2.Text = "Matéria :";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.GradientActiveCaption;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(124, 30);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(244, 32);
            txtId.TabIndex = 62;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 61;
            label1.Text = "ID :";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.None;
            btnOK.BackColor = Color.LightSteelBlue;
            btnOK.Cursor = Cursors.Hand;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatAppearance.MouseDownBackColor = Color.Lavender;
            btnOK.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(128, 262);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(504, 50);
            btnOK.TabIndex = 74;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // TelaDetalhesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(687, 336);
            Controls.Add(btnOK);
            Controls.Add(checkBox1);
            Controls.Add(cbDisciplina);
            Controls.Add(label6);
            Controls.Add(txtQnt);
            Controls.Add(label4);
            Controls.Add(txtTítulo);
            Controls.Add(label3);
            Controls.Add(txtAno);
            Controls.Add(label5);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TelaDetalhesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private ComboBox cbDisciplina;
        private Label label6;
        private TextBox txtQnt;
        private Label label4;
        private TextBox txtTítulo;
        private Label label3;
        private TextBox txtAno;
        private Label label5;
        private ComboBox cbMateria;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Button btnOK;
    }
}