using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace _TransferDataOtherTable
{
    class Program
    {
        static string CONNECTION_STRING = "Server=.; Database=NORTHWND; Integrated Security=true";

        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            List<string> myResult = new List<string>();
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand selectSomeDataFromNorth = new SqlCommand(
                   "SELECT TOP 5 * FROM Region", dbCon);
                SqlDataReader result = selectSomeDataFromNorth.ExecuteReader();

                using (result)
                {
                    while (result.Read())
                    {
                        myResult.Add((string)result["RegionDescription"]);                        
                    }
                }
            }

            //Console.WriteLine("Select Done");

            dbCon = new SqlConnection(CONNECTION_STRING);
            dbCon.Open();
            using (dbCon) 
            {
                foreach (var record in myResult)
                {
                    Console.WriteLine(record);
                    string sqlQ = string.Format("INSERT INTO Categories ([CategoryName], [Description]) VALUES ('{0}', '{1}')", record, "Some Descripions");
                    Console.WriteLine(sqlQ);
                    SqlCommand insertSomeData = new SqlCommand(sqlQ, dbCon);
                    insertSomeData.ExecuteNonQuery();
                }
            }
            //Console.WriteLine("Insert Done");
        }
    }
}
