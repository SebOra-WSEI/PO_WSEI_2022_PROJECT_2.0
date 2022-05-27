using System.Windows;
using BOOKSTORE_PROJECT_PO.Dals;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewAuthorWindow.xaml
    /// </summary>
    public partial class NewAuthorWindow : Window
    {
        AuthorDal authorDal = new AuthorDal();

        public NewAuthorWindow()
        {
            InitializeComponent();
            LoadAuthorData();
        }

        private void LoadAuthorData() => gridAuthors.ItemsSource = authorDal.getAuthorList;

        private void BtnAddAuthor(object sender, RoutedEventArgs e)
        {
            authorDal.Add(authorName.Text, authorLastName.Text);
            LoadAuthorData();
        }

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();
    }
}
