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
        { //Не работает
            FileWriter addstring = new FileWriter();
            try
            {
                SqlCommand input = new SqlCommand($"INSERT INTO ChemElementList(Element,Name,Atomic_Mass) VALUES('{element}',N'{nameElement}',{atomicMass})", sql);
                addstring.AddTextInFile($"Выполнено строк: {input.ExecuteNonQuery()}");
            }
            catch (SqlException ice)
            {
                addstring.AddTextInFile($"Не удалось выполнить команду:{ice.Message} ");
            }
        }
        public void SelectElement(string element, SqlConnection sql)
        {
            SqlCommand input = new SqlCommand($"SELECT * FROM ChemElementList WHERE Element = {element}", sql);
            
        }
    }
}
