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
    /// Interaction logic for Oefening5.xaml
    /// </summary>
    public partial class Oefening5 : Window
    {
        public Oefening5()
        {
            InitializeComponent();
        }

        public List<Persoon> PersoonLijst = new List<Persoon>();

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string voornaam = txtVoornaam.Text.Trim();
            string achternaam = txtAchternaam.Text.Trim();
            bool isLogged = (bool)rbIsLogged.IsChecked;
            string imgIsLoggedPath;

            if (isLogged)
            {
                imgIsLoggedPath = @"C:\Users\Krëfel\Downloads\Tick.jpg";
            }
            else
            {
                imgIsLoggedPath = @"C:\Users\Krëfel\Downloads\Cross.jpg";
            }

            Persoon newPersoon = new Persoon(voornaam, achternaam, isLogged, imgIsLoggedPath);
            PersoonLijst.Add(newPersoon);
            MessageBox.Show(voornaam + " " + achternaam + " is toegevoegt");
            txtVoornaam.Clear();
            txtAchternaam.Clear();
            rbIsLogged.IsChecked = false;

            cbPersoon.ItemsSource = null;
            cbPersoon.ItemsSource = PersoonLijst;
        }

        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }

            public bool IsLoggedIn { get; set; }

            public string ImgIsLoggedPath { get; set; }

            public Persoon(string voornaam, string achternaam, bool isLoggedIn, string imgIsLoggedPath)
            {
                Voornaam = voornaam;
                Achternaam = achternaam;
                IsLoggedIn = isLoggedIn;
                ImgIsLoggedPath = imgIsLoggedPath;
            }
        }
    }
}
