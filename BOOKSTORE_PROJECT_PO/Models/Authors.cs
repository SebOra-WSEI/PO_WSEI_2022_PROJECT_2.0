namespace BOOKSTORE_PROJECT_PO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authors
    {
        public Authors()
        {
            this.Books = new HashSet<Books>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<Books> Books { get; set; }
    }
}
