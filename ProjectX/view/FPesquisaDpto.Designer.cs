namespace ProjectX.view
{
    partial class FPesquisaDpto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPesquisaDpto));
            panel2 = new Panel();
            botaoCancelar = new Button();
            botaoConfirmar = new Button();
            GridDpto = new DataGridView();
            panel1 = new Panel();
            botaoPesquisar = new Button();
            txtPesquisar = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDpto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(botaoCancelar);
            panel2.Controls.Add(botaoConfirmar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 60);
            panel2.TabIndex = 5;
            // 
            // botaoCancelar
            // 
            botaoCancelar.Location = new Point(296, 16);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(99, 32);
            botaoCancelar.TabIndex = 1;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // botaoConfirmar
            // 
            botaoConfirmar.Location = new Point(191, 16);
            botaoConfirmar.Name = "botaoConfirmar";
            botaoConfirmar.Size = new Size(99, 32);
            botaoConfirmar.TabIndex = 0;
            botaoConfirmar.Text = "Confirmar";
            botaoConfirmar.UseVisualStyleBackColor = true;
            botaoConfirmar.Click += botaoConfirmar_Click;
            // 
            // GridDpto
            // 
            GridDpto.AllowUserToAddRows = false;
            GridDpto.AllowUserToDeleteRows = false;
            GridDpto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDpto.Dock = DockStyle.Fill;
            GridDpto.Location = new Point(0, 60);
            GridDpto.Name = "GridDpto";
            GridDpto.ReadOnly = true;
            GridDpto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridDpto.Size = new Size(610, 306);
            GridDpto.TabIndex = 4;
            GridDpto.CellContentClick += GridDpto_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(botaoPesquisar);
            panel1.Controls.Add(txtPesquisar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 60);
            panel1.TabIndex = 3;
            // 
            // botaoPesquisar
            // 
            botaoPesquisar.Image = (Image)resources.GetObject("botaoPesquisar.Image");
            botaoPesquisar.Location = new Point(487, 15);
            botaoPesquisar.Name = "botaoPesquisar";
            botaoPesquisar.Size = new Size(111, 34);
            botaoPesquisar.TabIndex = 1;
            botaoPesquisar.Text = "Pesquisar";
            botaoPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            botaoPesquisar.UseVisualStyleBackColor = true;
            botaoPesquisar.Click += botaoPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(12, 20);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(469, 23);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // FPesquisaDpto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 366);
            Controls.Add(panel2);
            Controls.Add(GridDpto);
            Controls.Add(panel1);
            Name = "FPesquisaDpto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RespoView";
            Load += FPesquisaDpto_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridDpto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button botaoCancelar;
        private Button botaoConfirmar;
        private DataGridView GridDpto;
        private Panel panel1;
        private Button botaoPesquisar;
        private TextBox txtPesquisar;
    }
}