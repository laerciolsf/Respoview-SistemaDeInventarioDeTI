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
            panel5 = new Panel();
            label18 = new Label();
            txtidBitLocker = new TextBox();
            label17 = new Label();
            txtchaveBitLocker = new TextBox();
            label16 = new Label();
            panel3 = new Panel();
            txtLoja = new TextBox();
            label14 = new Label();
            txtDpto = new TextBox();
            label15 = new Label();
            buttonPesquisa2 = new Button();
            labelNomeLoja = new Label();
            buttonPesquisa1 = new Button();
            labelNomeDpto = new Label();
            panel4 = new Panel();
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
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            tabControl1.Size = new Size(996, 451);
            tabControl1.TabIndex = 8;
            // 
            // tabPesquisa
            // 
            tabPesquisa.Controls.Add(dataGridView1);
            tabPesquisa.Controls.Add(panel2);
            tabPesquisa.Location = new Point(4, 24);
            tabPesquisa.Name = "tabPesquisa";
            tabPesquisa.Padding = new Padding(3);
            tabPesquisa.Size = new Size(988, 423);
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
            dataGridView1.Size = new Size(982, 351);
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
            panel2.Size = new Size(982, 66);
            panel2.TabIndex = 0;
            // 
            // BPesquisa
            // 
            BPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPesquisa.Image = (Image)resources.GetObject("BPesquisa.Image");
            BPesquisa.Location = new Point(873, 13);
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
            botaoPesquisar.Location = new Point(1666, 12);
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
            textBox1.Size = new Size(849, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(panel5);
            tabDados.Controls.Add(panel3);
            tabDados.Controls.Add(panel4);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(988, 423);
            tabDados.TabIndex = 1;
            tabDados.Text = "Dados Gerais";
            tabDados.UseVisualStyleBackColor = true;
            tabDados.Click += tabDados_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(label18);
            panel5.Controls.Add(txtidBitLocker);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(txtchaveBitLocker);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(469, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(501, 151);
            panel5.TabIndex = 57;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(53, 19);
            label18.Name = "label18";
            label18.Size = new Size(369, 15);
            label18.TabIndex = 96;
            label18.Text = "Chave de recuperação de Criptografia de Unidade de Disco BitLocker";
            // 
            // txtidBitLocker
            // 
            txtidBitLocker.Location = new Point(98, 53);
            txtidBitLocker.Name = "txtidBitLocker";
            txtidBitLocker.Size = new Size(297, 23);
            txtidBitLocker.TabIndex = 92;
            txtidBitLocker.TextChanged += txtidBitLocker_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(53, 85);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 95;
            label17.Text = "Chave";
            // 
            // txtchaveBitLocker
            // 
            txtchaveBitLocker.Location = new Point(98, 82);
            txtchaveBitLocker.Name = "txtchaveBitLocker";
            txtchaveBitLocker.Size = new Size(367, 23);
            txtchaveBitLocker.TabIndex = 93;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 66);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 94;
            label16.Text = "Identificador";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(txtLoja);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtDpto);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(buttonPesquisa2);
            panel3.Controls.Add(labelNomeLoja);
            panel3.Controls.Add(buttonPesquisa1);
            panel3.Controls.Add(labelNomeDpto);
            panel3.Location = new Point(456, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 225);
            panel3.TabIndex = 56;
            // 
            // txtLoja
            // 
            txtLoja.Location = new Point(137, 52);
            txtLoja.Name = "txtLoja";
            txtLoja.Size = new Size(76, 23);
            txtLoja.TabIndex = 95;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(45, 20);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 92;
            label14.Text = "Departamento:";
            // 
            // txtDpto
            // 
            txtDpto.Location = new Point(137, 16);
            txtDpto.Name = "txtDpto";
            txtDpto.Size = new Size(76, 23);
            txtDpto.TabIndex = 93;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(99, 60);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 94;
            label15.Text = "Loja:";
            // 
            // buttonPesquisa2
            // 
            buttonPesquisa2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa2.Image = (Image)resources.GetObject("buttonPesquisa2.Image");
            buttonPesquisa2.Location = new Point(219, 47);
            buttonPesquisa2.Name = "buttonPesquisa2";
            buttonPesquisa2.Size = new Size(31, 31);
            buttonPesquisa2.TabIndex = 96;
            buttonPesquisa2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa2.UseVisualStyleBackColor = true;
            buttonPesquisa2.Click += buttonPesquisa2_Click_2;
            // 
            // labelNomeLoja
            // 
            labelNomeLoja.AutoSize = true;
            labelNomeLoja.Location = new Point(256, 60);
            labelNomeLoja.Name = "labelNomeLoja";
            labelNomeLoja.Size = new Size(0, 15);
            labelNomeLoja.TabIndex = 99;
            // 
            // buttonPesquisa1
            // 
            buttonPesquisa1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa1.Image = (Image)resources.GetObject("buttonPesquisa1.Image");
            buttonPesquisa1.Location = new Point(219, 12);
            buttonPesquisa1.Name = "buttonPesquisa1";
            buttonPesquisa1.Size = new Size(31, 31);
            buttonPesquisa1.TabIndex = 97;
            buttonPesquisa1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa1.UseVisualStyleBackColor = true;
            buttonPesquisa1.Click += buttonPesquisa1_Click;
            // 
            // labelNomeDpto
            // 
            labelNomeDpto.AutoSize = true;
            labelNomeDpto.Location = new Point(256, 25);
            labelNomeDpto.Name = "labelNomeDpto";
            labelNomeDpto.Size = new Size(0, 15);
            labelNomeDpto.TabIndex = 98;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(txtValor);
            panel4.Controls.Add(txtSo);
            panel4.Controls.Add(txtHd);
            panel4.Controls.Add(txtMemoria);
            panel4.Controls.Add(txtProcessador);
            panel4.Controls.Add(txtModelo);
            panel4.Controls.Add(txtFabricante);
            panel4.Controls.Add(txtTipo);
            panel4.Controls.Add(txtQtde);
            panel4.Controls.Add(txtNome);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtUsuarioResponsavel);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(19, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 382);
            panel4.TabIndex = 55;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(153, 335);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(72, 23);
            txtValor.TabIndex = 64;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(153, 307);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(258, 23);
            txtSo.TabIndex = 63;
            // 
            // txtHd
            // 
            txtHd.Location = new Point(153, 278);
            txtHd.Name = "txtHd";
            txtHd.Size = new Size(72, 23);
            txtHd.TabIndex = 62;
            // 
            // txtMemoria
            // 
            txtMemoria.Location = new Point(153, 245);
            txtMemoria.Name = "txtMemoria";
            txtMemoria.Size = new Size(258, 23);
            txtMemoria.TabIndex = 61;
            // 
            // txtProcessador
            // 
            txtProcessador.Location = new Point(153, 216);
            txtProcessador.Name = "txtProcessador";
            txtProcessador.Size = new Size(258, 23);
            txtProcessador.TabIndex = 60;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(153, 187);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(258, 23);
            txtModelo.TabIndex = 59;
            // 
            // txtFabricante
            // 
            txtFabricante.Location = new Point(153, 158);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(258, 23);
            txtFabricante.TabIndex = 58;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(153, 131);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(258, 23);
            txtTipo.TabIndex = 57;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(153, 103);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(72, 23);
            txtQtde.TabIndex = 56;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(153, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(258, 23);
            txtNome.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 55);
            label13.Name = "label13";
            label13.Size = new Size(118, 15);
            label13.TabIndex = 54;
            label13.Text = "Usuario Responsavel:";
            label13.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 315);
            label12.Name = "label12";
            label12.Size = new Size(118, 15);
            label12.TabIndex = 53;
            label12.Text = "Sistema Operacional:";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(58, 343);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 52;
            label11.Text = "Valor Estimado:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 166);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 51;
            label10.Text = "Fabricante:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 195);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 50;
            label9.Text = "Modelo:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 224);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 49;
            label8.Text = "Processador:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 253);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 48;
            label7.Text = "Memória:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 284);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 47;
            label6.Text = "Quantidade de HD/SSD:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 139);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 46;
            label5.Text = "Tipo:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 111);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 45;
            label4.Text = "Quantidade:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUsuarioResponsavel
            // 
            txtUsuarioResponsavel.Location = new Point(153, 47);
            txtUsuarioResponsavel.Name = "txtUsuarioResponsavel";
            txtUsuarioResponsavel.Size = new Size(258, 23);
            txtUsuarioResponsavel.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 83);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 43;
            label3.Text = "Nome do Equipamento:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 17);
            txtId.Name = "txtId";
            txtId.Size = new Size(72, 23);
            txtId.TabIndex = 42;
            txtId.TextChanged += txtId_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 25);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 41;
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
            toolStrip1.Size = new Size(996, 40);
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
            panel1.Size = new Size(996, 45);
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
            ClientSize = new Size(996, 536);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton botaoNovo;
        private ToolStripButton botaoSalvar;
        private ToolStripButton botaoExcluir;
        private ToolStripButton botaoEditar;
        private ToolStripButton botaoFechar;
        private Panel panel1;
        private Label label1;
        private Button BPesquisa;
        private Panel panel5;
        private Label label18;
        private TextBox txtidBitLocker;
        private Label label17;
        private TextBox txtchaveBitLocker;
        private Label label16;
        private Panel panel3;
        private TextBox txtLoja;
        private Label label14;
        private TextBox txtDpto;
        private Label label15;
        private Button buttonPesquisa2;
        private Label labelNomeLoja;
        private Button buttonPesquisa1;
        private Label labelNomeDpto;
        private Panel panel4;
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
        private TextBox txtUsuarioResponsavel;
        private Label label3;
        private TextBox txtId;
        private Label label2;
    }
}