namespace BOOKSTORE_PROJECT_PO.Models
{
    using System.Collections.Generic;
    
    public partial class Status
    {
        public Status()
        {
            this.Books = new HashSet<Books>();
        }
    
        public int ID { get; set; }
        public string StatusName { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
    }
}
