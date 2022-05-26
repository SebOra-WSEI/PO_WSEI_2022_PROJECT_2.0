using BOOKSTORE_PROJECT_PO.Dal_Models;
using BOOKSTORE_PROJECT_PO.Models;
using System.Collections.Generic;
using System.Linq;

namespace BOOKSTORE_PROJECT_PO.Dals
{
    internal class AuthorDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();
        public IList<AuthorDalModel> getAuthorList =>
            db.Authors.Select(author => new AuthorDalModel { Author = author.FirstName + " " + author.LastName }).ToList();

        public void Add(string firstName, string lastName)
        {
            var newAuthor = new Authors()
            {
                FirstName = firstName,
                LastName = lastName
            };

            db.Authors.Add(newAuthor);
            db.SaveChanges();
        }
    }
}
