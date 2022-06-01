using System;
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

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void LoadCityData() => this.gridCities.ItemsSource = cityDal.getCityNameList;

        private void clearInput() => this.cityInput.Text = "";

        private void BtnAddNewCity(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (this.cityInput.Text.Length == 0) 
                    throw new Exception("Fields can not be empty");

                cityDal.Add(cityInput.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}");
            }

            LoadCityData();
            clearInput();
        }
    }
}
