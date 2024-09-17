using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial
{
    class Bus
    {
        public int Wheels { get; set; }
        public Bus(int wheel)
        {
            this.Wheels = wheel;
        }

        public void Capacity(){
            Console.WriteLine("Bus capacity : 40");
        }

        // Runtime/Dynamic polymorphism => Overriding same function and same parameters but different implementation
        public virtual void BusDetails()
        {
            Console.WriteLine($"This bus has {Wheels} wheels");
        }
    }
}