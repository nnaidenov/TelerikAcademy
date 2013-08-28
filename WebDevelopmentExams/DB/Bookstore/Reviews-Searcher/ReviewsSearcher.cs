using Bookstore.Data;
using Logs.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;

namespace Reviews_Searcher
{
    static class ReviewsSearcher
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../reviews-queries.xml");

            List<List<Review>> allReslts = new List<List<Review>>();
            foreach (XmlNode query in xmlDoc.SelectNodes("/review-queries/query"))
            {
                LogsMaker.AddLog(query.OuterXml);

                string searchType = query.Attributes["type"].Value;

                if (searchType == "by-period")
                {
                    DateTime startDate = Convert.ToDateTime(query.SelectSingleNode("start-date").InnerXml);
                    DateTime endDate = Convert.ToDateTime(query.SelectSingleNode("end-date").InnerXml);

                    var result = BookstoreDAL.SearchByDate(startDate, endDate);

                    allReslts.Add(result.ToList());

                }
                else if (searchType == "by-author")
                {
                    string authorName = query.SelectSingleNode("author-name").InnerXml;

                    var result = BookstoreDAL.SearchByAuthorName(authorName);
                    allReslts.Add(result.ToList());
                }
            }

            WriteXMLDocument(allReslts);
        }

        private static void WriteXMLDocument(List<List<Review>> allResults)
        {
            string fileName = "../../reviews-search-results.xml";
            Encoding encoding = Encoding.GetEncoding("UTF-8");


            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();

                writer.WriteStartElement("search-results");

                foreach (var results in allResults)
                {
                    writer.WriteStartElement("result-set");
                    var orderedResult = (from e in results
                                         orderby e.DateOfCreation
                                         select e).ToList();

                    WriteBookInXML(orderedResult, writer);
                    writer.WriteEndElement();
                }
                writer.WriteEndDocument();
            }
        }

        private static void WriteBookInXML(ICollection<Review> result, XmlTextWriter writer)
        {
            if (result.Count > 0)
            {
                CultureInfo ci = new CultureInfo("en-US");

                foreach (var review in result)
                {
                    writer.WriteStartElement("review");

                    var date = review.DateOfCreation;
                    if (date != null)
                    {
                        writer.WriteElementString("date", date.ToString("d-MMM-yyyy", ci));
                    }

                    var text = review.ReviewText;
                    if (text != null)
                    {
                        writer.WriteElementString("content", text);
                    }

                    foreach (var book in review.Books)
                    {
                        writer.WriteStartElement("book");

                        var title = book.Title;
                        if (title != null)
                        {
                            writer.WriteElementString("title", title);
                        }

                        var authors = book.Authors;
                        if (authors.Count > 0)
                        {
                            List<string> allAuthors = new List<string>();
                            foreach (var author in authors)
                            {
                                allAuthors.Add(author.Name);
                            }
                            allAuthors.Sort();
                            var finalAuthors = string.Join(", ", allAuthors);
                            writer.WriteElementString("authors", finalAuthors);
                        }

                        var isbn = book.ISBN;
                        if (isbn != null)
                        {
                            writer.WriteElementString("isbn", isbn);
                        }

                        var url = book.WebSite;
                        if (url != null)
                        {
                            writer.WriteElementString("url", url);
                        }
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
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