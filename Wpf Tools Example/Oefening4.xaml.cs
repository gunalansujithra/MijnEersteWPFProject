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
    /// Interaction logic for Oefening4.xaml
    /// </summary>
    public partial class Oefening4 : Window
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        public string InputString = "";
        private void mClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
        }

        private void mCopy_Click(object sender, RoutedEventArgs e)
        {
            InputString = txtInput.Text;
        }

        private void mPaste_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = InputString;
        }
    }
}
