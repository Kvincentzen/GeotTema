using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Configuration;

namespace GeotTema
{
    class SqlCommands
    {
        public List<Table> GetTable(string Land)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select * from Lande").ToList();
            }
        }
        public List<Table> SearchTable(string Land)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select * from Lande where Lande.Lande = '{Land}'").ToList();
            }
        }
        /*public CreateLogin(string name, string pass)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query($"CREATE LOGIN {name} WITH PASSWORD = '{pass}'; CREATE USER u+{name} FOR LOGIN {name}; GRANT CONNECT TO U+{name}; GRANT SELECT ON LANDE TO U+{name}");
            }
        } */
        public static void CreateLogin(string name, string pass)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                Sqlstatment($"CREATE LOGIN {name} WITH PASSWORD = '{pass}';");
                Sqlstatment($"CREATE USER u{name} FOR LOGIN {name};");
                Sqlstatment($"GRANT CONNECT TO u{name};");
                Sqlstatment($"GRANT SELECT ON LANDE TO u{name}");

            }
        }
            //private static string ConnectionString = Helper.CnnVal("GeoTemaDB");
            public static void Sqlstatment(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GeoTemaDB"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
