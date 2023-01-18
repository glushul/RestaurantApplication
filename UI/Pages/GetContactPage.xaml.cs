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

namespace RestaurantApp.UI.Pages
{
    /// <summary>
    /// Логика взаимодействия для GetContact.xaml
    /// </summary>
    public partial class GetContactPage : Page
    {
        public GetContactPage()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            // Очищает все текстбоксы
            TextBoxEmail.Text = "";
            TextBoxName.Text = "";
            TextBoxPhone.Text = "";
        }
    }
}
