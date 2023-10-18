namespace ProjectX.view
{
    partial class FItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FItens));
            tabControl1 = new TabControl();
            tabPesquisa = new TabPage();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            BPesquisa = new Button();
            botaoPesquisar = new Button();
            textBox1 = new TextBox();
            tabDados = new TabPage();
            labelNomeLoja = new Label();
            labelNomeDpto = new Label();
            buttonPesquisa1 = new Button();
            buttonPesquisa2 = new Button();
            txtLoja = new TextBox();
            label15 = new Label();
            txtDpto = new TextBox();
            label14 = new Label();
            txtValor = new TextBox();
            txtSo = new TextBox();
            txtHd = new TextBox();
            txtMemoria = new TextBox();
            txtProcessador = new TextBox();
            txtModelo = new TextBox();
            txtFabricante = new TextBox();
            txtTipo = new TextBox();
            txtQtde = new TextBox();
            txtNome = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtUsuarioResponsavel = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
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
            tabControl1.Size = new Size(838, 431);
            tabControl1.TabIndex = 8;
            // 
            // tabPesquisa
            // 
            tabPesquisa.Controls.Add(dataGridView1);
            tabPesquisa.Controls.Add(panel2);
            tabPesquisa.Location = new Point(4, 24);
            tabPesquisa.Name = "tabPesquisa";
            tabPesquisa.Padding = new Padding(3);
            tabPesquisa.Size = new Size(830, 403);
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
            dataGridView1.Size = new Size(824, 331);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(BPesquisa);
            panel2.Controls.Add(botaoPesquisar);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 66);
            panel2.TabIndex = 0;
            // 
            // BPesquisa
            // 
            BPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPesquisa.Image = (Image)resources.GetObject("BPesquisa.Image");
            BPesquisa.Location = new Point(715, 13);
            BPesquisa.Name = "BPesquisa";
            BPesquisa.Size = new Size(92, 33);
            BPesquisa.TabIndex = 2;
            BPesquisa.Text = "Pesquisar";
            BPesquisa.TextImageRelation = TextImageRelation.ImageBeforeText;
            BPesquisa.UseVisualStyleBackColor = true;
            BPesquisa.Click += button1_Click;
            // 
            // botaoPesquisar
            // 
            botaoPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botaoPesquisar.Image = (Image)resources.GetObject("botaoPesquisar.Image");
            botaoPesquisar.Location = new Point(1508, 12);
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
            textBox1.Location = new Point(18, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(678, 23);
            textBox1.TabIndex = 0;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(labelNomeLoja);
            tabDados.Controls.Add(labelNomeDpto);
            tabDados.Controls.Add(buttonPesquisa1);
            tabDados.Controls.Add(buttonPesquisa2);
            tabDados.Controls.Add(txtLoja);
            tabDados.Controls.Add(label15);
            tabDados.Controls.Add(txtDpto);
            tabDados.Controls.Add(label14);
            tabDados.Controls.Add(txtValor);
            tabDados.Controls.Add(txtSo);
            tabDados.Controls.Add(txtHd);
            tabDados.Controls.Add(txtMemoria);
            tabDados.Controls.Add(txtProcessador);
            tabDados.Controls.Add(txtModelo);
            tabDados.Controls.Add(txtFabricante);
            tabDados.Controls.Add(txtTipo);
            tabDados.Controls.Add(txtQtde);
            tabDados.Controls.Add(txtNome);
            tabDados.Controls.Add(label13);
            tabDados.Controls.Add(label12);
            tabDados.Controls.Add(label11);
            tabDados.Controls.Add(label10);
            tabDados.Controls.Add(label9);
            tabDados.Controls.Add(label8);
            tabDados.Controls.Add(label7);
            tabDados.Controls.Add(label6);
            tabDados.Controls.Add(label5);
            tabDados.Controls.Add(label4);
            tabDados.Controls.Add(txtUsuarioResponsavel);
            tabDados.Controls.Add(label3);
            tabDados.Controls.Add(txtId);
            tabDados.Controls.Add(label2);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(830, 403);
            tabDados.TabIndex = 1;
            tabDados.Text = "Dados Gerais";
            tabDados.UseVisualStyleBackColor = true;
            tabDados.Click += tabDados_Click;
            // 
            // labelNomeLoja
            // 
            labelNomeLoja.AutoSize = true;
            labelNomeLoja.Location = new Point(665, 100);
            labelNomeLoja.Name = "labelNomeLoja";
            labelNomeLoja.Size = new Size(0, 15);
            labelNomeLoja.TabIndex = 49;
            // 
            // labelNomeDpto
            // 
            labelNomeDpto.AutoSize = true;
            labelNomeDpto.Location = new Point(665, 57);
            labelNomeDpto.Name = "labelNomeDpto";
            labelNomeDpto.Size = new Size(0, 15);
            labelNomeDpto.TabIndex = 48;
            // 
            // buttonPesquisa1
            // 
            buttonPesquisa1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa1.Image = (Image)resources.GetObject("buttonPesquisa1.Image");
            buttonPesquisa1.Location = new Point(628, 41);
            buttonPesquisa1.Name = "buttonPesquisa1";
            buttonPesquisa1.Size = new Size(31, 31);
            buttonPesquisa1.TabIndex = 47;
            buttonPesquisa1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa1.UseVisualStyleBackColor = true;
            buttonPesquisa1.Click += button3_Click;
            // 
            // buttonPesquisa2
            // 
            buttonPesquisa2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa2.Image = (Image)resources.GetObject("buttonPesquisa2.Image");
            buttonPesquisa2.Location = new Point(628, 84);
            buttonPesquisa2.Name = "buttonPesquisa2";
            buttonPesquisa2.Size = new Size(31, 31);
            buttonPesquisa2.TabIndex = 46;
            buttonPesquisa2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa2.UseVisualStyleBackColor = true;
            buttonPesquisa2.Click += buttonPesquisa2_Click;
            // 
            // txtLoja
            // 
            txtLoja.Location = new Point(549, 89);
            txtLoja.Name = "txtLoja";
            txtLoja.Size = new Size(73, 23);
            txtLoja.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(511, 97);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 43;
            label15.Text = "Loja:";
            // 
            // txtDpto
            // 
            txtDpto.Location = new Point(549, 45);
            txtDpto.Name = "txtDpto";
            txtDpto.Size = new Size(73, 23);
            txtDpto.TabIndex = 42;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(457, 49);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 41;
            label14.Text = "Departamento:";
            label14.Click += label14_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(171, 358);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(72, 23);
            txtValor.TabIndex = 40;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(171, 330);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(258, 23);
            txtSo.TabIndex = 39;
            // 
            // txtHd
            // 
            txtHd.Location = new Point(171, 301);
            txtHd.Name = "txtHd";
            txtHd.Size = new Size(72, 23);
            txtHd.TabIndex = 38;
            // 
            // txtMemoria
            // 
            txtMemoria.Location = new Point(171, 268);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(258, 23);
            txtMemoria.TabIndex = 37;
            // 
            // txtProcessador
            // 
            txtProcessador.Location = new Point(171, 239);
            txtProcessador.Name = "txtProcessador";
            txtProcessador.Size = new Size(258, 23);
            txtProcessador.TabIndex = 36;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(171, 210);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(258, 23);
            txtModelo.TabIndex = 35;
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(171, 181);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(258, 23);
            txtFabricante.TabIndex = 34;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(171, 154);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(258, 23);
            txtTipo.TabIndex = 33;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(171, 126);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(72, 23);
            txtQtde.TabIndex = 32;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(171, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(258, 23);
            txtNome.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(43, 78);
            label13.Name = "label13";
            label13.Size = new Size(118, 15);
            label13.TabIndex = 30;
            label13.Text = "Usuario Responsavel:";
            label13.TextAlign = ContentAlignment.TopRight;
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 338);
            label12.Name = "label12";
            label12.Size = new Size(118, 15);
            label12.TabIndex = 29;
            label12.Text = "Sistema Operacional:";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 366);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 28;
            label11.Text = "Valor Estimado:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 189);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 27;
            label10.Text = "Fabricante:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(113, 218);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 26;
            label9.Text = "Modelo:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 247);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 25;
            label8.Text = "Processador:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 276);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 24;
            label7.Text = "Memória:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 307);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 23;
            label6.Text = "Quantidade de HD/SSD:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 162);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "Tipo:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 134);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 21;
            label4.Text = "Quantidade:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUsuarioResponsavel
            // 
            txtUsuarioResponsavel.Location = new Point(171, 70);
            txtUsuarioResponsavel.Name = "txtUsuarioResponsavel";
            txtUsuarioResponsavel.Size = new Size(258, 23);
            txtUsuarioResponsavel.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 106);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 20;
            label3.Text = "Nome do Equipamento:";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(171, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 19;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 48);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 18;
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
            toolStrip1.Size = new Size(838, 40);
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
            panel1.Size = new Size(838, 45);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Itens";
            label1.Click += label1_Click;
            // 
            // FItens
            // 
            AcceptButton = BPesquisa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 516);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "FItens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RespoView";
            Load += FItens_Load;
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
        private TextBox txtUsuarioResponsavel;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoNovo;
        private ToolStripButton botaoSalvar;
        private ToolStripButton botaoExcluir;
        private ToolStripButton botaoEditar;
        private ToolStripButton botaoFechar;
        private Panel panel1;
        private Label label1;
        private TextBox txtValor;
        private TextBox txtSo;
        private TextBox txtHd;
        private TextBox txtMemoria;
        private TextBox txtProcessador;
        private TextBox txtModelo;
        private TextBox txtFabricante;
        private TextBox txtTipo;
        private TextBox txtQtde;
        private TextBox txtNome;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtLoja;
        private Label label15;
        private TextBox txtDpto;
        private Label label14;
        private Button BPesquisa;
        private Button buttonPesquisa1;
        private Button buttonPesquisa2;
        private Label labelNomeDpto;
        private Label labelNomeLoja;
    }
}