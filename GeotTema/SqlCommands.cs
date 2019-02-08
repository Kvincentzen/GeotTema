using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data; 

namespace GeotTema
{
    class SqlCommands
    {
        public List<Table> GetTable(string Land)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select * from Lande where Lande = '{Land}'").ToList();
            }
        }
    }
}
