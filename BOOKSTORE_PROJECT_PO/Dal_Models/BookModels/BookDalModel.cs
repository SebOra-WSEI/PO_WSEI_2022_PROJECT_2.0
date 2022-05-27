using System;

namespace BOOKSTORE_PROJECT_PO.Dal_Models
{
    internal class BookDalModel
    {
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public int Author { get; set; }
        public int Status { get; set; }
        public int LastCustomer { get; set; }
    }
}
