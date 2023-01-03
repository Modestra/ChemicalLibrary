using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ChemicalFormula
{
    public class DataBaseConnect
    {
        public SqlConnection chemDB = null;
        public DataBaseConnect()
        {
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemDB"].ConnectionString);
            chemDB.Open();
        }
        public void ElementInformation(string name, ref List<string> list)
        {
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand($"SELECT Element_Name FROM Table WHERE Element_Name LIKE {name}");
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader["Element_Name"].ToString());
            }
        }
        public decimal GetMolarMass(string element)
        {
            SqlDataReader reader = null;
            try
            {
                string link = $"SELECT * FROM PeriodicTable WHERE Element = '{element}'";
                SqlCommand command = new SqlCommand(link, chemDB);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return (decimal)reader.GetValue(3);
                }
                return 0;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
