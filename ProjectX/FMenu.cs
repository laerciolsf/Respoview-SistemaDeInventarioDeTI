using ProjectX.controller;
using ProjectX.model;
using ProjectX.view;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class FMenu : Form
    {
        public static Usuario usuario_logado = new Usuario();

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

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLoja tela = new FLoja();
            tela.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUsuario tela = new FUsuario();
            tela.Show();
        }
    }

}