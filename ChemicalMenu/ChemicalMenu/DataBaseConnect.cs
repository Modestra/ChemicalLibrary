﻿using System;
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
    public class DataBaseConnect
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
            }
            catch
            {
                MessageBox.Show("Неизвестное название таблицы или неизвестное DataGridView");
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
        public decimal GetDecimal(string element)
        {
            string link = $"SELECT * FROM PeriodicTable WHERE Element = {element}";
            SqlCommand command = new SqlCommand(link, chemDB);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return (decimal)reader.GetValue(3);
            }
            else
            {
                return 0;
            }
        }
    }
}
