using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nozama.Controller.Conexao;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Nozama.Class
{
    public class Exame
    {
        public int Idexame { get; set; }
        public DateTime DataExame { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }
        public string Obs { get; set; }
        public bool Hemograma { get; set; }
        public bool Colesterol { get; set; }
        public bool Glicose { get; set; }
        public bool Coagulograma { get; set; }
        public bool FuncaoHepatica { get; set; }
        public bool Tireoide { get; set; }
        public bool Ureia { get; set; }
        public bool Creatinina { get; set; }
        public bool HIV { get; set; }


        public void Salvar()
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO `exame`(`nome`,`cpf`,`sexo`,`dataExame`,`obs`,`tireoide`,`hemograma`,`colesterol`,`glicose`,`coagulograma`,`funcaohepatica`,`ureia`,`creatinina`,`hiv`)" +
                                                "VALUES(@nome,@cpf,@sexo,@dataExame,@obs,@tireoide,@hemograma,@colesterol,@glicose,@coagulograma,@funcaohepatica,@ureia,@creatinina,@hiv);";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@cpf", Cpf);
                cmd.Parameters.AddWithValue("@sexo", Sexo);
                cmd.Parameters.AddWithValue("@dataExame", DataExame);
                cmd.Parameters.AddWithValue("@obs", Obs);
                cmd.Parameters.AddWithValue("@tireoide", Tireoide ? 1 : 0);
                cmd.Parameters.AddWithValue("@hemograma", Hemograma ? 1 : 0);
                cmd.Parameters.AddWithValue("@colesterol", Colesterol ? 1 : 0);
                cmd.Parameters.AddWithValue("@glicose", Glicose ? 1 : 0);
                cmd.Parameters.AddWithValue("@coagulograma", Coagulograma ? 1 : 0);
                cmd.Parameters.AddWithValue("@funcaohepatica", FuncaoHepatica ? 1 : 0);
                cmd.Parameters.AddWithValue("@ureia", Ureia ? 1 : 0);
                cmd.Parameters.AddWithValue("@creatinina", Creatinina ? 1 : 0);
                cmd.Parameters.AddWithValue("@hiv", HIV ? 1 : 0);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"O exame do(a) paciente {Nome} foi marcado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Exame> Agenda(string nome)
        {
            List<Exame> lista = new List<Exame>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM exame WHERE nome LIKE CONCAT ('%',@nome,'%');";
                cmd.Parameters.AddWithValue("@nome", nome);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Exame objeto = new Exame();
                        objeto.Nome = reader.GetString("nome");
                        objeto.DataExame = reader.GetDateTime("dataexame");
                        objeto.Idexame = reader.GetInt32("idexame");
                        objeto.Tireoide = reader.GetBoolean("tireoide");
                        objeto.Hemograma = reader.GetBoolean("hemograma");
                        objeto.Colesterol = reader.GetBoolean("colesterol");
                        objeto.Glicose = reader.GetBoolean("glicose");
                        objeto.Coagulograma = reader.GetBoolean("coagulograma");
                        objeto.FuncaoHepatica = reader.GetBoolean("funcaohepatica");
                        objeto.Ureia = reader.GetBoolean("ureia");
                        objeto.Creatinina = reader.GetBoolean("creatinina");
                        objeto.HIV = reader.GetBoolean("hiv");

                        lista.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não localizado" + ex.Message);
            }
            return lista;
        }

        public static List<Exame> DadosExame()
        {
            List<Exame> registros = new List<Exame>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM exame";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Exame objeto = new Exame();
                        //objeto.Idexame = reader.GetInt32("idexame");
                        objeto.Nome = reader.GetString("nome");
                        objeto.Idexame = reader.GetInt32("idexame");
                        objeto.DataExame = reader.GetDateTime("dataexame");
                        objeto.Tireoide = reader.GetBoolean("tireoide");
                        objeto.Hemograma = reader.GetBoolean("hemograma");
                        objeto.Colesterol = reader.GetBoolean("colesterol");
                        objeto.Glicose = reader.GetBoolean("glicose");
                        objeto.Coagulograma = reader.GetBoolean("coagulograma");
                        objeto.FuncaoHepatica = reader.GetBoolean("funcaohepatica");
                        objeto.Ureia = reader.GetBoolean("ureia");
                        objeto.Creatinina = reader.GetBoolean("creatinina");
                        objeto.HIV = reader.GetBoolean("hiv");
                        registros.Add(objeto);
                    }
                }
                connection.Close();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return registros;
        }

        public void Deletar(int Idexame)
        {
            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                DialogResult cliqueD =
               MessageBox.Show("Deseja apagar o exame?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (cliqueD == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM `exame`WHERE idexame = @idexame";
                    cmd.Parameters.AddWithValue("@idexame", Idexame);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Deletado com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Exame não apagado!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não localizado" + ex.Message);
            }
        }
        public List<Exame> DataBuscar(string data)
        {   
            DateTime data2 = Convert.ToDateTime(data);
            List<Exame> lista = new List<Exame>();

            try
            {
                MySqlConnectionManager connectionManager = new MySqlConnectionManager();
                MySqlConnection connection = connectionManager.GetConnect();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM exame WHERE dataExame LIKE CONCAT  ('%',@dataexame,'%');";
                cmd.Parameters.AddWithValue("@dataexame", data2);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Exame objeto = new Exame();
                        objeto.Nome = reader.GetString("nome");
                        objeto.DataExame = reader.GetDateTime("dataexame");
                        objeto.Idexame = reader.GetInt32("idexame");
                        objeto.Tireoide = reader.GetBoolean("tireoide");
                        objeto.Hemograma = reader.GetBoolean("hemograma");
                        objeto.Colesterol = reader.GetBoolean("colesterol");
                        objeto.Glicose = reader.GetBoolean("glicose");
                        objeto.Coagulograma = reader.GetBoolean("coagulograma");
                        objeto.FuncaoHepatica = reader.GetBoolean("funcaohepatica");
                        objeto.Ureia = reader.GetBoolean("ureia");
                        objeto.Creatinina = reader.GetBoolean("creatinina");
                        objeto.HIV = reader.GetBoolean("hiv");

                        lista.Add(objeto);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não localizado" + ex.Message);
            }
            return lista;
        }
    }
}
