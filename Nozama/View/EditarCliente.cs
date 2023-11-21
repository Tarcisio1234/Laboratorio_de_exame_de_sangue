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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome, endereco, celular, email, cpf, whatsapp, obs, deficiencia, sexo;



            int idpaciente = int.Parse(txtID.Text);
            nome = txtNome.Text;
            endereco = txtEndereco.Text;
            celular = txtCelular.Text;
            email = txtEmail.Text;
            DateTime dataNaci = DateTime.Parse(dtpNascimento.Text);
            whatsapp = cmbWhatsapp.Text;
            obs = txtObservacoes.Text;
            cpf = txt_Cpf.Text;
            sexo = cmbSexo.Text;
            deficiencia = cmbDeficiencia.Text;



            Paciente alteracao = new Paciente();
            {
                alteracao.Idpaciente = idpaciente;
                alteracao.Nome = nome;
                alteracao.Endereco = endereco;
                alteracao.Celular = celular;
                alteracao.Email = email;
                alteracao.Datanascimento = dataNaci;
                alteracao.Whatsapp = whatsapp;
                alteracao.Obs = obs;
                alteracao.Cpf = cpf;
                alteracao.Sexo = sexo;
                alteracao.Deficiencia = deficiencia;



            }
            alteracao.Editar_Cliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Cpf = txt_Cpf.Text;
            if (!string.IsNullOrEmpty(Cpf))
            {
                List<Paciente> pacientes = new Paciente().BuscarPaciente(Cpf);

                if (pacientes.Count > 0)
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
                    dtpNascimento.Enabled = true;
                    txtCelular.Enabled = true;
                    cmbWhatsapp.Enabled = true;
                    txtEndereco.Enabled = true;
                    txtEmail.Enabled = true;
                    cmbDeficiencia.Enabled = true;
                    txtObservacoes.Enabled = true;
                    cmbSexo.Enabled = true;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            menuNozama novo = new menuNozama();
            novo.Show();
            this.Close();
        }
    }
}

