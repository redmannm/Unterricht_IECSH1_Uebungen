using System;
using System.Collections.Generic;
using System.Text;

namespace BS_IECSH2_Marcus_Redmann.Konten
{
    public class GiroKonto : Konto
    {
        private bool _dispoKreditStatus;
        public bool DispoKreditStatus
        {
            get
            {
                return _dispoKreditStatus;
            }
            set
            {
                _dispoKreditStatus = value;
            }
        }

        private double _dispoKreditRahmen;
        public double DispoKreditRahmen
        {
            get
            {
                return _dispoKreditRahmen;
            }
            set
            {
                _dispoKreditRahmen = value;
            }
        }

        public GiroKonto()
        {
            DispoKreditStatus = false;
            DispoKreditRahmen = 0;
        }

        public override void Abbuchen(double _betrag)
        {
            if ((KontoStand == 0) & (DispoKreditStatus == false)) {
                Console.WriteLine("Leider können Sie Ihr Konto nicht überziehen.");
            }
            else
            {
                
            }
        }

        public override void Einzahlen(double _betrag)
        {
            throw new NotImplementedException();
        }
    }
}
