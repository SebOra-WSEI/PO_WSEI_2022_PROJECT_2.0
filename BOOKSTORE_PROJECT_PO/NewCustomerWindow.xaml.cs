using BOOKSTORE_PROJECT_PO.Models;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewCustomerWindow.xaml
    /// </summary>
    public partial class NewCustomerWindow : Window
    {
        CityDal cityDal = new CityDal();
        public NewCustomerWindow()
        {
            InitializeComponent();
            comboBoxData.ItemsSource = cityDal.getCityList();
        }

        private void BtnAddNewCustomer(object sender, RoutedEventArgs e)
        {
            cityDal.Add(firstName.Text, lastName.Text, email.Text, int.Parse(comboBoxData.SelectedValue.ToString()));
            this.Close();
        }
    }
}
