using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car1
    {   //field variables //sisäiset ominaisuudet ei näy ulospäin, ei pysty muuttamaan
        private readonly int maxSpeed = 200;
       // private readonly int minSpeed = 0;
        private readonly double maxHeight = 4.5;

        private int speed; //tämä aina pienellä
        private double height;


        //heght property

            public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0) //onko pienempi tai yhtäsuuri kun pääohjelmassa valitaan
                {
                    Console.WriteLine("Tuollasta autoa ookkaan! liian pieni, set to zero");
                }
                else if (value > maxHeight)
                {
                    Console.WriteLine("Liian korkia, set to max");
                }
                else
                {
                    height = value;
                }
            }
        }

        //property variable //nämä käyttäjä näkee ja pystyy muuttamaan jos ei
        public int Speed {
            get
            {
                return speed; //pienellä
            }
            set
            {
                if (value <= maxSpeed) speed = value; //pienellä
                else
                {
                    Console.WriteLine("Too much Speed!! - Set to max");
                    speed = maxSpeed;
                }
            }

        }
        
    }
}
