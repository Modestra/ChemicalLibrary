using System;
using System.Data.SqlClient;

namespace DataBaseLibrary
{
    public class DataBaseConnect
    {

    }
    public class DataBaseInputElements
    {
        public void InputElement(SqlConnection sql)
        {
            try
            { //Не работает
                SqlCommand input = new SqlCommand($"INSERT INTO ChemElementList(Element,Name) VALUES('H','Водород');", sql);
                input.ExecuteNonQuery();
            }
            catch
            {

            }

        }
    }
}
