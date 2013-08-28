using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace _10.SQLiteBookTrader
{
    class Program
    {
        static SQLiteConnection myCon = new SQLiteConnection(@"Data Source=example.db;Version=3;");

        static void Main(string[] args)
        {
            //ListAll();
            //SearchByName("Movies");
            //AddBook("New");
        }

        static void AddBook(string name)
        {
            myCon.Open();
            string query = "INSERT INTO Playlist (Name) VALUES(@name)";

            SQLiteCommand myCommand = new SQLiteCommand(query, myCon);
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.ExecuteNonQuery();
            Console.WriteLine("Added");

            myCon.Close();
        }

        public static void ListAll()
        {
            myCon.Open();
            string query = "SELECT * FROM Playlist";

            SQLiteCommand myCommand = new SQLiteCommand(query, myCon);
            var reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} | {1}", reader["PlaylistId"], reader["Name"]);
            }

            myCon.Close();
        }

        static void SearchByName(string name)
        {
            myCon.Open();
            string query = "SELECT * FROM Playlist WHERE Name = @name";

            SQLiteCommand myCommand = new SQLiteCommand(query, myCon);
            myCommand.Parameters.AddWithValue("@name", name);
            var reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} | {1}", reader["PlaylistId"], reader["Name"]);
            }

            myCon.Close();
        }
    }
}
