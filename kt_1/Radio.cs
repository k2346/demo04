using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_1
{
    class Radio
    {

        //field variables //sisäiset ominaisuudet ei näy ulospäin, ei pysty muuttamaan
        private readonly int maxVolume = 10;
       private readonly int minVolume = 0;
        private readonly double maxFrequency = 26000.0;
        private readonly double minFrequency = 2000.0;

        private int volume; //tämä aina pienellä
        private double frequency;


        //property variable // näitä arvoja käyttäjä pystyy muuttamaan jos, eivät ylitä minimi tai maksimi arvoja.
        public int Volume
        {
            get
            {
                return volume; //pienellä
            }

            set
            {
                if (value < 0) //onko pienempi kuin minimi volume
                {
                    Console.WriteLine("Too silent!! - Set to min");
                    volume = minVolume;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Too loud!! - Set to max");
                    volume = maxVolume;
                }
                else
                {
                    volume = value;
                }
            }

        }


        public double Frequency
        {
            get
            {
                return frequency; //pienellä
            }

            set
            {
                if (value < 2000.0) //onko pienempi kuin minimi arvo
                {
                    Console.WriteLine("Not a channel - Set to min");
                    frequency = minFrequency;
                }
                else if (value > maxFrequency)
                {
                    Console.WriteLine("Not a channel - Set to max");
                    frequency = maxFrequency;
                }
                else
                {
                    frequency = value;
                }
            }

        }


        public bool OnOff { get; set; }



    
  }
}
