namespace ListaExerciciosMariana
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            toolBar = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnListagem = new ToolStripButton();
            btnTeste = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            menuBar = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            displinaMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            questaoMenuItem = new ToolStripMenuItem();
            testeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            toolBar.SuspendLayout();
            menuBar.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(230, 235, 239);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 468);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(876, 31);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "[rodape]";
            // 
            // labelRodape
            // 
            labelRodape.Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRodape.Margin = new Padding(16, 4, 0, 2);
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(72, 25);
            labelRodape.Text = "rodape";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panelRegistros.Location = new Point(0, 91);
            panelRegistros.Margin = new Padding(3, 4, 3, 4);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(876, 408);
            panelRegistros.TabIndex = 8;
            // 
            // toolBar
            // 
            toolBar.BackColor = Color.FromArgb(230, 235, 239);
            toolBar.Enabled = false;
            toolBar.GripStyle = ToolStripGripStyle.Hidden;
            toolBar.ImageScalingSize = new Size(20, 20);
            toolBar.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnListagem, btnTeste, toolStripSeparator1, labelTipoCadastro });
            toolBar.Location = new Point(0, 38);
            toolBar.Name = "toolBar";
            toolBar.RenderMode = ToolStripRenderMode.System;
            toolBar.Size = new Size(876, 53);
            toolBar.TabIndex = 7;
            toolBar.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = WinForm.Properties.Resources.adicionarIcon;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Margin = new Padding(15, 1, 0, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(50, 50);
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = WinForm.Properties.Resources.editarIcon;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(50, 50);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = WinForm.Properties.Resources.deletarIcon;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(50, 50);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 53);
            // 
            // btnListagem
            // 
            btnListagem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnListagem.Image = WinForm.Properties.Resources.listaIcon;
            btnListagem.ImageScaling = ToolStripItemImageScaling.None;
            btnListagem.ImageTransparentColor = Color.Magenta;
            btnListagem.Name = "btnListagem";
            btnListagem.Padding = new Padding(7);
            btnListagem.Size = new Size(50, 50);
            btnListagem.Click += btnListagem_Click;
            // 
            // btnTeste
            // 
            btnTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTeste.Image = WinForm.Properties.Resources.testIcon;
            btnTeste.ImageScaling = ToolStripItemImageScaling.None;
            btnTeste.ImageTransparentColor = Color.Magenta;
            btnTeste.Name = "btnTeste";
            btnTeste.Padding = new Padding(7);
            btnTeste.Size = new Size(50, 50);
            btnTeste.Click += btnTeste_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 53);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(152, 50);
            labelTipoCadastro.Text = "Tipo de cadastro";
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.FromArgb(230, 235, 239);
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Padding = new Padding(7, 3, 0, 3);
            menuBar.Size = new Size(876, 38);
            menuBar.TabIndex = 6;
            menuBar.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { displinaMenuItem, materiaMenuItem, questaoMenuItem, testeToolStripMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastrosToolStripMenuItem.Margin = new Padding(15, 0, 0, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(112, 32);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // displinaMenuItem
            // 
            displinaMenuItem.Name = "displinaMenuItem";
            displinaMenuItem.Size = new Size(182, 32);
            displinaMenuItem.Text = "Disciplina";
            displinaMenuItem.Click += displinaMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(182, 32);
            materiaMenuItem.Text = "Materia";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // questaoMenuItem
            // 
            questaoMenuItem.Name = "questaoMenuItem";
            questaoMenuItem.Size = new Size(182, 32);
            questaoMenuItem.Text = "Questão";
            questaoMenuItem.Click += questaoMenuItem_Click;
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(182, 32);
            testeToolStripMenuItem.Text = "Teste";
            testeToolStripMenuItem.Click += testeToolStripMenuItem_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 499);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolBar);
            Controls.Add(menuBar);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolBar.ResumeLayout(false);
            toolBar.PerformLayout();
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private Panel panelRegistros;
        private ToolStrip toolBar;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnTeste;
        private ToolStripLabel labelTipoCadastro;
        private MenuStrip menuBar;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem displinaMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem questaoMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnListagem;
    }
}