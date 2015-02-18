using System;
using System.Collections.Generic;
using System.Text;

namespace BS_IECSH2_Marcus_Redmann.Konten
{
    public class SparKonto : Konto
    {
        private double _zinsSatz;

        public double ZinsSatz
        {
            get
            {
                return _zinsSatz;
            }
            set
            {
                _zinsSatz = value;
            }
        }

        public SparKonto()
        {
            ZinsSatz = 0.25;
        }

        public override void Abbuchen(double _betrag)
        {
            throw new NotImplementedException();
        }

        public override void Einzahlen(double _betrag)
        {
            throw new NotImplementedException();
        }
    }
}
