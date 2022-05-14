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
            BookstoreDBEntitiess db = new BookstoreDBEntitiess();

            var authors = from _author in db.Authors
                          select _author;

            var books = from _books in db.Books
                        select _books;

            var city = from _city in db.City
                       select _city;

            var customers = from _customer in db.Books
                            select _customer;

            var status = from _status in db.Status
                         select _status;

            // Checking if queries work
            Console.WriteLine($"Authors: {authors}");
            Console.WriteLine($"Books: {books}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Customers: {customers}");
            Console.WriteLine($"Status: {status}");
        }
    }
}
