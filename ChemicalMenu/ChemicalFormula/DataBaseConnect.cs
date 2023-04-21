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
        public string errormessage = String.Empty;
        public SqlConnection chemDB = null;
        public DataBaseConnect()
        {
            try
            {
                chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemDB"].ConnectionString);
                chemDB.Open();
            }
            catch
            {
                chemDB.Close();
                errormessage = "Не удалось подключиться к базе данных";
            }
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
        public object GetCharacteristic(string element, int index)
        {
            SqlDataReader reader = null;
            try
            {
                string link = $"SELECT * FROM PeriodicTable WHERE Element = '{element}'";
                SqlCommand command = new SqlCommand(link, chemDB);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetValue(index);
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
