using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Bookstore.Data;


namespace Simple_Books_Importer
{
    class SimpleBooksImporter
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../simple-books.xml");
            string xPathQuery = "/catalog/book";

            XmlNodeList booksList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode bookNode in booksList)
                {
                    string author = bookNode.SelectSingleNode("author").InnerText;
                    //Console.WriteLine(username);
                    string title = bookNode.SelectSingleNode("title").InnerText;
                    //Console.WriteLine(title);
                    var isbnExsist = bookNode.SelectSingleNode("isbn");

                    string isbn = null;
                    if (isbnExsist != null)
                    {
                        isbn = isbnExsist.InnerText;
                    }
                    //Console.WriteLine(url);

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
                    //ISBN, price and web site are optional while author and title are obligatory
                    //Console.WriteLine("{0}-{1}-{2}-{3}-{4}", isbn, price, site, author, title);

                    BookstoreDAL.AddBook(isbn, price, site, author, title);
                }
        }
    }
}
