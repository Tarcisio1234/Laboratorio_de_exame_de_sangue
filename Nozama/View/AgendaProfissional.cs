using Microsoft.Win32;
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
    public partial class gridAgenda : Form
    {
        public gridAgenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuNozama novoMenu = new menuNozama();
            novoMenu.Show();
            novoMenu.Left = this.Left;
            novoMenu.Top = this.Top;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (txtNome.Text.Length >= 3)
            {
                List<Exame> cliente = new Exame().Agenda(nome);
                gridAgenda2.DataSource = cliente;
                gridAgenda2.Columns["Idexame"].Visible = false;
                gridAgenda2.Columns["CPF"].Visible = false;
                gridAgenda2.Columns["Sexo"].Visible = false;
                gridAgenda2.Columns["Obs"].Visible = false;
                //gridAgenda2.Columns["Nome"].DisplayIndex = 1;
                gridAgenda2.Columns["Data"].DisplayIndex = 2;
                gridAgenda2.Columns["Apaga"].DisplayIndex = 3;
                gridAgenda2.Columns["Coagulograma"].DisplayIndex = 4;
                gridAgenda2.Columns["Tireoide"].DisplayIndex = 5;
                gridAgenda2.Columns["Hiv"].DisplayIndex = 6;
                gridAgenda2.Columns["Funcaohepatica"].DisplayIndex = 7;
                gridAgenda2.Columns["Colesterol"].DisplayIndex = 8;
                gridAgenda2.Columns["Ureia"].DisplayIndex = 9;
                gridAgenda2.Columns["Hemograma"].DisplayIndex = 10;
                gridAgenda2.Columns["Glicose"].DisplayIndex = 11;
                gridAgenda2.Columns["Creatinina"].DisplayIndex = 12;
            }
            else
            {
                MessageBox.Show("O campo de nome está vazio ou insuficiente!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                gridAgenda nova = new gridAgenda();
                nova.Show();
                nova.Left = this.Left;
                nova.Top = this.Top;
                this.Hide();
            }
        }

        private void AgendaProfissional_Load(object sender, EventArgs e)
        {
            List<Exame> registros = Exame.DadosExame();
            gridAgenda2.DataSource = registros;
            gridAgenda2.Columns["Idexame"].Visible = false;
            gridAgenda2.Columns["CPF"].Visible = false;
            gridAgenda2.Columns["Sexo"].Visible = false;
            gridAgenda2.Columns["Obs"].Visible = false;
            //gridAgenda2.Columns["Nome"].DisplayIndex = 1;
            gridAgenda2.Columns["Data"].DisplayIndex = 2;
            gridAgenda2.Columns["Apaga"].DisplayIndex = 3;
            gridAgenda2.Columns["Coagulograma"].DisplayIndex = 4;
            gridAgenda2.Columns["Tireoide"].DisplayIndex = 5;
            gridAgenda2.Columns["Hiv"].DisplayIndex = 6;
            gridAgenda2.Columns["Funcaohepatica"].DisplayIndex = 7;
            gridAgenda2.Columns["Colesterol"].DisplayIndex = 8;
            gridAgenda2.Columns["Ureia"].DisplayIndex = 9;
            gridAgenda2.Columns["Hemograma"].DisplayIndex = 10;
            gridAgenda2.Columns["Glicose"].DisplayIndex = 11;
            gridAgenda2.Columns["Creatinina"].DisplayIndex = 12;
        }

        private void gridAgenda2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == gridAgenda2.Columns["Apaga"].Index)
            {
                int idExame = (int)gridAgenda2.Rows[e.RowIndex].Cells["Idexame"].Value;
                Exame registro = new Exame();
                registro.Deletar(idExame);

                List<Exame> registros = Exame.DadosExame();
                gridAgenda2.DataSource = registros;

                gridAgenda2.Columns["Idexame"].Visible = false;
                gridAgenda2.Columns["CPF"].Visible = false;
                gridAgenda2.Columns["Sexo"].Visible = false;
                gridAgenda2.Columns["Obs"].Visible = false;
                //gridAgenda2.Columns["Nome"].DisplayIndex = 1;
                gridAgenda2.Columns["Data"].DisplayIndex = 2;
                gridAgenda2.Columns["Apaga"].DisplayIndex = 3;
                gridAgenda2.Columns["Coagulograma"].DisplayIndex = 4;
                gridAgenda2.Columns["Tireoide"].DisplayIndex = 5;
                gridAgenda2.Columns["Hiv"].DisplayIndex = 6;
                gridAgenda2.Columns["Funcaohepatica"].DisplayIndex = 7;
                gridAgenda2.Columns["Colesterol"].DisplayIndex = 8;
                gridAgenda2.Columns["Ureia"].DisplayIndex = 9;
                gridAgenda2.Columns["Hemograma"].DisplayIndex = 10;
                gridAgenda2.Columns["Glicose"].DisplayIndex = 11;
                gridAgenda2.Columns["Creatinina"].DisplayIndex = 12;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = dataTeste.Text;
            try
            {
                List<Exame> cliente = new Exame().DataBuscar(data);
                gridAgenda2.DataSource = cliente;
                gridAgenda2.Columns["Idexame"].Visible = false;
                gridAgenda2.Columns["CPF"].Visible = false;
                gridAgenda2.Columns["Sexo"].Visible = false;
                gridAgenda2.Columns["Obs"].Visible = false;
                //gridAgenda2.Columns["Nome"].DisplayIndex = 1;
                gridAgenda2.Columns["Data"].DisplayIndex = 2;
                gridAgenda2.Columns["Apaga"].DisplayIndex = 3;
                gridAgenda2.Columns["Coagulograma"].DisplayIndex = 4;
                gridAgenda2.Columns["Tireoide"].DisplayIndex = 5;
                gridAgenda2.Columns["Hiv"].DisplayIndex = 6;
                gridAgenda2.Columns["Funcaohepatica"].DisplayIndex = 7;
                gridAgenda2.Columns["Colesterol"].DisplayIndex = 8;
                gridAgenda2.Columns["Ureia"].DisplayIndex = 9;
                gridAgenda2.Columns["Hemograma"].DisplayIndex = 10;
                gridAgenda2.Columns["Glicose"].DisplayIndex = 11;
                gridAgenda2.Columns["Creatinina"].DisplayIndex = 12;
            }
            catch
            {
                MessageBox.Show("O campo de nome está vazio ou insuficiente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridAgenda nova = new gridAgenda();
                nova.Show();
                nova.Left = this.Left;
                nova.Top = this.Top;
                this.Hide();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridAgenda nova = new gridAgenda();
            nova.Show();
            nova.Left = this.Left;
            nova.Top = this.Top;
            this.Hide();
        }
    }
}
