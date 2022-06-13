using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DebugUtilites;

namespace DataBaseLibrary
{
    public class DataBase
    {

    }
    public class DataBaseConnection
    {
        private SqlConnection chemDB = null;
        public void DataBaseConnect()
        {
            FileWriter addQuery = new FileWriter();
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemDataBase"].ConnectionString);
            chemDB.Open();
        }

    }

}
