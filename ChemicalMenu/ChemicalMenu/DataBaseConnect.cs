using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ChemicalMenu
{
    internal class DataBaseConnect
    {
        public SqlConnection chemDB = null;
        public DataBaseConnect()
        {
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemDB"].ConnectionString);
            chemDB.Open();
        }
        public void SelectAllTable(string tablename, DataGridView table)
        {
            try
            {
                SqlCommand select = new SqlCommand($"SELECT * FROM {tablename}");
                select.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Неизвестное название таблицы или неизвестное DataGridView");
            }
        }
    }
}
