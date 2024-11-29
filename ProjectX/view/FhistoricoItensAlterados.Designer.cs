namespace ProjectX.view
{
    partial class FhistoricoItensAlterados
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
            buttonAtualizar = new Button();
            label1 = new Label();
            dataGridItensRemovidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridItensRemovidos).BeginInit();
            SuspendLayout();
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(690, 12);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(98, 33);
            buttonAtualizar.TabIndex = 61;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += buttonAtualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 60;
            label1.Text = "Historico de Itens Alterados";
            // 
            // dataGridItensRemovidos
            // 
            dataGridItensRemovidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItensRemovidos.Location = new Point(12, 53);
            dataGridItensRemovidos.Name = "dataGridItensRemovidos";
            dataGridItensRemovidos.RowTemplate.Height = 25;
            dataGridItensRemovidos.Size = new Size(776, 385);
            dataGridItensRemovidos.TabIndex = 59;
            // 
            // FhistoricoItensAlterados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAtualizar);
            Controls.Add(label1);
            Controls.Add(dataGridItensRemovidos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FhistoricoItensAlterados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FhistoricoItensAlterados";
            ((System.ComponentModel.ISupportInitialize)dataGridItensRemovidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAtualizar;
        private Label label1;
        private DataGridView dataGridItensRemovidos;
    }
}