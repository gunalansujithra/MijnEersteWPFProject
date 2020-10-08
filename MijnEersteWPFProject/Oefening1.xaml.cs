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
    /// Interaction logic for Oefening1.xaml
    /// </summary>
    public partial class Oefening1 : Window
    {
        public Oefening1()
        {
            InitializeComponent();
        }

        private void btnKlik_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
