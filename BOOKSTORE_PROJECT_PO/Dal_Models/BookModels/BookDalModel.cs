﻿using System;

namespace BOOKSTORE_PROJECT_PO.Dal_Models
{
    internal class BookDalModel
    {
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string LastCustomer { get; set; }
    }
}
