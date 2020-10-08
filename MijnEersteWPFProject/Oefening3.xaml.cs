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

namespace MijnEersteWPFProject
{
    /// <summary>
    /// Interaction logic for Oefening3.xaml
    /// </summary>
    public partial class Oefening3 : Window
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int som = getal1 + getal2;

            MessageBox.Show("De som is " + som.ToString());
        }
    }
}
