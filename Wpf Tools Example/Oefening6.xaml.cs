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
    /// Interaction logic for Oefening6.xaml
    /// </summary>
    public partial class Oefening6 : Window
    {
        public Oefening6()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string messgae = "";

            if (CbOptie1.IsChecked == true)
            {
                messgae += CbOptie1.Content + "\n";
            }
            if (CbOptie2.IsChecked == true)
            {
                messgae += CbOptie2.Content + "\n";
            }
            if (CbOptie3.IsChecked == true)
            {
                messgae += CbOptie3.Content + "\n";
            }
            if (CbOptie4.IsChecked == true)
            {
                messgae += CbOptie4.Content + "\n";
            }
            if (CbOptie5.IsChecked == true)
            {
                messgae += CbOptie5.Content + "\n";
            }

            if (messgae.Length > 0)
            {
                MessageBox.Show(messgae);
            }
            else
            {
                MessageBox.Show("Je hebt niets selecteerd");
            }
        }
    }
}
