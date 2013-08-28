﻿using System;
using System.Data.SqlClient;
using System.IO;

namespace _05.RecieveImageFromDB
{
    class Program
    {
        const string FILE_LOCATION = @"..\";
        const string FILE_EXTENSION = @".jpg";

        static void Main()
        {
            ExtractImageFromDB();
        }

        static void ExtractImageFromDB()
        {
            SqlConnection dbConn = new SqlConnection("Server=.; " +
            "Database=NORTHWND; Integrated Security=true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT PICTURE, CategoryID, CategoryName FROM Categories", dbConn);

                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    byte[] image;
                    int categoryId;
                    string categoryName;
                    while (reader.Read())
                    {
                        image = (byte[])reader["Picture"];
                        categoryId = (int)reader["CategoryID"];
                        categoryName = (string)reader["CategoryName"];
                        WriteBinaryFile(image, FILE_LOCATION + categoryId + FILE_EXTENSION);
                        image = null;
                    }
                }
            }
        }

        static void WriteBinaryFile(byte[] fileContents, string fileLocation)
        {
            FileStream stream = new FileStream(fileLocation, FileMode.Create);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}