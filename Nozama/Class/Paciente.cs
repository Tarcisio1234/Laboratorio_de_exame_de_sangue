using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nozama.Class;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static Nozama.Controller.Conexao;

namespace Nozama.Class
{


    public class Paciente
    {
        public int Idpaciente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }
        public string Deficiencia { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string Whatsapp { get; set; }
        public DateTime Datanascimento { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }
        public int Idprofissional { get; set; }



        public void Salvar()
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO `paciente`(`nome`,`endereco`,`email`,`obs`,`deficiencia`,`cpf`,`celular`,`sexo`,`whatsapp`,`datanascimento`)VALUES(@nome,@endereco,@email,@obs,@deficiencia,@cpf,@celular,@sexo,@whatsapp,@datanascimento);";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@endereco", Endereco);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@obs", Obs);
                cmd.Parameters.AddWithValue("@deficiencia", Deficiencia);
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                cmd.Parameters.AddWithValue("@celular", Celular);
                cmd.Parameters.AddWithValue("@sexo", Sexo);
                cmd.Parameters.AddWithValue("@whatsapp", Whatsapp);
                cmd.Parameters.AddWithValue("@datanascimento", Datanascimento);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Os dados do paciente {Nome} foram salvos", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Paciente> BuscarPaciente(string Cpf)
        {
            List<Paciente> pacientes = new List<Paciente>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM paciente WHERE cpf = @cpf;";
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                using (MySqlDataReader reder = cmd.ExecuteReader())
                {
                    while (reder.Read())
                    {
                        Paciente objeto = new Paciente();
                        objeto.Idpaciente = reder.GetInt32("idpaciente");
                        objeto.Nome = reder.GetString("nome");
                        objeto.Endereco = reder.GetString("endereco");
                        objeto.Email = reder.GetString("email");
                        objeto.Obs = reder.GetString("obs");
                        objeto.Deficiencia = reder.GetString("deficiencia");
                        objeto.Sexo = reder.GetString("sexo");
                        objeto.Celular = reder.GetString("celular");
                        objeto.Datanascimento = reder.GetDateTime("datanascimento");
                        objeto.Whatsapp = reder.GetString("whatsapp");
                        pacientes.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Não localizado ", ex.Message);
            }
            return pacientes;
        }
        public void Editar_Cliente()
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE `paciente` SET `nome` = @nome,`endereco` = @endereco,`email` = @email,`obs` = @obs, `deficiencia` = @deficiencia, `cpf` = @cpf, `sexo` = @sexo, `whatsapp` = @whatsapp,`datanascimento` = @datanascimento WHERE `idpaciente` = @idpaciente;";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@endereco", Endereco);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@obs", Obs);
                cmd.Parameters.AddWithValue("@deficiencia", Deficiencia);
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                cmd.Parameters.AddWithValue("@sexo", Sexo);
                cmd.Parameters.AddWithValue("@whatsapp", Whatsapp);
                cmd.Parameters.AddWithValue("@datanascimento", Datanascimento);
                cmd.Parameters.AddWithValue("@idpaciente", Idpaciente);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("As alterações foram feitas com sucesso","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }
        public static List<Paciente> BuscarDadosPaciente()
        {
            List<Paciente> pacientes = new List<Paciente>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM paciente";
                using (MySqlDataReader reder = cmd.ExecuteReader())
                {
                    while (reder.Read())
                    {
                        Paciente objeto = new Paciente();
                        objeto.Idpaciente = reder.GetInt32("idpaciente");
                        objeto.Cpf = reder.GetString("cpf");
                        objeto.Nome = reder.GetString("nome");
                        objeto.Endereco = reder.GetString("endereco");
                        objeto.Email = reder.GetString("email");
                        objeto.Obs = reder.GetString("obs");
                        objeto.Deficiencia = reder.GetString("deficiencia");
                        objeto.Sexo = reder.GetString("sexo");
                        objeto.Celular = reder.GetString("celular");
                        objeto.Datanascimento = reder.GetDateTime("datanascimento");
                        objeto.Whatsapp = reder.GetString("whatsapp");
                        pacientes.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Não localizado ", ex.Message);
            }
            return pacientes;
        }
        public static List<Paciente> BuscarDadosProfissional()
        {
            List<Paciente> pacientes = new List<Paciente>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM profissional";
                using (MySqlDataReader reder = cmd.ExecuteReader())
                {
                    while (reder.Read())
                    {
                        Paciente objeto = new Paciente();
                        objeto.Idprofissional = reder.GetInt32("idprofissional");
                        objeto.Cpf = reder.GetString("cpf");
                        objeto.Nome = reder.GetString("nome");
                        objeto.Endereco = reder.GetString("endereco");
                        // objeto.Email = reder.GetString("email");
                        objeto.Profissao = reder.GetString("profissao");

                        objeto.Sexo = reder.GetString("sexo");
                        objeto.Celular = reder.GetString("celular");
                        objeto.Datanascimento = reder.GetDateTime("dataNacimento");

                        pacientes.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Não localizado ", ex.Message);
            }
            return pacientes;
        }

        public void Deletar(int Idpaciente)
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                DialogResult cliqueD = MessageBox.Show("Deseja apagar os dados do paciente?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cliqueD == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM `paciente` WHERE idpaciente = @idpaciente";
                    cmd.Parameters.AddWithValue("@idpaciente", Idpaciente);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Deletado com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Os dados do paciente não foram apagados!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não localizado" + ex.Message);
            }
        }
        public List<Paciente> VerificarCpf(object Cpf)
        {
            List<Paciente> usuarios = new List<Paciente>();
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select cpf from paciente where cpf = @cpf;";
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Paciente objeto = new Paciente();
                        objeto.Cpf = reader.GetString("cpf");
                        usuarios.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Não localizado! ", ex.Message);
            }
            return usuarios;
        }

    }
    
}
               
            


