using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для CheckoutWindow.xaml
    /// </summary>
    public partial class CheckoutWindow : Window
    {
        string check;
        public CheckoutWindow(string checkInfo)
        {
            check = checkInfo;
            InitializeComponent();
        }

        private void makeOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (adresTextBox.Text == "" || nameTextBox.Text == "" ||
                emailTextBox.Text == "" || phoneTextBox.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                string[] checkElements = { "", "", "", "", "", "" };
                int a = 0;
                for (int i = 0; i < check.Length - 1; i++)
                {
                    if (check[i] == ';')
                        a++;
                    else
                        checkElements[a] += check[i];
                }
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Текст (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter
                        (saveFileDialog1.OpenFile(), System.Text.Encoding.Default))
                    {
                        foreach (string c in checkElements)
                        {
                            if (c != String.Empty)
                                sw.WriteLine(c);
                            else
                                break;
                        }
                        sw.WriteLine("");
                        sw.WriteLine("Имя: " + nameTextBox.Text);
                        sw.WriteLine("Телефон: " + phoneTextBox.Text);
                        sw.WriteLine("Email: " + emailTextBox.Text);
                        sw.WriteLine("Адрес: " + adresTextBox.Text);
                        sw.Close();
                    }
                }
                MessageBox.Show("Заказ оформлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
