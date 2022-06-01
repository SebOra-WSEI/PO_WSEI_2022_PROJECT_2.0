using BOOKSTORE_PROJECT_PO.Dal_Models;
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

        private void LoadCustomerData() => this.gridCustomer.ItemsSource = customerDal.getCustomerList;

        private void LoadSelectorData() => this.comboBoxData.ItemsSource = cityDal.getCityList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void clearInput()
        {
            this.firstName.Text = "";
            this.lastName.Text = "";
            this.email.Text = "";

            this.nameUpdate.Text = "";
            this.emailUpdate.Text = "";
        }

        private void BtnAddNewCustomer(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || email.Text.Length == 0)
                    throw new Exception("Fields can not be empty");

                customerDal.Add(
                    firstName.Text,
                    lastName.Text,
                    email.Text,
                    int.Parse(comboBoxData.SelectedValue.ToString())
                    );
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: { err.Message}");
            }

            LoadCustomerData();
            clearInput();
        }

        protected string customerEmail;
        private void gridCustomer_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (this.gridCustomer.SelectedIndex >= 0)
            {
                try
                {
                    if (this.gridCustomer.SelectedItems.Count >= 0)
                    {
                        var customer = (CustomerDalModel)this.gridCustomer.SelectedItems[0];

                        customerEmail = customer.Email;

                        this.nameUpdate.Text = customer.Name;
                        this.emailUpdate.Text = customer.Email;
                        this.comboBoxCityUpdate.ItemsSource = cityDal.getCityList;
                        this.comboBoxCityUpdate.SelectedValue = cityDal.GetCityID(customer.City);
                    }
                }
                catch (InvalidCastException) { }
            }
        }

        private void BtnAddUpdateCustomer(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nameUpdate.Text.Length == 0 || emailUpdate.Text.Length == 0)
                    throw new Exception("Fields can not be empty");

                string newEmail = emailUpdate.Text;
                int newCityId = int.Parse(comboBoxCityUpdate.SelectedValue.ToString());

                customerDal.Update(customerEmail, newEmail, newCityId);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: { err.Message}");
            }

            LoadCustomerData();
            clearInput();
        }
    }
}