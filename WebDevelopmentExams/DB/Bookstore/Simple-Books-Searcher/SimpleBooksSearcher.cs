using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Bookstore.Data;
using Logs.Client;

namespace Simple_Books_Searcher
{
    static class SimpleBooksSearcher
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../simple-query.xml");
            string xPathQuery = "/query";

            XmlNodeList bookList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode bookNode in bookList)
            {
                LogsMaker.AddLog(bookNode.OuterXml);

                var title = bookNode.GetChildText("title");
                var author = bookNode.GetChildText("author");
                var isbn = bookNode.GetChildText("isbn");

                var books = BookstoreDAL.FindBook(title, author, isbn);

                int numberOfBooks = books.Count;
                if (numberOfBooks > 0)
                {
                    if (numberOfBooks == 1)
                    {
                        Console.WriteLine("1 book found:");
                    }
                    else
                    {
                        Console.WriteLine("{0} books found:", numberOfBooks);
                    }
                    foreach (var book in books)
                    {
                        int numberOfReviews = book.Reviews.Count;
                        if (numberOfReviews == 0)
                        {
                            Console.WriteLine("{0} --> no reviews", book.Title);
                        }
                        else if (numberOfReviews == 1)
                        {
                            Console.WriteLine("{0} --> 1 review", book.Title);
                        }
                        else
                        {
                            Console.WriteLine("{0} --> {1} reviews", book.Title, numberOfReviews);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found");
                }
            }
        }

        private static string GetChildText(this XmlNode node, string tagName)
        {
            XmlNode childNode = node.SelectSingleNode(tagName);
            if (childNode == null)
            {
                return null;
            }
            return childNode.InnerText.Trim();
        }
    }
}