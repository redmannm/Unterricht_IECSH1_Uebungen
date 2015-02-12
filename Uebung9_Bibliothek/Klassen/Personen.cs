using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung8.Klassen
{
    class Personen : IEnumerable<Personen>
    {
        bool status; // Mitarbeiter aktiviert / deaktiviert
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        string vorname;
        public string Vorname
        {
            get
            {
                return vorname;
            }
            set
            {
                vorname = value;
            }
        }

        DateTime gebDat;
        public DateTime GebDat
        {
            get
            {
                return gebDat;
            }
            set
            {
                gebDat = value;
            }
        }

        string strasse;
        public string Strasse
        {
            get
            {
                return strasse;
            }
            set
            {
                strasse = value;
            }
        }

        string hausnummer;
        public string Hausnummer
        {
            get
            {
                return hausnummer;
            }
            set
            {
                hausnummer = value;
            }
        }

        string plz;
        public string Plz
        {
            get
            {
                return plz;
            }
            set
            {
                plz = value;
            }
        }

        string ort;
        public string Ort
        {
            get
            {
                return ort;
            }
            set
            {
                ort = value;
            }
        }

        int konfession;
        /// <summary>
        /// <para>1 = Röm. Katholisch</para>
        /// <para>2 = Evangelisch</para>
        /// <para>3 = Orthodox</para>
        /// </summary>
        public int Konfession
        {
            get
            {
                return konfession;
            }
            set
            {
                konfession = value;
            }
        }

        public virtual void Anlegen()
        {

        }

        IEnumerator<Personen> IEnumerable<Personen>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
