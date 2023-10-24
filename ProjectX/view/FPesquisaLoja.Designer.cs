namespace ProjectX.view
{
    partial class FPesquisaLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPesquisaLoja));
            panel2 = new Panel();
            botaoCancelar = new Button();
            botaoConfirmar = new Button();
            GridLoja = new DataGridView();
            panel1 = new Panel();
            botaoPesquisar = new Button();
            txtPesquisar = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridLoja).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(botaoCancelar);
            panel2.Controls.Add(botaoConfirmar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 329);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 60);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
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
            // GridLoja
            // 
            GridLoja.AllowUserToAddRows = false;
            GridLoja.AllowUserToDeleteRows = false;
            GridLoja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridLoja.Dock = DockStyle.Fill;
            GridLoja.Location = new Point(0, 60);
            GridLoja.Name = "GridLoja";
            GridLoja.ReadOnly = true;
            GridLoja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridLoja.Size = new Size(613, 329);
            GridLoja.TabIndex = 7;
            GridLoja.CellContentClick += GridLoja_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(botaoPesquisar);
            panel1.Controls.Add(txtPesquisar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 60);
            panel1.TabIndex = 6;
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
            // 
            // FPesquisaLoja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 389);
            Controls.Add(panel2);
            Controls.Add(GridLoja);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FPesquisaLoja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RespoView";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridLoja).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button botaoCancelar;
        private Button botaoConfirmar;
        private DataGridView GridLoja;
        private Panel panel1;
        private Button botaoPesquisar;
        private TextBox txtPesquisar;
    }
}