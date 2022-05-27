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
                    Status = book.StatusId,
                    LastCustomer = book.CustomerId
                }).ToList();
    }
}
