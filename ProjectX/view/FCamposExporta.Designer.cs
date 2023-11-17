namespace ProjectX.view
{
    partial class FCamposExporta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCamposExporta));
            BComfirmar = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            labelNomeDpto = new Label();
            buttonPesquisa1 = new Button();
            labelNomeLoja = new Label();
            buttonPesquisa2 = new Button();
            txtLoja = new TextBox();
            label15 = new Label();
            txtDpto = new TextBox();
            label14 = new Label();
            buttonCsv = new Button();
            checkBoxIdDepartamento = new CheckBox();
            checkBoxIdLoja = new CheckBox();
            checkBoxModelo = new CheckBox();
            checkBoxProcessador = new CheckBox();
            checkBoxMemoria = new CheckBox();
            checkBoxHdSsd = new CheckBox();
            checkBoxSistemOperacional = new CheckBox();
            checkBoxValorEstimado = new CheckBox();
            checkBoxFabricante = new CheckBox();
            checkBoxTipo = new CheckBox();
            checkBoxQuantidade = new CheckBox();
            checkBoxNomeEquipamento = new CheckBox();
            checkBoxUserRes = new CheckBox();
            checkBoxId = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BComfirmar
            // 
            BComfirmar.Location = new Point(609, 479);
            BComfirmar.Name = "BComfirmar";
            BComfirmar.Size = new Size(105, 33);
            BComfirmar.TabIndex = 15;
            BComfirmar.Text = "Exportar em PDF";
            BComfirmar.UseVisualStyleBackColor = true;
            BComfirmar.Click += BComfirmar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 479);
            button3.Name = "button3";
            button3.Size = new Size(98, 33);
            button3.TabIndex = 16;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 45);
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
            label1.Size = new Size(245, 24);
            label1.TabIndex = 0;
            label1.Text = "Exportação de Relatórios";
            // 
            // labelNomeDpto
            // 
            labelNomeDpto.AutoSize = true;
            labelNomeDpto.Location = new Point(573, 73);
            labelNomeDpto.Name = "labelNomeDpto";
            labelNomeDpto.Size = new Size(0, 15);
            labelNomeDpto.TabIndex = 67;
            // 
            // buttonPesquisa1
            // 
            buttonPesquisa1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa1.Image = (Image)resources.GetObject("buttonPesquisa1.Image");
            buttonPesquisa1.Location = new Point(536, 65);
            buttonPesquisa1.Name = "buttonPesquisa1";
            buttonPesquisa1.Size = new Size(31, 31);
            buttonPesquisa1.TabIndex = 65;
            buttonPesquisa1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa1.UseVisualStyleBackColor = true;
            buttonPesquisa1.Click += buttonPesquisa1_Click;
            // 
            // labelNomeLoja
            // 
            labelNomeLoja.AutoSize = true;
            labelNomeLoja.Location = new Point(170, 73);
            labelNomeLoja.Name = "labelNomeLoja";
            labelNomeLoja.Size = new Size(0, 15);
            labelNomeLoja.TabIndex = 66;
            // 
            // buttonPesquisa2
            // 
            buttonPesquisa2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPesquisa2.Image = (Image)resources.GetObject("buttonPesquisa2.Image");
            buttonPesquisa2.Location = new Point(133, 65);
            buttonPesquisa2.Name = "buttonPesquisa2";
            buttonPesquisa2.Size = new Size(31, 31);
            buttonPesquisa2.TabIndex = 64;
            buttonPesquisa2.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPesquisa2.UseVisualStyleBackColor = true;
            buttonPesquisa2.Click += buttonPesquisa2_Click;
            // 
            // txtLoja
            // 
            txtLoja.Location = new Point(58, 70);
            txtLoja.Name = "txtLoja";
            txtLoja.Size = new Size(67, 23);
            txtLoja.TabIndex = 63;
            txtLoja.TextChanged += txtLoja_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 73);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 62;
            label15.Text = "Loja:";
            // 
            // txtDpto
            // 
            txtDpto.Location = new Point(462, 70);
            txtDpto.Name = "txtDpto";
            txtDpto.Size = new Size(68, 23);
            txtDpto.TabIndex = 61;
            txtDpto.TextChanged += txtDpto_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(370, 73);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 60;
            label14.Text = "Departamento:";
            // 
            // buttonCsv
            // 
            buttonCsv.Location = new Point(499, 479);
            buttonCsv.Name = "buttonCsv";
            buttonCsv.Size = new Size(104, 33);
            buttonCsv.TabIndex = 68;
            buttonCsv.Text = "Exportar em CSV";
            buttonCsv.UseVisualStyleBackColor = true;
            buttonCsv.Click += buttonCsv_Click;
            // 
            // checkBoxIdDepartamento
            // 
            checkBoxIdDepartamento.AutoSize = true;
            checkBoxIdDepartamento.Location = new Point(20, 441);
            checkBoxIdDepartamento.Name = "checkBoxIdDepartamento";
            checkBoxIdDepartamento.Size = new Size(115, 19);
            checkBoxIdDepartamento.TabIndex = 82;
            checkBoxIdDepartamento.Text = "Id Departamento";
            checkBoxIdDepartamento.UseVisualStyleBackColor = true;
            checkBoxIdDepartamento.CheckedChanged += checkBoxIdDepartamento_CheckedChanged;
            // 
            // checkBoxIdLoja
            // 
            checkBoxIdLoja.AutoSize = true;
            checkBoxIdLoja.Location = new Point(20, 416);
            checkBoxIdLoja.Name = "checkBoxIdLoja";
            checkBoxIdLoja.Size = new Size(61, 19);
            checkBoxIdLoja.TabIndex = 81;
            checkBoxIdLoja.Text = "Id Loja";
            checkBoxIdLoja.UseVisualStyleBackColor = true;
            checkBoxIdLoja.CheckedChanged += checkBoxIdLoja_CheckedChanged;
            // 
            // checkBoxModelo
            // 
            checkBoxModelo.AutoSize = true;
            checkBoxModelo.Location = new Point(20, 266);
            checkBoxModelo.Name = "checkBoxModelo";
            checkBoxModelo.Size = new Size(67, 19);
            checkBoxModelo.TabIndex = 80;
            checkBoxModelo.Text = "Modelo";
            checkBoxModelo.UseVisualStyleBackColor = true;
            checkBoxModelo.CheckedChanged += checkBoxModelo_CheckedChanged;
            // 
            // checkBoxProcessador
            // 
            checkBoxProcessador.AutoSize = true;
            checkBoxProcessador.Location = new Point(20, 291);
            checkBoxProcessador.Name = "checkBoxProcessador";
            checkBoxProcessador.Size = new Size(90, 19);
            checkBoxProcessador.TabIndex = 79;
            checkBoxProcessador.Text = "Processador";
            checkBoxProcessador.UseVisualStyleBackColor = true;
            checkBoxProcessador.CheckedChanged += checkBoxProcessador_CheckedChanged;
            // 
            // checkBoxMemoria
            // 
            checkBoxMemoria.AutoSize = true;
            checkBoxMemoria.Location = new Point(20, 316);
            checkBoxMemoria.Name = "checkBoxMemoria";
            checkBoxMemoria.Size = new Size(74, 19);
            checkBoxMemoria.TabIndex = 78;
            checkBoxMemoria.Text = "Memória";
            checkBoxMemoria.UseVisualStyleBackColor = true;
            checkBoxMemoria.CheckedChanged += checkBoxMemoria_CheckedChanged;
            // 
            // checkBoxHdSsd
            // 
            checkBoxHdSsd.AutoSize = true;
            checkBoxHdSsd.Location = new Point(20, 341);
            checkBoxHdSsd.Name = "checkBoxHdSsd";
            checkBoxHdSsd.Size = new Size(114, 19);
            checkBoxHdSsd.TabIndex = 77;
            checkBoxHdSsd.Text = "Armazenamento";
            checkBoxHdSsd.UseVisualStyleBackColor = true;
            checkBoxHdSsd.CheckedChanged += checkBoxHdSsd_CheckedChanged;
            // 
            // checkBoxSistemOperacional
            // 
            checkBoxSistemOperacional.AutoSize = true;
            checkBoxSistemOperacional.Location = new Point(20, 366);
            checkBoxSistemOperacional.Name = "checkBoxSistemOperacional";
            checkBoxSistemOperacional.Size = new Size(134, 19);
            checkBoxSistemOperacional.TabIndex = 76;
            checkBoxSistemOperacional.Text = "Sistema Operacional";
            checkBoxSistemOperacional.UseVisualStyleBackColor = true;
            checkBoxSistemOperacional.CheckedChanged += checkBoxSistemOperacional_CheckedChanged;
            // 
            // checkBoxValorEstimado
            // 
            checkBoxValorEstimado.AutoSize = true;
            checkBoxValorEstimado.Location = new Point(20, 391);
            checkBoxValorEstimado.Name = "checkBoxValorEstimado";
            checkBoxValorEstimado.Size = new Size(104, 19);
            checkBoxValorEstimado.TabIndex = 75;
            checkBoxValorEstimado.Text = "Valor Estimado";
            checkBoxValorEstimado.UseVisualStyleBackColor = true;
            checkBoxValorEstimado.CheckedChanged += checkBoxValorEstimado_CheckedChanged;
            // 
            // checkBoxFabricante
            // 
            checkBoxFabricante.AutoSize = true;
            checkBoxFabricante.Location = new Point(20, 241);
            checkBoxFabricante.Name = "checkBoxFabricante";
            checkBoxFabricante.Size = new Size(81, 19);
            checkBoxFabricante.TabIndex = 74;
            checkBoxFabricante.Text = "Fabricante";
            checkBoxFabricante.UseVisualStyleBackColor = true;
            checkBoxFabricante.CheckedChanged += checkBoxFabricante_CheckedChanged;
            // 
            // checkBoxTipo
            // 
            checkBoxTipo.AutoSize = true;
            checkBoxTipo.Location = new Point(20, 216);
            checkBoxTipo.Name = "checkBoxTipo";
            checkBoxTipo.Size = new Size(49, 19);
            checkBoxTipo.TabIndex = 73;
            checkBoxTipo.Text = "Tipo";
            checkBoxTipo.UseVisualStyleBackColor = true;
            checkBoxTipo.CheckedChanged += checkBoxTipo_CheckedChanged;
            // 
            // checkBoxQuantidade
            // 
            checkBoxQuantidade.AutoSize = true;
            checkBoxQuantidade.Location = new Point(20, 191);
            checkBoxQuantidade.Name = "checkBoxQuantidade";
            checkBoxQuantidade.Size = new Size(88, 19);
            checkBoxQuantidade.TabIndex = 72;
            checkBoxQuantidade.Text = "Quantidade";
            checkBoxQuantidade.UseVisualStyleBackColor = true;
            checkBoxQuantidade.CheckedChanged += checkBoxQuantidade_CheckedChanged;
            // 
            // checkBoxNomeEquipamento
            // 
            checkBoxNomeEquipamento.AutoSize = true;
            checkBoxNomeEquipamento.Location = new Point(20, 166);
            checkBoxNomeEquipamento.Name = "checkBoxNomeEquipamento";
            checkBoxNomeEquipamento.Size = new Size(150, 19);
            checkBoxNomeEquipamento.TabIndex = 71;
            checkBoxNomeEquipamento.Text = "Nome do Equipamento";
            checkBoxNomeEquipamento.UseVisualStyleBackColor = true;
            checkBoxNomeEquipamento.CheckedChanged += checkBoxNomeEquipamento_CheckedChanged;
            // 
            // checkBoxUserRes
            // 
            checkBoxUserRes.AutoSize = true;
            checkBoxUserRes.Location = new Point(20, 141);
            checkBoxUserRes.Name = "checkBoxUserRes";
            checkBoxUserRes.Size = new Size(134, 19);
            checkBoxUserRes.TabIndex = 70;
            checkBoxUserRes.Text = "Usuario Responsavel";
            checkBoxUserRes.UseVisualStyleBackColor = true;
            checkBoxUserRes.CheckedChanged += checkBoxUserRes_CheckedChanged;
            // 
            // checkBoxId
            // 
            checkBoxId.AutoSize = true;
            checkBoxId.Location = new Point(20, 116);
            checkBoxId.Name = "checkBoxId";
            checkBoxId.Size = new Size(36, 19);
            checkBoxId.TabIndex = 69;
            checkBoxId.Text = "Id";
            checkBoxId.UseVisualStyleBackColor = true;
            checkBoxId.CheckedChanged += checkBoxId_CheckedChanged;
            // 
            // FCamposExporta
            // 
            AcceptButton = BComfirmar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 524);
            Controls.Add(checkBoxIdDepartamento);
            Controls.Add(checkBoxIdLoja);
            Controls.Add(checkBoxModelo);
            Controls.Add(checkBoxProcessador);
            Controls.Add(checkBoxMemoria);
            Controls.Add(checkBoxHdSsd);
            Controls.Add(checkBoxSistemOperacional);
            Controls.Add(checkBoxValorEstimado);
            Controls.Add(checkBoxFabricante);
            Controls.Add(checkBoxTipo);
            Controls.Add(checkBoxQuantidade);
            Controls.Add(checkBoxNomeEquipamento);
            Controls.Add(checkBoxUserRes);
            Controls.Add(checkBoxId);
            Controls.Add(buttonCsv);
            Controls.Add(labelNomeDpto);
            Controls.Add(buttonPesquisa1);
            Controls.Add(labelNomeLoja);
            Controls.Add(buttonPesquisa2);
            Controls.Add(txtLoja);
            Controls.Add(label15);
            Controls.Add(txtDpto);
            Controls.Add(label14);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(BComfirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FCamposExporta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RespoView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BComfirmar;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private Label labelNomeDpto;
        private Button buttonPesquisa1;
        private Label labelNomeLoja;
        private Button buttonPesquisa2;
        private TextBox txtLoja;
        private Label label15;
        private TextBox txtDpto;
        private Label label14;
        private Button buttonCsv;
        private CheckBox checkBoxIdDepartamento;
        private CheckBox checkBoxIdLoja;
        private CheckBox checkBoxModelo;
        private CheckBox checkBoxProcessador;
        private CheckBox checkBoxMemoria;
        private CheckBox checkBoxHdSsd;
        private CheckBox checkBoxSistemOperacional;
        private CheckBox checkBoxValorEstimado;
        private CheckBox checkBoxFabricante;
        private CheckBox checkBoxTipo;
        private CheckBox checkBoxQuantidade;
        private CheckBox checkBoxNomeEquipamento;
        private CheckBox checkBoxUserRes;
        private CheckBox checkBoxId;
    }
}