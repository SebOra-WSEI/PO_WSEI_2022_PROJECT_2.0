using BOOKSTORE_PROJECT_PO.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOOKSTORE_PROJECT_PO
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    internal class CityDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();
        public IList<City> getCityList()
        {

           return  db.Cities.Select(cty => new City { ID = cty.ID, Name = cty.CityName }).ToList();
        }

        internal void Add(string firstName, string lastName, string email, int cityId)
        {
            var newCustomer = new Customers()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                CityId = cityId,
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }
    }
}
