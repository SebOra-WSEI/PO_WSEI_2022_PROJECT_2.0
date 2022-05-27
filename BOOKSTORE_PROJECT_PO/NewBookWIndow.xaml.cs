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

        public NewBookWIndow()
        {
            InitializeComponent();
            LoadSelectorCityData();
            LoadSelectorAuthorData();
            LoadSelectorStatusData();
        }

        private void LoadSelectorCityData() => comboBoxCity.ItemsSource = cityDal.getCityList;

        private void LoadSelectorAuthorData() => comboBoxAuthor.ItemsSource = authorDal.getAuthorList;

        private void LoadSelectorStatusData() => comboBoxStatus.ItemsSource = statusDal.getStatusList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void BtnAddNewBook(object sender, RoutedEventArgs e)
        {

        }
    }
}
