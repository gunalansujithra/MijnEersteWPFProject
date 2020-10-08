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
    /// Interaction logic for Oefening10A.xaml
    /// </summary>
    public partial class Oefening10A : Window
    {
        public Oefening10A()
        {
            InitializeComponent();

            tbVoornaam.Text = Oefening10.Voornaam;
            tbAchternaam.Text = Oefening10.AchterNaam;
            tbLeeftijd.Text = Oefening10.Leeftijd;
            tbAdres.Text = Oefening10.Adres;
            tbGeslacht.Text = Oefening10.Geslacht;
        }
    }
}
