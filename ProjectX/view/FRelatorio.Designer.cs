namespace ProjectX.view
{
    partial class FRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRelatorio));
            buttonPesquisa1 = new Button();
            buttonPesquisa2 = new Button();
            txtLoja = new TextBox();
            label15 = new Label();
            txtDpto = new TextBox();
            label14 = new Label();
            BPesquisa = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            labelNomeLoja = new Label();
            labelNomeDpto = new Label();
            toolStrip1 = new ToolStrip();
            botaoFechar = new ToolStripButton();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPesquisa1
            // 
            buttonPesquisa1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa1.Image = (Image)resources.GetObject("buttonPesquisa1.Image");
            buttonPesquisa1.Location = new Point(530, 99);
            buttonPesquisa1.Name = "buttonPesquisa1";
            buttonPesquisa1.Size = new Size(31, 31);
            buttonPesquisa1.TabIndex = 53;
            buttonPesquisa1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa1.UseVisualStyleBackColor = true;
            buttonPesquisa1.Click += buttonPesquisa1_Click;
            // 
            // buttonPesquisa2
            // 
            buttonPesquisa2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa2.Image = (Image)resources.GetObject("buttonPesquisa2.Image");
            buttonPesquisa2.Location = new Point(125, 99);
            buttonPesquisa2.Name = "buttonPesquisa2";
            buttonPesquisa2.Size = new Size(31, 31);
            buttonPesquisa2.TabIndex = 52;
            buttonPesquisa2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa2.UseVisualStyleBackColor = true;
            buttonPesquisa2.Click += buttonPesquisa2_Click;
            // 
            // txtLoja
            // 
            txtLoja.Location = new Point(52, 104);
            txtLoja.Name = "txtLoja";
            txtLoja.Size = new Size(67, 23);
            txtLoja.TabIndex = 51;
            txtLoja.TextChanged += txtLoja_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 107);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 50;
            label15.Text = "Loja:";
            // 
            // txtDpto
            // 
            txtDpto.Location = new Point(456, 104);
            txtDpto.Name = "txtDpto";
            txtDpto.Size = new Size(68, 23);
            txtDpto.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(364, 107);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 48;
            label14.Text = "Departamento:";
            // 
            // BPesquisa
            // 
            BPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPesquisa.Image = (Image)resources.GetObject("BPesquisa.Image");
            BPesquisa.Location = new Point(878, 496);
            BPesquisa.Name = "BPesquisa";
            BPesquisa.Size = new Size(99, 30);
            BPesquisa.TabIndex = 54;
            BPesquisa.Text = "Pesquisar";
            BPesquisa.TextImageRelation = TextImageRelation.ImageBeforeText;
            BPesquisa.UseVisualStyleBackColor = true;
            BPesquisa.Click += BPesquisa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(965, 354);
            dataGridView1.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 45);
            panel1.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 24);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Relatórios";
            // 
            // labelNomeLoja
            // 
            labelNomeLoja.AutoSize = true;
            labelNomeLoja.Location = new Point(162, 107);
            labelNomeLoja.Name = "labelNomeLoja";
            labelNomeLoja.Size = new Size(0, 15);
            labelNomeLoja.TabIndex = 58;
            // 
            // labelNomeDpto
            // 
            labelNomeDpto.AutoSize = true;
            labelNomeDpto.Location = new Point(567, 107);
            labelNomeDpto.Name = "labelNomeDpto";
            labelNomeDpto.Size = new Size(0, 15);
            labelNomeDpto.TabIndex = 59;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.LightGray;
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoFechar });
            toolStrip1.Location = new Point(0, 45);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(989, 40);
            toolStrip1.TabIndex = 60;
            toolStrip1.Text = "toolStrip1";
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
            // button2
            // 
            button2.Location = new Point(733, 496);
            button2.Name = "button2";
            button2.Size = new Size(139, 30);
            button2.TabIndex = 61;
            button2.Text = "Exportar Relatórios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FRelatorio
            // 
            AcceptButton = BPesquisa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 538);
            Controls.Add(button2);
            Controls.Add(toolStrip1);
            Controls.Add(labelNomeDpto);
            Controls.Add(buttonPesquisa1);
            Controls.Add(labelNomeLoja);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(BPesquisa);
            Controls.Add(buttonPesquisa2);
            Controls.Add(txtLoja);
            Controls.Add(label15);
            Controls.Add(txtDpto);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RespoView";
            Load += FRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisa1;
        private Button buttonPesquisa2;
        private TextBox txtLoja;
        private Label label15;
        private TextBox txtDpto;
        private Label label14;
        private Button BPesquisa;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label labelNomeLoja;
        private Label labelNomeDpto;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoFechar;
        private Button button2;
    }
}