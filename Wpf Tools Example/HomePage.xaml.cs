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

namespace Wpf_Tools_Example
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnOef7_Click(object sender, RoutedEventArgs e)
        {
            Oefening7 oef7 = new Oefening7();
            oef7.Show();
        }

        private void btnOef8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow oef8 = new MainWindow();
            oef8.Show();
        }

        private void btnOef1_Click(object sender, RoutedEventArgs e)
        {
            Oefening1 oef1 = new Oefening1();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, RoutedEventArgs e)
        {
            Oefening2 oef2 = new Oefening2();
            oef2.Show();
        }

        private void btnOef3_Click(object sender, RoutedEventArgs e)
        {
            Oefening3 oef3 = new Oefening3();
            oef3.Show();
        }

        private void btnOef4_Click(object sender, RoutedEventArgs e)
        {
            Oefening4 oef4 = new Oefening4();
            oef4.Show();
        }

        private void btnOef5_Click(object sender, RoutedEventArgs e)
        {
            Oefening5 oef5 = new Oefening5();
            oef5.Show();
        }

        private void btnOef6_Click(object sender, RoutedEventArgs e)
        {
            Oefening6 oef6 = new Oefening6();
            oef6.Show();
        }
    }
}
