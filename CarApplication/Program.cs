using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //create one car object
            Car1 car = new Car1();
            car.Speed = 300;
            car.Height = 5.0;
           // car.MaxSpeed = 300; ei onnistu koska luokka on suojattu
            Console.WriteLine("Speed is {0}", car.Speed, car.Height
                );
            Console.ReadLine();
        }
    }
}
