﻿using System;
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

        private void LoadCityData() => gridCities.ItemsSource = cityDal.getCityNameList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void BtnAddNewCity(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (cityInput.Text.Length == 0) 
                    throw new Exception("Fields can not be empty");

                cityDal.Add(cityInput.Text); 
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}");
            }

            LoadCityData();
        }
    }
}
