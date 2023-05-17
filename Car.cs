using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal class Car : Vehicle
    {
        public string name;

        public Car(int speed, int fuel, string name) : base(speed, fuel)
        {
            this.fuel = fuel;
            this.speed = speed;
            this.name = name;
        }

        ~Car()
        {
            Console.WriteLine("Iam gone!");
        }

        public override void Onward(int speed)
        {
            Console.WriteLine($"Car is speeding at {speed}KM/h");
        }
    }
}
