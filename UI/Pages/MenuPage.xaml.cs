using RestaurantApp.Tools;
using RestaurantApp.UI.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            string checkInfo = "";
            foreach (FrameworkElement element in gridFirst.Children)
            {
                if (element is Tools.MenuElement)
                {
                    MenuElement menuElement = (MenuElement)element;
                    if (int.Parse(menuElement.mealCountTextBox.Text) > 0)
                    {
                        checkInfo += menuElement.TextSource + " *" + menuElement.mealCountTextBox.Text
                            + " - " + menuElement.PriceSourceInt*int.Parse(menuElement.mealCountTextBox.Text)
                            + " руб.;";
                    }
                }
            }
            foreach (FrameworkElement element in gridSecond.Children)
            {
                if (element is Tools.MenuElement)
                {
                    MenuElement menuElement = (MenuElement)element;
                    if (int.Parse(menuElement.mealCountTextBox.Text) > 0)
                    {
                        checkInfo += menuElement.TextSource + " *" + menuElement.mealCountTextBox.Text
                            + " - " + menuElement.PriceSourceInt *int.Parse(menuElement.mealCountTextBox.Text)
                            + " руб.;";
                    }
                }
            }
            CheckoutWindow checkoutWindow = new CheckoutWindow(checkInfo);
            checkoutWindow.Show();
        }
    }
}
