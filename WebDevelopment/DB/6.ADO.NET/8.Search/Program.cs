using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Search
{
    public class Program
    {
        static string CONNECTION_STRING = "Server=.; Database=NORTHWND; Integrated Security=true";

        static void Main(string[] args)
        {
            SearchItem("dsgfsad");
        }

        private static void SearchItem(string searchedString)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT ProductName FROM Products WHERE ProductName Like @searchedString;", dbCon);
                command.Parameters.AddWithValue("@searchedString", "%" + searchedString + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string product = (string)reader["ProductName"];
                    Console.WriteLine(product);
                }
            }
        }
    }
}
