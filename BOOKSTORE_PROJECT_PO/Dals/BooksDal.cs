using BOOKSTORE_PROJECT_PO.Dal_Models;
using BOOKSTORE_PROJECT_PO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKSTORE_PROJECT_PO.Dals
{
    internal class BooksDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();

        public List<BookDalModel> getBooksList =>
            db.Books.Select(
                book => new BookDalModel
                {
                    Title = book.Title,
                    PublishedYear = book.PublishedYear,
                    Author = book.AuthorId,
                    Quantity = book.Quantity,
                    Status = book.StatusId,
                    LastCustomer = book.CustomerId
                }).ToList();

        public void Add(string title, DateTime date, int qtl, int authorId, int statusId, int lastCustomerId)
        {
            var newBook = new Books()
            {
                Title = title,
                PublishedYear = date,
                AuthorId = authorId,
                StatusId = statusId,
                CustomerId = lastCustomerId,
                Quantity = qtl,
            };

            db.Books.Add(newBook);
            db.SaveChanges();
        }
    }
}
