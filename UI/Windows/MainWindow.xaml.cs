using RestaurantApp.UI.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string user = "";
        public MainWindow(string user)
        {
            InitializeComponent();
            // Во фрейме показывает страницу меню
            mainFrame.Content = new UI.Pages.MenuPage();
            this.user = user;
            // Добавляет к кнопке логин
            accountButton.Content += user;
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.MenuPage();
        }

        private void aboutRestaurantButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.MainPage();
        }

        private void getContactButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.GetContactPage();
        }

        private void deliveryButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.DeliveryPage();
        }

        private void photoGalleryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Страница в стадии разработки", "Info", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void accountButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow(user);
            userWindow.Show();
        }
    }
}
