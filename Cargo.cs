using System;

namespace Laba4
{
    class Cargo: Ship
    {
        public Cargo(string name, double capacity, double speed, double fuel) : base(name, capacity, speed, fuel)
        {

        }
        public override void FuelType()
        {
            Console.WriteLine(this.name + "використовує газ" );
        }
        
    }
}