using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace GeotTema
{
    class SqlCommands
    {
        public string Login_Name = "sql_admin";
        public string Login_Pass = "Passw0rd";
        public string connectionString = ($"Data Source=10.0.5.103;Initial Catalog=GeoTema;User ID=sql_admin;password=Passw0rd;");
        public List<Table> GetTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select * from Lande").ToList();
            }
        }
        public DataTable GetDataTable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                string connection.Query<Table>($"select * from Lande").ToList();
            }
        }
        public List<Table> SearchTable(string Land)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select * from Lande where Lande.Lande LIKE '{Land}%'").ToList();
            }
        }
        public static void CreateLogin(string name, string pass)
        {
                Sqlstatment($"CREATE LOGIN {name} WITH PASSWORD = '{pass}';");
                Sqlstatment($"CREATE USER u{name} FOR LOGIN {name};");
                Sqlstatment($"GRANT CONNECT TO u{name};");
                Sqlstatment($"GRANT SELECT ON LANDE TO u{name}");
        }
        public static void Sqlstatment(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GeoTemaDB"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }
        public bool Login (string name, string pass)
        {
            SqlConnection cnn;
            string connetionString = ($"Data Source=10.0.5.103;Initial Catalog=GeoTema;User ID={name};password={pass};");
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Du er nu logget ind ");
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
