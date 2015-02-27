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
using Uebung9_Bibliothek_WPF.Artikel;

namespace Uebung9_Bibliothek_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        List<ArtikelObj> list = new List<ArtikelObj>();
        
        public MainWin()
        {
            InitializeComponent();
            lstBuecher.ItemsSource = AddArtikel2List();
        }
        private List<ArtikelObj> AddArtikel2List()
        {
            list.Add(new Buch
            {
                Titel = "Titel des 1. Buches",
                Author = "Marcus Redmann",
                Bestand = 5,
                Isbn = "1234567",
                Kategorie = "Fantasy",
                Verlag = "Der Verlag"
            });
            
            list.Add(new Buch
            {
                Titel = "Titel des 2. Buches",
                Author = "Marcus Redmann",
                Bestand = 5,
                Isbn = "1234567",
                Kategorie = "Fantasy",
                Verlag = "Der Verlag"
            });
            list.Add(new Buch
            {
                Titel = "Titel des 3. Buches",
                Author = "Marcus Redmann",
                Bestand = 5,
                Isbn = "1234567",
                Kategorie = "Fantasy",
                Verlag = "Der Verlag"
            });
            return list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test testFenster = new Test();
            testFenster.Show();
        }
    }
}
