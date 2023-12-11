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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для sponsor.xaml
    /// </summary>
    public partial class sponsor : Page
    {
        public sponsor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new spsxaml());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new glavnoe());
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox d = (TextBox)sender;
            if (d.Text == d.Tag.ToString())
            {
                d.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox d = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(d.Text))
            {
                d.Text = d.Tag.ToString();
            }
        }

       
    }
}
