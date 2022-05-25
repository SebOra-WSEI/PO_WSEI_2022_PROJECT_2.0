using BOOKSTORE_PROJECT_PO.Dals;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        CityDal cityDal = new CityDal();
        CustomerDal customerDal = new CustomerDal();
        public NewCustomerWindow()
        {
            InitializeComponent();

            gridCustomer.ItemsSource = customerDal.getCustomerList;
            comboBoxData.ItemsSource = cityDal.getCityList;
        }

        // Add a new customer 
        private void BtnAddNewCustomer(object sender, RoutedEventArgs e)
        {
            customerDal.Add(firstName.Text, lastName.Text, email.Text, int.Parse(comboBoxData.SelectedValue.ToString()));
            this.Close();
        }

        // Back btn - close customer's window
        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();
    }
}
