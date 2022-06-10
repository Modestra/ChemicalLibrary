using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataBaseLibrary
{
    public class DataBase
    {

    }
    public class DataBaseConnection
    {
        private SqlConnection test = null;
        public void DataBaseConnect()
        {
            test = new SqlConnection();
        }
    }

}
