namespace ProjectX.view
{
    partial class FDpto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDpto));
            tabControl1 = new TabControl();
            tabPesquisa = new TabPage();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            botaoPesquisar = new Button();
            textBox1 = new TextBox();
            tabDados = new TabPage();
            txtUF = new ComboBox();
            label10 = new Label();
            txtNomeDpto = new TextBox();
            label3 = new Label();
            txtIdDpto = new TextBox();
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            botaoNovo = new ToolStripButton();
            botaoSalvar = new ToolStripButton();
            botaoExcluir = new ToolStripButton();
            botaoEditar = new ToolStripButton();
            botaoFechar = new ToolStripButton();
            panel1 = new Panel();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tabDados.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPesquisa);
            tabControl1.Controls.Add(tabDados);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 85);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 365);
            tabControl1.TabIndex = 8;
            // 
            // tabPesquisa
            // 
            tabPesquisa.Controls.Add(dataGridView1);
            tabPesquisa.Controls.Add(panel2);
            tabPesquisa.Location = new Point(4, 24);
            tabPesquisa.Name = "tabPesquisa";
            tabPesquisa.Padding = new Padding(3);
            tabPesquisa.Size = new Size(792, 337);
            tabPesquisa.TabIndex = 0;
            tabPesquisa.Text = "Pesquisar";
            tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(786, 265);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(botaoPesquisar);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 66);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(484, 13);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 2;
            button1.Text = "Pesquisar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // botaoPesquisar
            // 
            botaoPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botaoPesquisar.Image = (Image)resources.GetObject("botaoPesquisar.Image");
            botaoPesquisar.Location = new Point(1470, 12);
            botaoPesquisar.Name = "botaoPesquisar";
            botaoPesquisar.Size = new Size(113, 41);
            botaoPesquisar.TabIndex = 1;
            botaoPesquisar.Text = "Pesquisar";
            botaoPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            botaoPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(23, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(txtUF);
            tabDados.Controls.Add(label10);
            tabDados.Controls.Add(txtNomeDpto);
            tabDados.Controls.Add(label3);
            tabDados.Controls.Add(txtIdDpto);
            tabDados.Controls.Add(label2);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(792, 337);
            tabDados.TabIndex = 1;
            tabDados.Text = "Dados Gerais";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // txtUF
            // 
            txtUF.FormattingEnabled = true;
            txtUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txtUF.Location = new Point(171, 363);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(78, 23);
            txtUF.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(128, 369);
            label10.Name = "label10";
            label10.Size = new Size(24, 15);
            label10.TabIndex = 16;
            label10.Text = "UF:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // txtNomeDpto
            // 
            txtNomeDpto.Location = new Point(171, 69);
            txtNomeDpto.Name = "txtNomeDpto";
            txtNomeDpto.Size = new Size(355, 23);
            txtNomeDpto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 77);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Departamento:";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // txtIdDpto
            // 
            txtIdDpto.Location = new Point(171, 27);
            txtIdDpto.Name = "txtIdDpto";
            txtIdDpto.Size = new Size(100, 23);
            txtIdDpto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 33);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Gray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoNovo, botaoSalvar, botaoExcluir, botaoEditar, botaoFechar });
            toolStrip1.Location = new Point(0, 45);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(800, 40);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoNovo
            // 
            botaoNovo.Image = (Image)resources.GetObject("botaoNovo.Image");
            botaoNovo.ImageScaling = ToolStripItemImageScaling.None;
            botaoNovo.ImageTransparentColor = Color.Magenta;
            botaoNovo.Name = "botaoNovo";
            botaoNovo.Size = new Size(64, 37);
            botaoNovo.Text = "Novo";
            botaoNovo.Click += botaoNovo_Click;
            // 
            // botaoSalvar
            // 
            botaoSalvar.Image = (Image)resources.GetObject("botaoSalvar.Image");
            botaoSalvar.ImageScaling = ToolStripItemImageScaling.None;
            botaoSalvar.ImageTransparentColor = Color.Magenta;
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(66, 37);
            botaoSalvar.Text = "Salvar";
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // botaoExcluir
            // 
            botaoExcluir.Image = (Image)resources.GetObject("botaoExcluir.Image");
            botaoExcluir.ImageScaling = ToolStripItemImageScaling.None;
            botaoExcluir.ImageTransparentColor = Color.Magenta;
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.Size = new Size(70, 37);
            botaoExcluir.Text = "Excluir";
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // botaoEditar
            // 
            botaoEditar.Image = (Image)resources.GetObject("botaoEditar.Image");
            botaoEditar.ImageScaling = ToolStripItemImageScaling.None;
            botaoEditar.ImageTransparentColor = Color.Magenta;
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(65, 37);
            botaoEditar.Text = "Editar";
            botaoEditar.Click += botaoEditar_Click;
            // 
            // botaoFechar
            // 
            botaoFechar.Alignment = ToolStripItemAlignment.Right;
            botaoFechar.Image = (Image)resources.GetObject("botaoFechar.Image");
            botaoFechar.ImageScaling = ToolStripItemImageScaling.None;
            botaoFechar.ImageTransparentColor = Color.Magenta;
            botaoFechar.Name = "botaoFechar";
            botaoFechar.Size = new Size(70, 37);
            botaoFechar.Text = "Fechar";
            botaoFechar.Click += botaoFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 24);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Departamento";
            // 
            // FDpto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "FDpto";
            Text = "RespoView";
            Load += FDpto_Load;
            tabControl1.ResumeLayout(false);
            tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabDados.ResumeLayout(false);
            tabDados.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPesquisa;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button botaoPesquisar;
        private TextBox textBox1;
        private TabPage tabDados;
        private ComboBox txtUF;
        private Label label10;
        private TextBox txtNomeDpto;
        private Label label3;
        private TextBox txtIdDpto;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoNovo;
        private ToolStripButton botaoSalvar;
        private ToolStripButton botaoExcluir;
        private ToolStripButton botaoEditar;
        private ToolStripButton botaoFechar;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}