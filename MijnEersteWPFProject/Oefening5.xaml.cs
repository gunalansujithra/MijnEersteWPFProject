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
    /// Interaction logic for Oefening5.xaml
    /// </summary>
    public partial class Oefening5 : Window
    {
        public Oefening5()
        {
            InitializeComponent();

            cbPersoon.ItemsSource = PersoonLijst;
        }

        public List<Persoon> PersoonLijst = new List<Persoon>();
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string voornaam = txtVoornaam.Text.Trim();
            string achternaam = txtAchternaam.Text.Trim();

            Persoon newPersoon = new Persoon(voornaam, achternaam);
            PersoonLijst.Add(newPersoon);
            MessageBox.Show(voornaam + " " + achternaam + " is toegevoegt");
            txtVoornaam.Clear();
            txtAchternaam.Clear();

            cbPersoon.ItemsSource = null;
            cbPersoon.ItemsSource = PersoonLijst;

        }

        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }

            public Persoon(string voornaam, string achternaam)
            {
                Voornaam = voornaam;
                Achternaam = achternaam;
            }
        }

        private void btnKlik_Click(object sender, RoutedEventArgs e)
        {
            if (PersoonLijst.Count >= 0)
            {
                int index = Convert.ToInt32(txtIndex.Text.Trim());

                if (index < 0 || index >= PersoonLijst.Count)
                {
                    MessageBox.Show("Please enter a number between 0 and " + PersoonLijst.Count);
                }
                else
                {
                    MessageBox.Show(PersoonLijst[index].Voornaam + " " + PersoonLijst[index].Achternaam);
                }
                txtIndex.Clear();
            }
        }
    }
}
