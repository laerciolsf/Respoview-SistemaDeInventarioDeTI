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
            //Chama a tela de login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usuario_logado == null)
            {
                Application.Exit();
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FRelatorio tela = new FRelatorio();
            tela.Show();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itensRemovidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}