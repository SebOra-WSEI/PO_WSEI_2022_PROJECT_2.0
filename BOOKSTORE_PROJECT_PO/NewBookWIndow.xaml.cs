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

        private void LoadSelectorAuthorData() => this.comboBoxAuthor.ItemsSource = authorDal.getAuthorList;

        private void LoadSelectorStatusData() => this.comboBoxStatus.ItemsSource = statusDal.getStatusList;

        private void LoadSelectorCustomerData() => this.comboBoxCustomer.ItemsSource = customerDal.getCustomerForSelecorList;

        private void LoadBooksData() => this.gridBooks.ItemsSource = bookDal.getBooksList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void clearInput() => this.title.Text = "";

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
            catch (Exception) 
            {
                MessageBox.Show("Error: Fields can not be empty");
            }

            LoadBooksData();
            clearInput();
        }
    }
}
