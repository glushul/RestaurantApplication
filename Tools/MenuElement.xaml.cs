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

namespace RestaurantApp.Tools
{
    /// <summary>
    /// Логика взаимодействия для MenuElement.xaml
    /// </summary>
    public partial class MenuElement : UserControl
    {
        public MenuElement()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string ImageSource { get; set; }
        public string TextSource { get; set; }
        public string PriceSource { get; set; }
        public int PriceSourceInt { get; set; }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            mealCountTextBox.Text = Convert.ToString(int.Parse(mealCountTextBox.Text) + 1);
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(mealCountTextBox.Text) > 0)
                mealCountTextBox.Text = Convert.ToString(int.Parse(mealCountTextBox.Text) - 1);
        }
    }
}
