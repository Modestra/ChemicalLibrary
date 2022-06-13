using System;
using System.Data.SqlClient;
using DebugUtilites;

namespace DataBaseLibrary
{
    public class DataBaseConnect
    {

    }
    public class DataBaseInputElements
    {
        public void InputElement(string element, string nameElement, decimal atomicMass, SqlConnection sql)
        {
            FileWriter addstring = new FileWriter(); //Не работает
            SqlCommand input = new SqlCommand($"INSERT INTO ChemElementList(Element,Name,Atomic_Mass) VALUES({element},{nameElement},{atomicMass});", sql);
            addstring.AddTextInFile("Выполнено строк: " + input.ExecuteNonQuery().ToString());

        }
    }
}
