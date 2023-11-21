using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nozama.View
{
    public partial class Como_usar : Form
    {
        public Como_usar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuNozama novo = new menuNozama();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            txtSuporte.Clear();

            MessageBox.Show("A sua mensagem foi enviada com sucesso!", "Enviado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestarConexao novo = new TestarConexao();
            novo.Show();
            this.Hide();
        }

        private void Como_usar_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
