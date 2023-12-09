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
    /// Логика взаимодействия для sp.xaml
    /// </summary>
    public partial class sp : Page
    {
        public sp()
        {
            InitializeComponent();
        }
        private void A_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new m_beg());
        }
    }
}
