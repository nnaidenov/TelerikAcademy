using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySQLBookTrader
{
    class Program
    {
        static MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=bookTrader;Uid=root;Pwd=l3vskar437o;");

        static void Main(string[] args)
        {
            AddBook("Fghsd", "Unknown", DateTime.Now, "8521-525-89648-25-563");
            ListAllBooks();
            Console.WriteLine();
            SearchByTitle("Fghsd");
        }

        static void AddBook(string title, string author, DateTime publishDate, string isbn)
        { 
            MySqlCommand myCom = new MySqlCommand("INSERT INTO BOOKS (Title, Author, PublishDate, ISBN)" + 
                "VALUES(@title, @author, @publishDate, @isbn)", con);
            con.Open();
            myCom.Parameters.AddWithValue("@title", title);
            myCom.Parameters.AddWithValue("@author", author);
            myCom.Parameters.AddWithValue("@publishDate", publishDate);
            myCom.Parameters.AddWithValue("@isbn", isbn);
            myCom.ExecuteNonQuery();
            con.Close();
        }

        static void ListAllBooks()
        {
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM BOOKS", con);
            con.Open();
            var reader = myCom.ExecuteReader();

            while (reader.Read())
            {
                string title = (string)reader["title"];
                string author = (string)reader["author"];
                DateTime publishDate = (DateTime)reader["publishDate"];
                string isbn = (string)reader["isbn"];
                Console.WriteLine("{0} | {1} | {2} | {3}", title, author, publishDate, isbn);
            }

            con.Close();
        }

        static void SearchByTitle(string bookTitle)
        {
            MySqlCommand myCom = new MySqlCommand("SELECT * FROM BOOKS WHERE Title = @title", con);
            myCom.Parameters.AddWithValue("@title", bookTitle);
            con.Open();
            var reader = myCom.ExecuteReader();

            while (reader.Read())
            {
                string title = (string)reader["title"];
                string author = (string)reader["author"];
                DateTime publishDate = (DateTime)reader["publishDate"];
                string isbn = (string)reader["isbn"];
                Console.WriteLine("{0} | {1} | {2} | {3}", title, author, publishDate, isbn);
            }

            con.Close();
        }
    }
}
