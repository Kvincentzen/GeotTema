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
                return connection.Query<Table>($"select {Land} from Lande, Rang where Lande.ID = Rang.ID").ToList();
            }
        }
        public List<Table> SearchTable(string Land)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("GeoTemaDB")))
            {
                return connection.Query<Table>($"select Lande, Rang from Lande join Rang on Lande.ID = Rang.ID where Lande.Lande = {Land}").ToList();
            }
        }
    }
}
