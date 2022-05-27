using BOOKSTORE_PROJECT_PO.Dals;
using System;
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

            LoadCustomerData();
            LoadSelectorData();
        }

        private void LoadCustomerData() => gridCustomer.ItemsSource = customerDal.getCustomerList;
        private void LoadSelectorData() => comboBoxData.ItemsSource = cityDal.getCityList;

        private void BtnAddNewCustomer(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstName.Text.Length == 0 ||lastName.Text.Length == 0 || email.Text.Length == 0) 
                    throw new Exception();

                customerDal.Add(
                    firstName.Text,
                    lastName.Text,
                    email.Text,
                    int.Parse(comboBoxData.SelectedValue.ToString())
                    );
            }
            catch (Exception) { new ErrorWindow().Show(); }

            LoadCustomerData();
        }

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();
    }
}