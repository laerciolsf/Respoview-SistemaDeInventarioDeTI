namespace ProjectX.view
{
    partial class FBitlocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBitlocker));
            panel1 = new Panel();
            label18 = new Label();
            BPesquisa = new Button();
            txtidBitLocker = new TextBox();
            label17 = new Label();
            txtchaveBitLocker = new TextBox();
            label16 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label18);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 51);
            panel1.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(32, 18);
            label18.Name = "label18";
            label18.Size = new Size(423, 17);
            label18.TabIndex = 97;
            label18.Text = "Chave de recuperação de Criptografia de Unidade de Disco BitLocker";
            // 
            // BPesquisa
            // 
            BPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BPesquisa.BackColor = Color.White;
            BPesquisa.Image = (Image)resources.GetObject("BPesquisa.Image");
            BPesquisa.Location = new Point(376, 154);
            BPesquisa.Name = "BPesquisa";
            BPesquisa.Size = new Size(104, 36);
            BPesquisa.TabIndex = 101;
            BPesquisa.Text = "Pesquisar";
            BPesquisa.TextImageRelation = TextImageRelation.ImageBeforeText;
            BPesquisa.UseVisualStyleBackColor = false;
            BPesquisa.Click += BPesquisa_Click;
            // 
            // txtidBitLocker
            // 
            txtidBitLocker.Location = new Point(113, 83);
            txtidBitLocker.Name = "txtidBitLocker";
            txtidBitLocker.Size = new Size(297, 23);
            txtidBitLocker.TabIndex = 97;
            txtidBitLocker.TextChanged += txtidBitLocker_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(68, 115);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 100;
            label17.Text = "Chave";
            // 
            // txtchaveBitLocker
            // 
            txtchaveBitLocker.Location = new Point(113, 112);
            txtchaveBitLocker.Name = "txtchaveBitLocker";
            txtchaveBitLocker.Size = new Size(367, 23);
            txtchaveBitLocker.TabIndex = 98;
            txtchaveBitLocker.TextChanged += txtchaveBitLocker_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 96);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 99;
            label16.Text = "Identificador";
            // 
            // FBitlocker
            // 
            AcceptButton = BPesquisa;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 214);
            Controls.Add(BPesquisa);
            Controls.Add(txtidBitLocker);
            Controls.Add(label17);
            Controls.Add(txtchaveBitLocker);
            Controls.Add(label16);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FBitlocker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FBitlocker";
            Load += FBitlocker_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label18;
        private Button BPesquisa;
        private TextBox txtidBitLocker;
        private Label label17;
        private TextBox txtchaveBitLocker;
        private Label label16;
    }
}