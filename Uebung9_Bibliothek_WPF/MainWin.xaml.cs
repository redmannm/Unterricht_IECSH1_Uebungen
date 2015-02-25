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
        List<ArtikelObj> Artikel = new List<ArtikelObj>();
        public MainWin()
        {
            InitializeComponent();
            
        }
    }
}
