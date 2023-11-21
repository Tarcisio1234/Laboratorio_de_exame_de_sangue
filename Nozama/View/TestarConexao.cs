using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nozama.Controller.Conexao;

namespace Nozama.View
{
    public partial class TestarConexao : Form
    {
        public TestarConexao()
        {
            InitializeComponent();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            MySqlConnectionManager connectionManager = new MySqlConnectionManager();

            if (connectionManager.OpenConnection())
            {
                MessageBox.Show("O teste foi feito com sucesso!!!");
                connectionManager.CloseConnection();
            }
            else
            {
                MessageBox.Show("O teste de conexão falhou :(");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Como_usar telaMenu = new Como_usar();
            telaMenu.Show();
            this.Close();
        }
    }
}
