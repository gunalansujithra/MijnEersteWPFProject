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
    /// Interaction logic for Oefening4.xaml
    /// </summary>
    public partial class Oefening4 : Window
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int som = getal1 + getal2;

            MessageBox.Show("De som van is " + som.ToString());
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int min = getal1 - getal2;

            MessageBox.Show("De min is " + min.ToString());
        }

        private void btnMal_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int maal = getal1 * getal2;

            MessageBox.Show("De maal is " + maal.ToString());
        }

        private void btnDelen_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = Convert.ToInt32(txtGetal1.Text);
            int getal2 = Convert.ToInt32(txtGetal2.Text);

            int deel = getal1 / getal2;

            MessageBox.Show("De gedeeld door is " + deel.ToString());
        }
    }
}
