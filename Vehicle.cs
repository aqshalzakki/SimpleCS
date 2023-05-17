using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal class Vehicle
    {
        public int speed;
        public int fuel;

        public Vehicle(int speed, int fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }


        public void Horn()
        {
            Console.WriteLine("Tin! Tin!");
        }

        public virtual void Onward(int speed)
        {
            Console.WriteLine($"The vehicle is speeding at {speed}KM/h");
        }

        public virtual void Brake()
        {
            Console.WriteLine("Braking...");
        }
    }
}
