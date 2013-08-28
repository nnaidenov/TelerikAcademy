using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;

namespace _7.InsertIntoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection dbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=Book1.xls;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO [MySheet$] (Name, Score) VALUES(@name, @score)", dbConn);
            dbConn.Open();
            myCommand.Parameters.AddWithValue("@name", "Niki");
            myCommand.Parameters.AddWithValue("@score", 53);
            myCommand.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}
