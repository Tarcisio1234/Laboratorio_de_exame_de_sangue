using Nozama.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nozama
{
    public partial class menuNozama : Form
    {
        public menuNozama()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {// Botão de sair do menu
            Application.Exit();
        }

        private void cadastroDoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {// Tela de cadastro do cliente
            CadastroCliente TelaCadastroCliente = new CadastroCliente();
            TelaCadastroCliente.Show();
            
            TelaCadastroCliente.Left = this.Left;
            TelaCadastroCliente.Top = this.Top;
            

           this.Hide();
        }

        private void marqueSeuExameToolStripMenuItem_Click(object sender, EventArgs e)
        {// Tela para agendar o exame
            Agendamento TelaAgenda = new Agendamento();
            TelaAgenda.Show();
            TelaAgenda.Left = this.Left;
            TelaAgenda.Top = this.Top;
            this.Hide();
        }

        private void loginDoProfissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {// Tela do login do profissional
            Tela_de_login TelaLogin = new Tela_de_login();
            TelaLogin.Show();
            TelaLogin.Left = this.Left;
            TelaLogin.Top = this.Top;
            this.Hide();
        }

        private void agendaDoProfissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {// Agenda do profissional
            gridAgenda nova = new gridAgenda();
            nova.Show();
            nova.Left = this.Left;
            nova.Top = this.Top;
            this.Hide();
        }

        private void testarAConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {// Tela para testar a conexão
            TestarConexao TelaConexao = new TestarConexao();
            TelaConexao.Show();
            this.Hide();
        }

        private void buscarDadosDoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente TelaBuscarClientes = new BuscarCliente();
            TelaBuscarClientes.Show();
            TelaBuscarClientes.Left = this.Left;
            TelaBuscarClientes.Top = this.Top;
            this.Hide();
        }

        private void menuDaGerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_de_login nova = new Tela_de_login();
            nova.Show();
            nova.Left = this.Left;
            nova.Top = this.Top;
            this.Hide();
        }

        private void cliqueAquiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Como_usar novo = new Como_usar();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TestarConexao novo = new TestarConexao();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Hide();
        }

        private void menuNozama_Load(object sender, EventArgs e) //Não utilizar
        {
            
        }

        private void buscarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente TelaBuscarClientes = new BuscarCliente();
            TelaBuscarClientes.Show();
            TelaBuscarClientes.Left = this.Left;
            TelaBuscarClientes.Top = this.Top;
            this.Hide();
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarCliente nova = new EditarCliente();
            nova.Show();
            nova.Left = this.Left;
            nova.Top = this.Top;
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
