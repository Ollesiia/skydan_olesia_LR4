using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4
{
    abstract class Ship
    {
        public string name;
        public double capacity;
        public double speed;
        public double fuel;
        public Ship(string name, double capacity, double speed, double fuel)
        {
            this.name = name;
            this.capacity = capacity;
            this.speed = speed;
            this.fuel = fuel;


        }
        public abstract void FuelType();

        public override string ToString()
        {
            return this.name + ": \n Грузопiдйомнiсть: " + this.capacity +" кг" +"\n Швидкiсть: " + this.speed + " км\\год";
        }

        public virtual void Refuel(double delta)
        {
            double sum;
            sum = this.fuel + delta;
           Console.WriteLine("Ваш " + this.name +" запревлаено = " +sum ); 
        }

    }
}
