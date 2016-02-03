using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_6
{
    class Ruokia : tavarat
    {
        public string Rotten { set; get; }

        public Ruokia()
        {
        }


        public Ruokia(string name, string location, string broken, string rotten)
            : base(name,location,broken)
        {
            Rotten = rotten;

        }

        // ylikirjoitetaan tavarat luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä Ruokia luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Rotten: " + Rotten;
        }
    }
}
