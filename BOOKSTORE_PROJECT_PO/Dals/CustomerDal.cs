using BOOKSTORE_PROJECT_PO.Dal_Models;
using BOOKSTORE_PROJECT_PO.Dal_Models.CustomerModels;
using BOOKSTORE_PROJECT_PO.Models;
using System.Collections.Generic;
using System.Linq;

namespace BOOKSTORE_PROJECT_PO.Dals
{
    internal class CustomerDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();

        public IList<CustomerDalModel> getCustomerList => 
            db.Customers.Select(
                customer => new CustomerDalModel
                {
                    Name = customer.FirstName + " " + customer.LastName,
                    Email = customer.Email,
                    City = customer.Cities.CityName
                }).ToList();

        public IList<CustomerDalModelForSelector> getCustomerForSelecorList =>
            db.Customers.Select(
                customer => new CustomerDalModelForSelector
                {
                    ID = customer.ID,
                    Name = customer.FirstName + " " + customer.LastName,
                }).ToList();

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

        internal void Update(string email, string emailToUpdate, int cityId)
        {
            var customerToUpdate = (
                from customer in db.Customers where customer.Email == email select customer
                ).FirstOrDefault();

            if (customerToUpdate != null)
            {
                customerToUpdate.Email = emailToUpdate;
                customerToUpdate.CityId = cityId;
            }

            db.SaveChanges();
        }
    }
}