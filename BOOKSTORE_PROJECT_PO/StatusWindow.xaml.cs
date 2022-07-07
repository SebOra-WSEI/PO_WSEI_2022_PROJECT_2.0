using BOOKSTORE_PROJECT_PO.Dals;
using System.Windows;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        StatusDal statusDal = new StatusDal();
        public StatusWindow()
        {
            InitializeComponent();

            gridStatus.ItemsSource = statusDal.getCStatusList;
        }

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();
    }
}
