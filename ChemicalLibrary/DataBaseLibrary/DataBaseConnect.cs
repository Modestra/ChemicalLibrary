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
            SqlCommand input = new SqlCommand($"INSERT INTO ChemElementList(Element,Name,Atomic_Mass) VALUES(@Element,@Name,@Atomic_Mass);", sql);
            input.Parameters.AddWithValue("Element", element);
            input.Parameters.AddWithValue("Name", nameElement);
            input.Parameters.AddWithValue("Atomic_Mass", atomicMass);
            //addstring.AddTextInFile("Выполнено строк: " + input.ExecuteNonQuery().ToString());

        }
        public void SelectElement(string element, SqlConnection sql)
        {
            SqlCommand input = new SqlCommand($"SELECT Element FROM ChemElementList WHERE Element = {element}", sql);
            
        }
    }
}
