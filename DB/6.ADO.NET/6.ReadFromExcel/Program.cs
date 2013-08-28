using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;

namespace _6.ReadFromExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=Book1.xls;Extended Properties=""Excel 12.0 XML;HDR=Yes""");
            OleDbCommand myCommand = new OleDbCommand("select * from [MySheet$]", dbConn);
            dbConn.Open();
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"];
                Console.WriteLine("{0} - score: {1}", name, score);
            }

            dbConn.Close();
        }
    }
}
