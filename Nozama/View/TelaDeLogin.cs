using Nozama.View;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class Tela_de_login : Form
    {
        public Tela_de_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuNozama novo = new menuNozama();
            novo.Show();
            this.Close();
        }

        

        

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /*button1.Focus();
                button1.PerformClick();*/
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCpf.Text == "99999999999" && txtSenha.Text == "9")
            {
                Gerencia novo = new Gerencia();
                novo.Show();
                novo.Left = this.Left;
                novo.Top = this.Top;
                this.Hide();
            }
        }

        private void Tela_de_login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            menuNozama novo = new menuNozama();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtCpf.Text == "99999999999" && txtSenha.Text == "9")
            {
                Gerencia novo = new Gerencia();
                novo.Show();
                novo.Left = this.Left;
                novo.Top = this.Top;
                this.Hide();
            }

            else
            {
                MessageBox.Show("Login ou senha incorretos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            txtCpf.SelectionStart = 0;
        }
    }
}
