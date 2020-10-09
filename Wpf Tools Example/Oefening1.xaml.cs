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
    /// Interaction logic for Oefening1.xaml
    /// </summary>
    public partial class Oefening1 : Window
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (cbGeslacht.SelectedIndex >= 0 && cbLeeftijd.SelectedIndex >= 0)
            {
                MessageBox.Show(cbLeeftijd.Text + " " + cbGeslacht.Text);
            }
            else
            {
                MessageBox.Show("Please select Geslacht and Leeftijd");
            }
        }
    }
}
