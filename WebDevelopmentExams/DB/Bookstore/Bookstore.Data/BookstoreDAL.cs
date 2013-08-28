using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Bookstore.Data
{
    public class BookstoreDAL
    {
        public static ICollection<Review> SearchByAuthorName(string authorName)
        {
            BookstoreDBEntities context = new BookstoreDBEntities();

            var booksQuery =
                (from r in context.Reviews.Include("Books")
                 select r);

            booksQuery = booksQuery.Where(
                    x => x.Author.Name.ToLower() == authorName.ToLower());
            booksQuery = booksQuery.OrderBy(x => x.DateOfCreation).OrderBy(x => x.ReviewText);

            return booksQuery.ToList();
        }

        public static void AddBook(string isbn, string price, string site, string author, string title)
        {
            TransactionScope tran = new TransactionScope();
            using (tran)
            {
                BookstoreDBEntities context = new BookstoreDBEntities();
                Book newBook = new Book();

                newBook.ISBN = isbn;
                if (price != null)
                {
                    newBook.Price = decimal.Parse(price);
                }
                newBook.WebSite = site;
                newBook.Title = title;
                newBook.Authors.Add(CreateOrLoadAuthor(context, author));

                context.Books.Add(newBook);
                context.SaveChanges();
                tran.Complete();
            }
        }

        public static int GetAuthorId(string author)
        {
            BookstoreDBEntities context = new BookstoreDBEntities();

            int authorId =
               (from a in context.Authors
                where a.Name.ToLower() == author.ToLower()
                select a.AuthorId).FirstOrDefault();

            return authorId;
        }

        public static void AddBookComplex(string title, List<string> authors, string isbn, string price, string site, List<Review> reviewsList)
        {
            TransactionScope tran = new TransactionScope();
            using (tran)
            {
                BookstoreDBEntities context = new BookstoreDBEntities();
                Book curBook = new Book();
                curBook.Title = title;

                if (authors.Count > 0)
                {
                    foreach (var author in authors)
                    {
                        curBook.Authors.Add(CreateOrLoadAuthor(context, author));
                    }
                }

                curBook.ISBN = isbn;
                curBook.Price = Convert.ToDecimal(price);
                curBook.WebSite = site;

                if (reviewsList.Count > 0)
                {
                    foreach (var review in reviewsList)
                    {
                        curBook.Reviews.Add(review);
                    }
                }

                context.Books.Add(curBook);
                context.SaveChanges();
                tran.Complete();
            }
        }

        public static ICollection<Book> FindBook(string title, string author, string isbn)
        {
            BookstoreDBEntities context = new BookstoreDBEntities();

            var booksQuery =
                from b in context.Books.Include("Reviews")
                select b;

            if (title != null)
            {
                booksQuery =
                    from b in context.Books
                    where b.Title.ToLower() == title.ToLower()
                    select b;
            }
            if (author != null)
            {
                booksQuery = booksQuery.Where(
                    b => b.Authors.Any(n => n.Name == author));
            }
            if (isbn != null)
            {
                booksQuery = booksQuery.Where(
                    b => b.ISBN == isbn);
            }
            booksQuery = booksQuery.OrderBy(b => b.Title);

            return booksQuery.ToList();
        }

        private static Author CreateOrLoadAuthor(
    BookstoreDBEntities context, string authorName)
        {
            Author existingAuthor =
                (from a in context.Authors
                 where a.Name.ToLower() == authorName.ToLower()
                 select a).FirstOrDefault();
            if (existingAuthor != null)
            {
                return existingAuthor;
            }

            Author newAuthor = new Author();
            newAuthor.Name = authorName;
            context.Authors.Add(newAuthor);
            context.SaveChanges();

            return newAuthor;
        }

        public static ICollection<Review> SearchByDate(DateTime startDate, DateTime endDate)
        {
            BookstoreDBEntities context = new BookstoreDBEntities();

            var booksQuery =
                (from r in context.Reviews.Include("Books")
                 select r);

            booksQuery = booksQuery.Where(
                    x => x.DateOfCreation >= startDate && x.DateOfCreation <= endDate);
            booksQuery = booksQuery.OrderBy(x => x.DateOfCreation).OrderBy(x => x.ReviewText);


            return booksQuery.ToList();
        }
    }
}