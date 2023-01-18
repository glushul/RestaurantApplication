using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestaurantApp.UI.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = "";
            if (passwordCheckBox.IsChecked == true)
                password = passwordTextBox.Text;
            if (passwordCheckBox.IsChecked == false)
                password = passwordPasswordBox.Password;
            // Проверка введеных логина и пароля
            if (loginTextBox.Text == "admin" && password == "admin")
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow("admin");
                mainWindow.Show();
            }
            else if (loginTextBox.Text == "user" && password == "user")
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow("user");
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Пароль и логин введены неправильно!",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void passwordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Visibility = Visibility.Hidden;
            passwordPasswordBox.Password = passwordTextBox.Text;
            passwordPasswordBox.Visibility = Visibility.Visible;
        }

        private void passwordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordPasswordBox.Visibility = Visibility.Hidden;
            passwordTextBox.Text = passwordPasswordBox.Password;
            passwordTextBox.Visibility = Visibility.Visible;
        }
    }
}
