using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Bookstore.Data;

namespace Complex_Books_Importer
{
    public class ComplexBooksImporter
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../complex-books.xml");
            string xPathQuery = "/catalog/book";

            XmlNodeList booksList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode bookNode in booksList)
            {
                string title = bookNode.SelectSingleNode("title").InnerText;

                var authorsExsist = bookNode.SelectSingleNode("authors");

                List<string> authors = new List<string>();
                if (authorsExsist != null)
                {
                    foreach (var author in authorsExsist)
                    {
                        var curAuthor = bookNode.SelectSingleNode("author").InnerText;
                        authors.Add(curAuthor);
                    }
                }

                var isbnExsist = bookNode.SelectSingleNode("isbn");

                string isbn = null;
                if (isbnExsist != null)
                {
                    isbn = isbnExsist.InnerText;
                }

                var priceExsist = bookNode.SelectSingleNode("price");

                string price = null;
                if (priceExsist != null)
                {
                    price = priceExsist.InnerText;
                }

                var siteExsist = bookNode.SelectSingleNode("web-site");

                string site = null;
                if (siteExsist != null)
                {
                    site = siteExsist.InnerText;
                }

                var reviewsExsist = bookNode.SelectSingleNode("reviews");

                //List<Review> reviews = new List<Review>();
                //if (reviewsExsist != null)
                //{
                //    foreach (var review in reviewsExsist)
                //    {
                    
                //        var curAuthor = bookNode.SelectSingleNode("author").InnerText;
                //        authors.Add(curAuthor);
                //    }
                //}
                //ISBN, price and web site are optional while author and title are obligatory
                //Console.WriteLine("{0}-{1}-{2}-{3}-{4}", isbn, price, site, author, title);

                //  BookstoreDAL.AddBook(isbn, price, site, author, title);
            }
        }
    }
}
