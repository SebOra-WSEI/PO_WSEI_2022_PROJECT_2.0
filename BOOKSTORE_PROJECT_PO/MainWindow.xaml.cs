using BOOKSTORE_PROJECT_PO.Dals;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerDal customerDal = new CustomerDal();
        public MainWindow(){ 
            InitializeComponent();

            gridCustomer1.ItemsSource = customerDal.getCustomerList;
        }

        // Display New Customer form and all customers table
        private void BtnNewCustomerWindow(object sender, RoutedEventArgs e)
        { 
            var customersWindow = new NewCustomerWindow();
            customersWindow.Show();
        }

        // Load customer's data
        private void BtnLoadCustomers(object sender, RoutedEventArgs e) => 
            gridCustomer1.ItemsSource = customerDal.getCustomerList;
    }
}



















//var booksQuery =
//    from books in db.Books
//    join author in db.Authors on books.AuthorId equals author.ID
//    join status in db.Status on books.StatusId equals status.ID
//    join customer in db.Customers on books.CustomerId equals customer.ID
//    select new
//    {
//        Title = books.Title,
//        Author = author.FirstName,
//        PublishedYear = books.PublishedYear.Year,
//        Status = status.StatusName,
//        LastCustomer = customer.FirstName
//    };

//var authorsQuery =
//    from author in db.Authors
//    select new
//    {
//        FirstName = author.FirstName,
//        LastName = author.LastName
//    };

//var statusQuery =
//    from status in db.Status
//    select status.StatusName;

//var citiesQuery =
//    from city in db.Cities
//    select city.CityName;