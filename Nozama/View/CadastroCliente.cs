using Nozama.Class;
using System;
using System.Collections;
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
    public partial class CadastroCliente : Form
    {


        private bool ValidarFormulario()
        {
            bool validar;
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome do cliente", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                validar = false;
            }
            else if (txtCPF.Text.Length == 0 || txtCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF do cliente incompleto", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCPF.Focus();
                validar = false;
            }
            else if (txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Informe o endereço do cliente", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                validar = false;
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Informe o email do cliente", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                validar = false;
            }
            else if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Insira um email válido", "Erro de informação.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                validar = false;
            }
            else if (cmbSexo.Text.Length == 0)
            {
                MessageBox.Show("Informe o sexo do cliente", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSexo.Focus();
                validar = false;
            }
            else if (cmbWhatsapp.Text.Length == 0)
            {
                MessageBox.Show("O cliente possui Whatsapp ?", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cmbWhatsapp.Focus();
                validar = false;
            }
            else if (cmbDeficiencia.Text.Length == 0)
            {
                MessageBox.Show("Informe se o cliente possui algum tipo de deficiência", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDeficiencia.Focus();
                validar = false;
            }
            else if (txtCelular.Text.Length == 0 || txtCelular.Text.Length < 11)
            {
                MessageBox.Show("Número de celular incompleto", "Erro de informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                validar = false;
            }
            else
            {
                validar = true;
            }
            return validar;
        }
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e) //Botão de voltar
        {
            menuNozama menuNozama = new menuNozama();

            menuNozama.Show();
            menuNozama.Left = this.Left;
            menuNozama.Top = this.Top;
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e) //Botão de limpar o formulario
        {
            DialogResult resposta = MessageBox.Show("Você realmente deseja limpar todo o formulario ?", "Limpeza de formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                txtNome.Clear();
                txtCPF.Clear();
                dtpNascimento.ResetText();
                txtCelular.Clear();
                txtEndereco.Clear();
                txtEmail.Clear();
                cmbDeficiencia.SelectedIndex = -1;
                txtObservacoes.Clear();
                cmbWhatsapp.SelectedIndex = -1;
                cmbSexo.SelectedIndex = -1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Botão de salvar
        {
            if (ValidarFormulario() == true)
            {
                string cpf = txtCPF.Text;

                DialogResult cliqueS =
                MessageBox.Show("Deseja confirmar o salvamento dos seus dados de usuário?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                List<Paciente> usuarios = new Paciente().VerificarCpf(cpf);
                if (usuarios.Count <= 0)
                {

                    if (cliqueS == DialogResult.OK)
                    {
                        Paciente usuario = new Paciente();
                        usuario.Nome = txtNome.Text;
                        usuario.Cpf = txtCPF.Text;
                        usuario.Datanascimento = Convert.ToDateTime(dtpNascimento.Text);
                        usuario.Sexo = cmbSexo.Text;
                        usuario.Celular = txtCelular.Text;
                        usuario.Whatsapp = cmbWhatsapp.Text;
                        usuario.Endereco = txtEndereco.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.Deficiencia = cmbDeficiencia.Text;
                        usuario.Obs = txtObservacoes.Text;
                        usuario.Salvar();
                        txtNome.Clear();
                        txtCPF.Clear();
                        dtpNascimento.ResetText();
                        txtCelular.Clear();
                        txtEndereco.Clear();
                        txtEmail.Clear();
                        cmbDeficiencia.SelectedIndex = -1;
                        txtObservacoes.Clear();
                        cmbWhatsapp.SelectedIndex = -1;
                        cmbSexo.SelectedIndex = -1;
                        DialogResult novo = MessageBox.Show("Deseja realizar um novo cadastro ?", "Novo cadastro",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if(novo == DialogResult.No)
                        {
                            menuNozama nova = new menuNozama();
                            nova.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seus dados não foram salvos.", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("CPF já está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCPF_MouseClick(object sender, MouseEventArgs e)
        {
            txtCPF.SelectionStart = 0;
        }

        private void txtCelular_MouseClick(object sender, MouseEventArgs e)
        {
            txtCelular.SelectionStart = 0;
        }
    }
}