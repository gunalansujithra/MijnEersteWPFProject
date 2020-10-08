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
    /// Interaction logic for Oefening7.xaml
    /// </summary>
    public partial class Oefening7 : Window
    {
        public Oefening7()
        {
            InitializeComponent();

            img1.Visibility = Visibility.Hidden;
            img2.Visibility = Visibility.Hidden;
            img3.Visibility = Visibility.Hidden;
        }

        private void cbPersoon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbPersoon.SelectedIndex == 0)
            {
                img1.Visibility = Visibility.Visible;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Hidden;
            }
            else if (cbPersoon.SelectedIndex == 1)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Visible;
                img3.Visibility = Visibility.Hidden;
            }
            else if (cbPersoon.SelectedIndex == 2)
            {
                img1.Visibility = Visibility.Hidden;
                img2.Visibility = Visibility.Hidden;
                img3.Visibility = Visibility.Visible;
            }
            
        }
    }
}
