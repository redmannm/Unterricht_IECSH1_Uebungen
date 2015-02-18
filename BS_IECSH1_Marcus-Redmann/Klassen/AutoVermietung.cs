using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung.Klassen
{
    class AutoVermietung : Auto
    {
        Auto _fahrzeug = new Auto();
        List<Auto> _fahrzeuge = new List<Auto>();

        public void addFahrzeug() {
            if (_fahrzeug == null)
                _fahrzeug = new Auto();
            Console.Clear();
            Console.WriteLine("Fahrzeug hinzufügen\n" +
                              "-------------------\n\n");
            Console.Write("{0}", "Hersteller: ".PadRight(20));
            _fahrzeug.Hersteller     = Console.ReadLine();

            Console.Write("{0}", "Modell: ".PadRight(20));
            _fahrzeug.Modell         = Console.ReadLine();

            Console.Write("{0}", "Typ: ".PadRight(20));
            _fahrzeug.Typ            = Console.ReadLine();

            Console.Write("{0}", "Kennzeichen: ".PadRight(20));
            _fahrzeug.Kennzeichen    = Console.ReadLine();

            Console.Write("{0}", "Leistung in KW: ".PadRight(20));
            _fahrzeug.Leistung       = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}", "Kilometerstand: ".PadRight(20));
            _fahrzeug.Kilometerstand = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0}", "Mietpreis: ".PadRight(20));
            _fahrzeug.Mietpreis      = Convert.ToDouble(Console.ReadLine());

            _fahrzeuge.Add(_fahrzeug);
            _fahrzeug = null;
        }

        public void getFahrzeugliste()
        {
            string txtTmp;
            int editIndex;
            string editStatus;
            
            foreach (Auto item in _fahrzeuge)
            {
                if (item.StatusVermietet)
                    txtTmp = "Vermietet";
                else
                    txtTmp = "Nicht vermietet";
                Console.WriteLine("\n----------------------------------------------\n");
                Console.WriteLine("Fahrzeugdaten Index: " + _fahrzeuge.IndexOf(item, 0));
                Console.WriteLine("Hersteller: " + item.Hersteller);
                Console.WriteLine("Hersteller: " + item.Modell);
                Console.WriteLine("Hersteller: " + item.Typ);
                Console.WriteLine("Hersteller: " + item.Kennzeichen);
                Console.WriteLine("Hersteller: " + item.Leistung);
                Console.WriteLine("Hersteller: " + item.Kilometerstand);
                Console.WriteLine("Hersteller: " + txtTmp);
                Console.WriteLine("Hersteller: " + item.Mietpreis);
            }
            Console.WriteLine("\n----------------------------------------------\n");
            Console.Write("Welche Index-Nummer möchten sie bearbeiten?: ");
            editIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fahrzeug verliehen? (J/N): ");
            editStatus = Console.ReadLine().ToUpper();

            if (editStatus == "J")
                _fahrzeuge[editIndex].StatusVermietet = true;
            else
                _fahrzeuge[editIndex].StatusVermietet = false;

            Console.Write("Kilometerstand bearbeiten? (J/N): ");
            editStatus = Console.ReadLine().ToUpper();

            if (editStatus == "J")
            {
                Console.Write("Neuer Kilometerstand: ");
                _fahrzeuge[editIndex].Kilometerstand = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
