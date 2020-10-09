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
    /// Interaction logic for Oefening2.xaml
    /// </summary>
    public partial class Oefening2 : Window
    {
        public Oefening2()
        {
            InitializeComponent();
        }

        private void txtTab1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputString = txtTab1.Text;
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string outputString = new string(charArray);
            txtTab2.Text = outputString;
        }
    }
}
