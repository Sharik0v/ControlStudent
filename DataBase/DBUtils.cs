using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStudents.DataBase
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"WIN-J037JLCJJCT\SQLEXPRESS";

            string database = "StControl";
            string username = "sa";
            string password = "1234";

            return DBServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
