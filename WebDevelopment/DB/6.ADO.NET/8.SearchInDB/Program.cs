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
            string input = "Kiselo mlqko na Baba";
            //string input = "%";
            string[] inputSeparator = input.Split(new char[] { '_', '\'', '%', '\"', '\\' });
            StringBuilder newInput = new StringBuilder();
            foreach (var myChar in inputSeparator)
            {
                newInput.Append(myChar);
            }
            var saveSearch = newInput.ToString().Trim();

            if (saveSearch.Length > 0)
            {
                SearchItem(saveSearch);
            }
        }

        private static void SearchItem(string searchedString)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ProductName Like @searchedString;", dbCon);
                command.Parameters.AddWithValue("@searchedString", "%" + searchedString + "%");
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    string quantityPerUnit = (string)reader["QuantityPerUnit"];
                    decimal unitPrice = (decimal)reader["UnitPrice"];

                    Console.WriteLine("{0} | {1} | {2} |", productName, quantityPerUnit, unitPrice);
                }
            }
        }
    }
}
