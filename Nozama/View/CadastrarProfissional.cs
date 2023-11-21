using Nozama.Class;
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
    public partial class CadastrarProfissional : Form
    {
        public CadastrarProfissional()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Gerencia novo = new Gerencia();
            novo.Show();
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Profissional novo= new Profissional();
            novo.Nome = txt_Nome.Text;
            novo.Cpf = txt_Cpf.Text;
            novo.Endereco = txt_Endereco.Text;
            novo.Celular = txt_Telefone.Text;
            novo.Datanascimento = DateTime.Parse(dateNaci.Text);
            novo.Profissao = cmbProfissao.Text;
            novo.Sexo = cmbSexo.Text;
            novo.Salvar();
        }
    }
}
