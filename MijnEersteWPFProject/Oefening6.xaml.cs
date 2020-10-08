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
            Random rng = new Random();
            int gewonnen = rng.Next(3);

            string input = txtInput.Text.Trim().ToLower();

            if (input == "blad" || input == "steen" || input == "schaar")
            {
                switch (input)
                {
                    case "blad":
                        if (gewonnen == 1)
                            MessageBox.Show("De computer koos Steen. Gewonnen!");
                        else if (gewonnen == 2)
                            MessageBox.Show("De computer koos Schaar. Verloren!");
                        else
                            MessageBox.Show("De computer koos Blad. Gelijkspel!");
                        break;
                    case "steen":
                        if (gewonnen == 1)
                            MessageBox.Show("De computer koos Schaar. Gewonnen!");
                        else if (gewonnen == 2)
                            MessageBox.Show("De computer koos Blad. Verloren!");
                        else
                            MessageBox.Show("De computer koos Steen. Gelijkspel!");
                        break;
                    case "schaar":
                        if (gewonnen == 1)
                            MessageBox.Show("De computer koos Blad. Gewonnen!");
                        else if (gewonnen == 2)
                            MessageBox.Show("De computer koos Steen. Verloren!");
                        else
                            MessageBox.Show("De computer koos Schaar. Gelijkspel!");
                        break;
                    default:
                        MessageBox.Show("Oei, dat ken ik niet.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("scrijf Blad, Steen of Schaar");
            }
        }
    }
}
