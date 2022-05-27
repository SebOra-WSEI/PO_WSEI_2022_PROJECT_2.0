using BOOKSTORE_PROJECT_PO.Dals;
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

        public NewBookWIndow()
        {
            InitializeComponent();
            LoadSelectorCityData();
            LoadSelectorAuthorData();
            LoadSelectorStatusData();
            LoadSelectorCustomerData();
        }

        private void LoadSelectorCityData() => comboBoxCity.ItemsSource = cityDal.getCityList;

        private void LoadSelectorAuthorData() => comboBoxAuthor.ItemsSource = authorDal.getAuthorList;

        private void LoadSelectorStatusData() => comboBoxStatus.ItemsSource = statusDal.getStatusList;

        private void LoadSelectorCustomerData() => comboBoxCustomer.ItemsSource = customerDal.getCustomerForSelecorList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void BtnAddNewBook(object sender, RoutedEventArgs e)
        {

        }
    }
}
