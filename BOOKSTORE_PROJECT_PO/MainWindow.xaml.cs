using BOOKSTORE_PROJECT_PO.Dals;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksDal bookDal = new BooksDal();

        public MainWindow() 
        { 
            InitializeComponent();
            LoadBooksData();
        }

        private void BtnNewCustomerWindow(object sender, RoutedEventArgs e) => new NewCustomerWindow().Show();

        private void BtnNewBookWindow(object sender, RoutedEventArgs e) => new NewBookWIndow().Show();

        private void BtnNewCityWindow(object sender, RoutedEventArgs e) => new NewCityWindow().Show();

        private void BtnNewAuthorWindow(object sender, RoutedEventArgs e) => new NewAuthorWindow().Show();

        private void BtnStatusWindow(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLoadData(object sender, RoutedEventArgs e) => LoadBooksData();

        private void LoadBooksData() => this.gridBooks.ItemsSource = bookDal.getBooksList;
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
