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
            SqlCommand input = new SqlCommand($"", sql);
            input.ExecuteNonQuery();
        }
    }
}
