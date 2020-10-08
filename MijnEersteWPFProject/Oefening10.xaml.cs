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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MijnEersteWPFProject
{
    /// <summary>
    /// Interaction logic for Oefening10.xaml
    /// </summary>
    public partial class Oefening10 : Window
    {
        public Oefening10()
        {
            InitializeComponent();
        }

        public static string Voornaam = "";
        public static string AchterNaam = "";
        public static string Leeftijd = "";
        public static string Adres = "";
        public static string Geslacht = "";
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Voornaam = txtVoornaam.Text.Trim();
            AchterNaam = txtAchternaam.Text.Trim();
            Leeftijd = txtLeeftijd.Text.Trim();
            Adres = txtAddress.Text.Trim();
            if (rbFemale.IsChecked == true)
            {
                Geslacht = rbFemale.Content.ToString();
            }
            else if (rbMale.IsChecked == true)
            {
                Geslacht = rbMale.Content.ToString();
            }           

            Oefening10A oef10A = new Oefening10A();
            oef10A.Show();
            
        }
    }
}
