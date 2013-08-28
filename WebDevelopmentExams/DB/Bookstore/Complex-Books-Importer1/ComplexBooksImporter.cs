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
                    foreach (XmlNode author in bookNode.SelectNodes("authors"))
                    {
                        foreach (XmlNode item in author.SelectNodes("author"))
                        {
                            authors.Add(item.InnerXml.Trim());
                        }
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

                List<Review> reviewsList = new List<Review>();
                if (reviewsExsist != null)
                {
                    foreach (XmlNode reviews in bookNode.SelectNodes("reviews"))
                    {
                        foreach (XmlNode review in reviews.SelectNodes("review"))
                        {
                            DateTime date = DateTime.Now;
                            int? authorId = null;

                            var text = review.InnerText;
                            var dateExsict = review.Attributes["date"];
                            var authorExsict = review.Attributes["author"];

                            if (dateExsict != null)
                            {
                                date = Convert.ToDateTime(dateExsict.Value);
                            }

                            if (authorExsict != null)
                            {
                                string author = authorExsict.Value;
                                authorId = BookstoreDAL.GetAuthorId(author);
                                //if (authorId == 0)
                                //{
                                //    throw new Exception();
                                //}
                            }

                            Review curReview = new Review();
                            curReview.DateOfCreation = date;
                            curReview.AuthorId = authorId;
                            curReview.ReviewText = text;
                            reviewsList.Add(curReview);
                        }
                    }
                }
                //ISBN, price and web site are optional while author and title are obligatory
                //Console.WriteLine("{0}-{1}-{2}-{3}-{4}", isbn, price, site, author, title);

                BookstoreDAL.AddBookComplex(title, authors, isbn, price, site, reviewsList);
            }
        }
    }
}
