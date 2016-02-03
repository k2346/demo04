using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_6
{
    class Kirja : tavarat
    { 
        public string Kirjoittaja { get; set; }

        public Kirja()
        {
        }



        public Kirja(string name, string location, string broken, string kirjoittaja)
            : base(name,location,broken)
        {
            Kirjoittaja = kirjoittaja;

        }


        // ylikirjoitetaan tavarat luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä Kirja luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Writer: " + Kirjoittaja;
        }
    }
}
