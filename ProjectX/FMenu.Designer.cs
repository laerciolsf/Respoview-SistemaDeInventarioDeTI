namespace ProjectX
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
            rToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventarioToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            cadastroToolStripMenuItem.Size = new Size(180, 22);
            cadastroToolStripMenuItem.Text = "Cadastrar";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // itensToolStripMenuItem
            // 
            itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            itensToolStripMenuItem.Size = new Size(180, 22);
            itensToolStripMenuItem.Text = "Item";
            itensToolStripMenuItem.Click += itensToolStripMenuItem_Click;
            // 
            // departamentoToolStripMenuItem
            // 
            departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            departamentoToolStripMenuItem.Size = new Size(180, 22);
            departamentoToolStripMenuItem.Text = "Departamento";
            departamentoToolStripMenuItem.Click += departamentoToolStripMenuItem_Click;
            // 
            // lojaToolStripMenuItem
            // 
            lojaToolStripMenuItem.Name = "lojaToolStripMenuItem";
            lojaToolStripMenuItem.Size = new Size(180, 22);
            lojaToolStripMenuItem.Text = "Loja";
            lojaToolStripMenuItem.Click += lojaToolStripMenuItem_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itensRemovidosToolStripMenuItem });
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(180, 22);
            historicoToolStripMenuItem.Text = "Historico";
            // 
            // itensRemovidosToolStripMenuItem
            // 
            itensRemovidosToolStripMenuItem.Name = "itensRemovidosToolStripMenuItem";
            itensRemovidosToolStripMenuItem.Size = new Size(158, 22);
            itensRemovidosToolStripMenuItem.Text = "Itens removidos";
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(180, 22);
            rToolStripMenuItem.Text = "Relatórios";
            rToolStripMenuItem.Click += rToolStripMenuItem_Click;
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
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 539);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "RespoView";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}