using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetNameAndDescriptions
{
    class Program
    {
        static string CONNECTION_STRING = "Server=.; Database=NORTHWND; Integrated Security=true";

        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            Dictionary<string, string> myResult = new Dictionary<string, string>();
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand selectSomeDataFromNorth = new SqlCommand(
                   "SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader result = selectSomeDataFromNorth.ExecuteReader();

                using (result)
                {
                    while (result.Read())
                    {
                        string name = (string)result["CategoryName"];
                        string description = (string)result["Description"];
                        if (!myResult.ContainsKey(name))
                        {
                            myResult.Add(name, description);
                        }
                    }
                }
            }

            foreach (var record in myResult)
            {
                Console.WriteLine("{0} -> {1}", record.Key, record.Value);
            }
        }
    }
}
