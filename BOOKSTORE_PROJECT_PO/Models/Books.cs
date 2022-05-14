namespace BOOKSTORE_PROJECT_PO.Models
{
    using System;
    
    public partial class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public System.DateTime PublishedYear { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Status Status { get; set; }
    }
}
