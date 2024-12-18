﻿namespace ProjectX
{
    partial class FMenu
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
            menuStrip1 = new MenuStrip();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            itensToolStripMenuItem = new ToolStripMenuItem();
            departamentoToolStripMenuItem = new ToolStripMenuItem();
            lojaToolStripMenuItem = new ToolStripMenuItem();
            historicoToolStripMenuItem = new ToolStripMenuItem();
            itensRemovidosToolStripMenuItem = new ToolStripMenuItem();
            itensAlteradosToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem1 = new ToolStripMenuItem();
            segurançaToolStripMenuItem = new ToolStripMenuItem();
            alterarMinhaSenhaToolStripMenuItem = new ToolStripMenuItem();
            bitlokerToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, usuariosToolStripMenuItem, segurançaToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, historicoToolStripMenuItem, rToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(72, 20);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itensToolStripMenuItem, departamentoToolStripMenuItem, lojaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(126, 22);
            cadastroToolStripMenuItem.Text = "Cadastrar";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(150, 22);
            itensToolStripMenuItem.Text = "Item";
            itensToolStripMenuItem.Click += itensToolStripMenuItem_Click;
            // 
            // departamentoToolStripMenuItem
            // 
            departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            departamentoToolStripMenuItem.Size = new Size(150, 22);
            departamentoToolStripMenuItem.Text = "Departamento";
            departamentoToolStripMenuItem.Click += departamentoToolStripMenuItem_Click;
            // 
            // lojaToolStripMenuItem
            // 
            lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            lojaToolStripMenuItem.Size = new Size(150, 22);
            lojaToolStripMenuItem.Text = "Loja";
            lojaToolStripMenuItem.Click += lojaToolStripMenuItem_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itensRemovidosToolStripMenuItem, itensAlteradosToolStripMenuItem });
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(126, 22);
            historicoToolStripMenuItem.Text = "Historico";
            // 
            // itensRemovidosToolStripMenuItem
            // 
            itensRemovidosToolStripMenuItem.Name = "itensRemovidosToolStripMenuItem";
            itensRemovidosToolStripMenuItem.Size = new Size(152, 22);
            itensRemovidosToolStripMenuItem.Text = "Itens Excluidos";
            itensRemovidosToolStripMenuItem.Click += itensRemovidosToolStripMenuItem_Click;
            // 
            // itensAlteradosToolStripMenuItem
            // 
            itensAlteradosToolStripMenuItem.Name = "itensAlteradosToolStripMenuItem";
            itensAlteradosToolStripMenuItem.Size = new Size(152, 22);
            itensAlteradosToolStripMenuItem.Text = "Itens Alterados";
            itensAlteradosToolStripMenuItem.Click += itensAlteradosToolStripMenuItem_Click;
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatoriosToolStripMenuItem });
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(126, 22);
            rToolStripMenuItem.Text = "Relatórios";
            rToolStripMenuItem.Click += rToolStripMenuItem_Click;
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(126, 22);
            relatoriosToolStripMenuItem.Text = "Relatórios";
            relatoriosToolStripMenuItem.Click += relatoriosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            usuariosToolStripMenuItem.Enabled = false;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem1 });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuarioToolStripMenuItem1
            // 
            usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            usuarioToolStripMenuItem1.Size = new Size(114, 22);
            usuarioToolStripMenuItem1.Text = "Usuario";
            usuarioToolStripMenuItem1.Click += usuarioToolStripMenuItem1_Click;
            // 
            // segurançaToolStripMenuItem
            // 
            segurançaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarMinhaSenhaToolStripMenuItem, bitlokerToolStripMenuItem });
            segurançaToolStripMenuItem.Name = "segurançaToolStripMenuItem";
            segurançaToolStripMenuItem.Size = new Size(74, 20);
            segurançaToolStripMenuItem.Text = "Segurança";
            // 
            // alterarMinhaSenhaToolStripMenuItem
            // 
            alterarMinhaSenhaToolStripMenuItem.Name = "alterarMinhaSenhaToolStripMenuItem";
            alterarMinhaSenhaToolStripMenuItem.Size = new Size(181, 22);
            alterarMinhaSenhaToolStripMenuItem.Text = "Alterar Minha Senha";
            // 
            // bitlokerToolStripMenuItem
            // 
            bitlokerToolStripMenuItem.Name = "bitlokerToolStripMenuItem";
            bitlokerToolStripMenuItem.Size = new Size(181, 22);
            bitlokerToolStripMenuItem.Text = "Chaves BitLocker";
            bitlokerToolStripMenuItem.Click += bitlokerToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sobreToolStripMenuItem1 });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(114, 22);
            sobreToolStripMenuItem.Text = "Manual";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(114, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 45);
            panel1.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 24);
            label1.TabIndex = 0;
            label1.Text = "Controle de Equipamentos de TI\r\n";
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 539);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem historicoToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ToolStripMenuItem itensToolStripMenuItem;
        private ToolStripMenuItem departamentoToolStripMenuItem;
        private ToolStripMenuItem lojaToolStripMenuItem;
        private ToolStripMenuItem itensRemovidosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private Panel panel1;
        private Label label1;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem segurançaToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem alterarMinhaSenhaToolStripMenuItem;
        private ToolStripMenuItem bitlokerToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem1;
        private ToolStripMenuItem itensAlteradosToolStripMenuItem;
    }
}