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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow(string user)
        {
            InitializeComponent();
            userTextBlock.Text += " " + user;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
            for (int intCounter = App.Current.Windows.Count - 2; intCounter >= 0; intCounter--)
            {
                App.Current.Windows[intCounter].Close();
            }
        }
    }
}
