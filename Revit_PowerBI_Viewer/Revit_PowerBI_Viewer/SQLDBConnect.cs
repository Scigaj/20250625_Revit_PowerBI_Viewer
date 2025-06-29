using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Revit_PowerBI_Viewer
{
    public class SQLDBConnect
    {
        public static SqlConnection connect;

        public void ConnectDB()
        {
            //Connect to SQL database
            connect = new SqlConnection(@"Data Source=KPFLDLAP-387\SQLEXPRESS;Initial Catalog=Revit_API_SQL;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
            connect.Open();
        }

        public SqlCommand Query(string sqlQuery)
            {
            //Create a SQL command
            SqlCommand command = new SqlCommand(sqlQuery, connect);
            return command;
        }

    }
}
