using ProjectX.controller;
using ProjectX.view;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FItens tela = new FItens();
            tela.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDpto tela = new FDpto();
            tela.Show();
        }
    }

}