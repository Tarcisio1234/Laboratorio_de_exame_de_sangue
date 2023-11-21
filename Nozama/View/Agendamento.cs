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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {//Botão de voltar
            menuNozama novoMenu = new menuNozama();
            
            novoMenu.Show();
            novoMenu.Left = this.Left;
            novoMenu.Top = this.Top;
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {// Botão para limpar os campos
            DialogResult clique = MessageBox.Show("Você realmente deseja apagar os dados do agendamento?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (clique == DialogResult.Yes)
            {
                okHemograma.Checked = false;
                okColesterol.Checked = false;
                okGlicose.Checked = false;
                okCoagulograma.Checked = false;
                okFuncaoHepatica.Checked = false;
                okTireoide.Checked = false;
                okUreia.Checked = false;
                okCreatina.Checked = false;
                okHiv.Checked = false;
                dateAgendamento.ResetText();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult cliqueS =
                MessageBox.Show("Deseja confirmar o salvamento dos seus dados do exame?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cliqueS == DialogResult.OK)
            {
                Exame usuario = new Exame();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txt_Cpf.Text;
                usuario.Sexo = cmbSexo.Text;
                usuario.DataExame = Convert.ToDateTime(dateAgendamento.Text);
                usuario.Obs = txtObs.Text;
                usuario.Tireoide = okTireoide.Checked;
                usuario.Hemograma = okHemograma.Checked;
                usuario.Colesterol = okColesterol.Checked;
                usuario.Glicose = okGlicose.Checked;
                usuario.Coagulograma = okCoagulograma.Checked;
                usuario.FuncaoHepatica = okFuncaoHepatica.Checked;
                usuario.Ureia = okUreia.Checked;
                usuario.Creatinina = okCreatina.Checked;
                usuario.HIV = okHiv.Checked;
                usuario.Salvar();
            }
            else
            {
                MessageBox.Show("Seus dados ainda não foram salvos.", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            BuscarCliente TelaBuscarClientes = new BuscarCliente();
            TelaBuscarClientes.Show();
            this.Hide();
        }

        private void btnBuscarCPF_Click(object sender, EventArgs e)
        {
            string Cpf = txt_Cpf.Text;
            if (!string.IsNullOrEmpty(Cpf))
            {
                List<Paciente> pacientes = new Paciente().BuscarPaciente(Cpf);
                if (pacientes.Count > 0)
                {
                    Paciente resultado = pacientes[0];
                    txtNome.Text = resultado.Nome;
                    cmbSexo.Text = resultado.Sexo;
                    dtpNascimento.Text = resultado.Datanascimento.ToString();
                    txtObs.Text = resultado.Obs;

                    txtNome.Enabled = false;
                    dtpNascimento.Enabled = false;
                    cmbSexo.Enabled = false;
                    txtObs.Enabled = false;
                }
            }
        }

        private void txt_Cpf_MouseClick(object sender, MouseEventArgs e)
        {
            txt_Cpf.SelectionStart = 0;
        }
    }
}
