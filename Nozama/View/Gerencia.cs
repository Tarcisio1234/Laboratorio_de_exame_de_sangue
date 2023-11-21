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
    public partial class Gerencia : Form
    {
        public Gerencia()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menuNozama telaMenu = new menuNozama();
            telaMenu.Show();
            this.Close();
        }

        private void Gerencia_Load(object sender, EventArgs e)
        {
            List<Paciente> pacientes = Paciente.BuscarDadosPaciente();
            gridPaciente.DataSource = pacientes;
            gridPaciente.Columns["Sexo"].DisplayIndex = 4;
            gridPaciente.Columns["Celular"].DisplayIndex = 5;
            gridPaciente.Columns["Endereco"].DisplayIndex = 6;
            gridPaciente.Columns["Apagar1"].DisplayIndex = 7;
            gridPaciente.Columns["Email"].Visible = false;
            gridPaciente.Columns["Obs"].Visible = false;
            gridPaciente.Columns["Deficiencia"].Visible = false;
            gridPaciente.Columns["Whatsapp"].Visible = false;
            gridPaciente.Columns["Profissao"].Visible = false;
            gridPaciente.Columns["DataNascimento"].Visible = false;
            gridPaciente.Columns["idProfissional"].Visible = false;

            List<Paciente> profissionais = Paciente.BuscarDadosProfissional();
            gridProfissional.DataSource = profissionais;
            gridProfissional.Columns["Sexo2"].DisplayIndex = 5;
            gridProfissional.Columns["Celular2"].DisplayIndex = 6;
            gridProfissional.Columns["Endereco2"].DisplayIndex = 7;
            gridProfissional.Columns["Apagar2"].DisplayIndex = 8;
            gridProfissional.Columns["Profissao2"].DisplayIndex = 9;
            gridProfissional.Columns["Email"].Visible = false;
            gridProfissional.Columns["Obs"].Visible = false;
            gridProfissional.Columns["Deficiencia"].Visible = false;
            gridProfissional.Columns["Whatsapp"].Visible = false;
            gridProfissional.Columns["DataNascimento"].Visible = false;
            gridProfissional.Columns["Idpaciente"].Visible = false;
        }

        private void gridPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == (int)gridPaciente.Columns["Apagar1"].Index)
            {
                int idpaciente = (int)gridPaciente.Rows[e.RowIndex].Cells["Idpaciente"].Value;
                Paciente registro1 = new Paciente();
                registro1.Deletar(idpaciente);
                List<Paciente> registros1 = Paciente.BuscarDadosPaciente();
                gridPaciente.DataSource = registros1;
                List<Paciente> pacientes = Paciente.BuscarDadosPaciente();
                gridPaciente.DataSource = pacientes;
                gridPaciente.Columns["Sexo"].DisplayIndex = 4;
                gridPaciente.Columns["Celular"].DisplayIndex = 5;
                gridPaciente.Columns["Endereco"].DisplayIndex = 6;
                gridPaciente.Columns["Apagar1"].DisplayIndex = 7;
                gridPaciente.Columns["Email"].Visible = false;
                gridPaciente.Columns["Obs"].Visible = false;
                gridPaciente.Columns["Deficiencia"].Visible = false;
                gridPaciente.Columns["Whatsapp"].Visible = false;
                gridPaciente.Columns["Profissao"].Visible = false;
                gridPaciente.Columns["DataNascimento"].Visible = false;
                gridPaciente.Columns["idProfissional"].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarProfissional novo = new CadastrarProfissional();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCliente novo = new CadastroCliente();
            novo.Show();
            novo.Left = this.Left;
            novo.Top = this.Top;
            this.Hide();
        }

        private void gridProfissional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == (int)gridProfissional.Columns["Apagar2"].Index)
            {
                int idprofissional = (int)gridProfissional.Rows[e.RowIndex].Cells["ID2"].Value;
                Profissional registro2 = new Profissional();
                registro2.Deletar(idprofissional);
                List<Paciente> registros2 = Paciente.BuscarDadosProfissional();
                gridProfissional.DataSource = registros2;

                List<Paciente> profissionais = Paciente.BuscarDadosProfissional();
                gridProfissional.DataSource = profissionais;
                gridProfissional.Columns["ID2"].DisplayIndex = 1;
                gridProfissional.Columns["Nome2"].DisplayIndex = 2;
                gridProfissional.Columns["Cpf2"].DisplayIndex = 3;
                gridProfissional.Columns["Data2"].DisplayIndex = 4;
                gridProfissional.Columns["Sexo2"].DisplayIndex = 5;
                gridProfissional.Columns["Celular2"].DisplayIndex = 6;
                gridProfissional.Columns["Endereco2"].DisplayIndex = 7;
                gridProfissional.Columns["Apagar2"].DisplayIndex = 8;
                gridProfissional.Columns["Profissao2"].DisplayIndex = 9;
                gridProfissional.Columns["Email"].Visible = false;
                gridProfissional.Columns["Obs"].Visible = false;
                gridProfissional.Columns["Deficiencia"].Visible = false;
                gridProfissional.Columns["Whatsapp"].Visible = false;
                gridProfissional.Columns["DataNascimento"].Visible = false;
                gridProfissional.Columns["Idpaciente"].Visible = false;
            }
        }
    }
}
