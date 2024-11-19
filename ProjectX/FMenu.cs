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
            else if (usuario_logado.nivelAcesso != 1)
            {
                MessageBox.Show($"Usuário logado: {usuario_logado.nome}, Nível de Acesso: {usuario_logado.nivelAcesso}");
                // Oculta menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = false;
                }
              
            }
            else if (usuario_logado.nivelAcesso == 1)
            {
                MessageBox.Show($"Usuário logado: {usuario_logado.nome}, Nível de Acesso: {usuario_logado.nivelAcesso}");
                // Exibe menus administrativos para gerenciar usuarios
                if (usuariosToolStripMenuItem != null)
                {
                    usuariosToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FItens tela = new FItens();
            tela.ShowDialog();
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
            tela.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FLoja tela = new FLoja();
            tela.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itensRemovidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FhistoricoItensExcluidos tela = new FhistoricoItensExcluidos();
            tela.ShowDialog();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRelatorio tela = new FRelatorio();
            tela.ShowDialog();
        }

        private void bitlokerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBitlocker tela = new FBitlocker();
            tela.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FUsuario tela = new FUsuario();
            tela.ShowDialog();
        }

        private void itensAlteradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FhistoricoItensAlterados tela = new FhistoricoItensAlterados();
            tela.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aba usuarios
        }
    }

}