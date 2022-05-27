using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewCityWindow.xaml
    /// </summary>
    public partial class NewCityWindow : Window
    {
        CityDal cityDal = new CityDal();

        public NewCityWindow()
        {
            InitializeComponent();
            LoadCityData();
        }

        public void LoadCityData() => gridCities.ItemsSource = cityDal.getCityNameList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void BtnAddNewCity(object sender, RoutedEventArgs e)
        {
            cityDal.Add(cityInput.Text);
            LoadCityData();
        }
    }
}
