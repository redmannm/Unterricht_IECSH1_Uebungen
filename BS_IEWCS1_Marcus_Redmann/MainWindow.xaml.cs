using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BS_IEWCS1_Marcus_Redmann
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Mitarbeiter> _mitarbeiterCollection = new List<Mitarbeiter>();

        internal List<Mitarbeiter> MitarbeiterCollection
        {
            get
            {
                return _mitarbeiterCollection;
            }
            set
            {
                _mitarbeiterCollection = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            DataListMitarbeiter.Items.Add(GetMitarbeiter());
        }

        private List<Mitarbeiter> GetMitarbeiter()
        {
            Mitarbeiter NeuerMitarbeiter = new Mitarbeiter();

            NeuerMitarbeiter.Name = txtName.Text;
            NeuerMitarbeiter.Vorname = txtVorname.Text;
            NeuerMitarbeiter.Strasse = txtStrasse.Text;
            NeuerMitarbeiter.Hausnummer = txtHausnummer.Text;
            NeuerMitarbeiter.Plz = txtPlz.Text;
            NeuerMitarbeiter.Ort = txtOrt.Text;
            NeuerMitarbeiter.Geburtsdatum = (DateTime)datePickGebDat.SelectedDate;
            NeuerMitarbeiter.Alter = GetAlter();
            NeuerMitarbeiter.Tel = txtTelefon.Text;
            NeuerMitarbeiter.Konfession = txtKonfession.Text;
            NeuerMitarbeiter.LohnsteuerKlasse = (LohnStKlasse)Convert.ToInt32(txtLohnsteuerKlasse.Text);
            NeuerMitarbeiter.Kinder = Convert.ToInt32(txtKinder.Text);
            NeuerMitarbeiter.BruttoGehalt = Convert.ToDouble(txtBruttogehalt.Text);
            NeuerMitarbeiter.NettoGehalt = GetNetto(NeuerMitarbeiter);

            MitarbeiterCollection.Add(NeuerMitarbeiter);

            return MitarbeiterCollection;
        }

        private int GetAlter()
        {
            throw new NotImplementedException();
        }

        private double GetNetto(Mitarbeiter mitarbeiter)
        {
            double netto = 0;

            if ((mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Eins) | (mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Fuenf))
            {
                netto = mitarbeiter.BruttoGehalt * 0.79;
            }
            else if (mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Zwei)
            {
                netto = mitarbeiter.BruttoGehalt * 0.80;
            }
            else if (mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Drei)
            {
                netto = mitarbeiter.BruttoGehalt * 0.81;
            }
            else if (mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Vier)
            {
                netto = mitarbeiter.BruttoGehalt * 0.77;
            }
            else if (mitarbeiter.LohnsteuerKlasse == LohnStKlasse.Sechs)
            {
                netto = mitarbeiter.BruttoGehalt * 0.70;
            }
            return netto;
        }

    }
}
