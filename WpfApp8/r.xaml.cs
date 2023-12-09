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
    /// Логика взаимодействия для r.xaml
    /// </summary>
    public partial class r : Page
    {
        public r()
        {
            InitializeComponent();
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                t.Text = t.Tag.ToString();
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == t.Tag.ToString())
            {
                t.Text = "";
            }
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new subs());
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new glavnoe());
        }
    }
}
