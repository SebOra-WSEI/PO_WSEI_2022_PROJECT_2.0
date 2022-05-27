using BOOKSTORE_PROJECT_PO.Dals;
using System;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewBookWIndow.xaml
    /// </summary>
    public partial class NewBookWIndow : Window
    {
        CityDal cityDal = new CityDal();
        AuthorDal authorDal = new AuthorDal();
        StatusDal statusDal = new StatusDal();
        CustomerDal customerDal = new CustomerDal();
        BooksDal bookDal = new BooksDal();

        public NewBookWIndow()
        {
            InitializeComponent();
            LoadSelectorAuthorData();
            LoadSelectorStatusData();
            LoadSelectorCustomerData();
            LoadBooksData();
        }

        private void LoadSelectorAuthorData() => comboBoxAuthor.ItemsSource = authorDal.getAuthorList;

        private void LoadSelectorStatusData() => comboBoxStatus.ItemsSource = statusDal.getStatusList;

        private void LoadSelectorCustomerData() => comboBoxCustomer.ItemsSource = customerDal.getCustomerForSelecorList;

        private void LoadBooksData() => gridBooks.ItemsSource = bookDal.getBooksList;

        private void BtnAddNewBook(object sender, RoutedEventArgs e)
        {
            try
            {
                bookDal.Add(
                    title.Text,
                    datePicker.SelectedDate.Value.Date,
                    int.Parse(comboBoxQuantity.SelectedValue.ToString()),
                    int.Parse(comboBoxAuthor.SelectedValue.ToString()),
                    int.Parse(comboBoxStatus.SelectedValue.ToString()),
                    int.Parse(comboBoxCustomer.SelectedValue.ToString())
                    );
            }
            catch (Exception) { new ErrorWindow().Show(); }

            LoadBooksData();
        }

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();
    }
}
