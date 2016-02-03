using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_6
{
    class Kamerat : tavarat
    {
        public Kamerat()
        {
        }


        public string Model { get; set; }
        public string Optic { get; set; }


        public Kamerat(string name, string location, string broken, string model, string optic)
            : base(name,location,broken)
        {
            Model = model;
            Optic = optic;

        }

        // ylikirjoitetaan tavarat luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä kamerat luokan tiedot
        public override string ToString()
        { 
            return base.ToString() + " Model: " + Model + " Optic: " + Optic;
        }

        public void KameratLost()
        {
            Console.WriteLine("");
            Console.WriteLine("UUPS! Somebody stole your camera");
            Console.WriteLine("");
        }
    }
}
