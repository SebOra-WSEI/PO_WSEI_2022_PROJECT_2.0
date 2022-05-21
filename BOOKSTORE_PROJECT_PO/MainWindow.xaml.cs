using BOOKSTORE_PROJECT_PO.Models;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BookstoreDBEntities db = new BookstoreDBEntities();

            var booksQuery =
                from books in db.Books
                join author in db.Authors on books.AuthorId equals author.ID
                join status in db.Status on books.StatusId equals status.ID
                join customer in db.Customers on books.CustomerId equals customer.ID
                select new
                {
                    Title = books.Title,
                    Author = author.FirstName,
                    PublishedYear = books.PublishedYear.Year,
                    Status = status.StatusName,
                    LastCustomer = customer.FirstName
                };

            var authorsQuery =
                from author in db.Authors
                select new
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName
                };

            var statusQuery =
                from status in db.Status
                select status.StatusName;

            var citiesQuery =
                from city in db.Cities
                select city.CityName;
        }

        private void BtnAddCustomer(object sender, RoutedEventArgs e)
        {
            BookstoreDBEntities db = new BookstoreDBEntities();

            var newCustomer = new Customers()
            {
                FirstName = "testName",
                LastName = "testLast",
                Email = "test@gmail.com",
                OrderQuantity = 1,
                CityId = 1
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }

        private void BtnLoadCustomers(object sender, RoutedEventArgs e)
        {
            BookstoreDBEntities db = new BookstoreDBEntities();

            var customersQuery =
               from customers in db.Customers
               join city in db.Cities on customers.CityId equals city.ID
               select new
               {
                   FirstName = customers.FirstName,
                   LastName = customers.LastName,
                   Email = customers.Email,
                   City = city.CityName
               };

            this.gridCustomer.ItemsSource = customersQuery.ToList();
        }
    }
}