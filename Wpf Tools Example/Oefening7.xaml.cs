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
    /// Interaction logic for Oefening7.xaml
    /// </summary>
    public partial class Oefening7 : Window
    {
        public Oefening7()
        {
            InitializeComponent();
        }

        public List<Notities> NotitiesLijst = new List<Notities>();

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string titel = txtTitle.Text.Trim();
            string desc = txtDesc.Text.Trim();
            DateTime date = Convert.ToDateTime(dpDate.SelectedDate);
            bool isDone = (bool)cbIsDone.IsChecked;

            Notities newNotities = new Notities(titel, desc, date, isDone);
            NotitiesLijst.Add(newNotities);
            MessageBox.Show("Notitie " + titel + " is toegevoegt");
            txtTitle.Clear();
            txtDesc.Clear();
            dpDate.SelectedDate = DateTime.Now;
            cbIsDone.IsChecked = false;

            cbNotities.ItemsSource = null;
            cbNotities.ItemsSource = NotitiesLijst;
        }

        public class Notities
        {
            public string Titel { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
            public bool IsDone { get; set; }

            public Notities(string titel, string description, DateTime date, bool isDone)
            {
                Titel = titel;
                Description = description;
                Date = date;
                IsDone = isDone;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int index = cbNotities.SelectedIndex;
            NotitiesLijst[index].Titel = txtTitle2.Text.Trim();
            NotitiesLijst[index].Description = txtDesc2.Text.Trim();
            NotitiesLijst[index].Date = Convert.ToDateTime(dpDate2.SelectedDate);
            NotitiesLijst[index].IsDone = (bool)cbIsDone2.IsChecked;

            MessageBox.Show("Notitie is bewerkt");
            cbNotities.ItemsSource = null;
            cbNotities.ItemsSource = NotitiesLijst;
            txtTitle2.Clear();
            txtDesc2.Clear();
            dpDate2.SelectedDate = DateTime.Now;
            cbIsDone2.IsChecked = false;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = cbNotities.SelectedIndex;
            string title = NotitiesLijst[index].Titel;            
            NotitiesLijst.RemoveAt(index);

            MessageBox.Show("Notitie " + title + " is verwijdered");

            cbNotities.ItemsSource = null;
            cbNotities.ItemsSource = NotitiesLijst;
            txtTitle2.Clear();
            txtDesc2.Clear();
            dpDate2.SelectedDate = DateTime.Now;
            cbIsDone2.IsChecked = false;
        }

        private void cbNotities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbNotities.SelectedIndex >= 0)
            {
                int index = cbNotities.SelectedIndex;
                txtTitle2.Text = NotitiesLijst[index].Titel;
                txtDesc2.Text = NotitiesLijst[index].Titel;
                dpDate2.SelectedDate = NotitiesLijst[index].Date;
                cbIsDone2.IsChecked = NotitiesLijst[index].IsDone;

            }
            else
            {
                txtTitle.Clear();
                txtDesc.Clear();
                dpDate.SelectedDate = DateTime.Now;
                cbIsDone.IsChecked = false;
            }
        }
    }
}
