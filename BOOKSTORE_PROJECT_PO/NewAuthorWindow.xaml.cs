using System;
using System.Windows;
using BOOKSTORE_PROJECT_PO.Dals;
using BOOKSTORE_PROJECT_PO.Validators;

namespace BOOKSTORE_PROJECT_PO
{
    /// <summary>
    /// Logika interakcji dla klasy NewAuthorWindow.xaml
    /// </summary>
    public partial class NewAuthorWindow : Window
    {
        AuthorDal authorDal = new AuthorDal();
        AuthorValidator authorValidator = new AuthorValidator();

        public NewAuthorWindow()
        {
            InitializeComponent();
            LoadAuthorData();
        }

        private void LoadAuthorData() => this.gridAuthors.ItemsSource = authorDal.getAuthorNameList;

        private void BtnBackToMainWindow(object sender, RoutedEventArgs e) => this.Close();

        private void clearInput()
        {
            this.authorName.Text = "";
            this.authorLastName.Text = "";
        }

        private void BtnAddAuthor(object sender, RoutedEventArgs e)
        {
            var validateResult = authorValidator.Validate(authorName.Text, authorLastName.Text);
            if (!validateResult.IsCorrect)
            {
                MessageBox.Show($"Validaton error: { validateResult.ErrorMessage}");
                return;
            }

            try
            {
                if (authorName.Text.Length == 0 || authorLastName.Text.Length == 0) 
                    throw new Exception("Fields can not be empty");

                authorDal.Add(
                    authorName.Text,
                    authorLastName.Text
                    );
            }
            catch (Exception err) 
            {
                MessageBox.Show($"Error: {err.Message}");
            }

            LoadAuthorData();
            clearInput();
        }
    }
}
