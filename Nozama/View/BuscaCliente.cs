using MySqlX.XDevAPI;
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

namespace Nozama
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuNozama MenuInicial = new menuNozama();
            MenuInicial.Show();
            MenuInicial.Left = this.Left;
            MenuInicial.Top = this.Top;
            this.Close();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            dtpNascimento.Enabled = false;
            txtCelular.Enabled = false;
            cmbWhatsapp.Enabled = false;
            txtEndereco.Enabled = false;
            txtEmail.Enabled = false;
            cmbDeficiencia.Enabled = false;
            txtObservacoes.Enabled = false;
            cmbSexo.Enabled = false;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Cpf = txt_Cpf.Text;
            if (!string.IsNullOrEmpty(Cpf))
            {
                List<Paciente> pacientes = new Paciente().BuscarPaciente(Cpf);
               
                if (pacientes.Count >0 )
                {
                    Paciente resultado = pacientes[0];
                    txtNome.Text = resultado.Nome;
                    
                    txtEmail.Text = resultado.Email;
                    txtCelular.Text = resultado.Celular;                    
                    txtEndereco.Text = resultado.Endereco;
                    txtObservacoes.Text = resultado.Obs;
                    cmbWhatsapp.Text = resultado.Whatsapp;
                    cmbSexo.Text = resultado.Sexo;
                    cmbDeficiencia.Text = resultado.Deficiencia;
                    txtID.Text = resultado.Idpaciente.ToString();
                    dtpNascimento.Text = resultado.Datanascimento.ToString();

                    txtNome.Enabled = true;
                    dtpNascimento.Enabled = false;
                    txtCelular.Enabled = true;
                    cmbWhatsapp.Enabled = false;
                    txtEndereco.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbDeficiencia.Enabled = false;
                    txtObservacoes.Enabled = false;
                    cmbSexo.Enabled = false;
                }
                else
                {
                MessageBox.Show("O CPF não foi encontrado ou não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Cpf.Clear();
                    txt_Cpf.Focus();
                }
            }
            else
            {
                MessageBox.Show("O campo cpf está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Cpf_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Cpf.SelectionStart = 0;
        }
    }
}
