namespace BOOKSTORE_PROJECT_PO.Models
{   
    public partial class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public System.DateTime PublishedYear { get; set; }
        public int Quantity { get; set; }
        public int AuthorId { get; set; }
        public int StatusId { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Status Status { get; set; }
    }
}
