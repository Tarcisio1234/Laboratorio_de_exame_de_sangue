using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nozama.Controller.Conexao;

namespace Nozama.Class
{
    public class Profissional
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public int Idprofissional { get; set; }

        public void Salvar()
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja salvar os dados do usuário?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                    MySqlConnection connection = connectionManager.GetConnect();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO `profissional`(`nome`,`cpf`,`endereco`,`celular`,`profissao`,`dataNacimento`,`sexo`)VALUES(@nome, @cpf, @endereco, @celular, @profissao, @dataNacimento, @sexo)";
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@endereco", Endereco);
                    cmd.Parameters.AddWithValue("@celular", Celular);
                    cmd.Parameters.AddWithValue("@profissao", Profissao);
                    cmd.Parameters.AddWithValue("@datanacimento", Datanascimento);
                    cmd.Parameters.AddWithValue("@sexo", Sexo);
                    cmd.Parameters.AddWithValue("@cpf", Cpf);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($" Os dados do paciente {Nome} foram salvos com sucesso","Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O erro esta na classe salvar profissioanl"+ex.Message);
            }
         }
        public void Deletar(int Idprofissional)
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                DialogResult cliqueD = MessageBox.Show("Deseja apagar os dados do profissional?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cliqueD == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM `profissional` WHERE idprofissional = @idprofissional";
                    cmd.Parameters.AddWithValue("@idprofissional", Idprofissional);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Deletado com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
                else
                {
                    MessageBox.Show("Os dados do profissional não foram apagados!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não localizado" + ex.Message);
            }
        }
    }
}
