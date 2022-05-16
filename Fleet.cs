using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Laba4
{
    class Fleet
    {
        public List<Ship> ships = new List<Ship>();


        public void createShip(Ship ship)
        {
            ships.Add(ship);
        }

        public double generalCapacity()
        {

            double res = 0;
            ships.ForEach(ship => res += ship.capacity);
            return res;
        }

        public void Fuel()
        {
            Console.WriteLine("Типи палива: ");
            foreach (var ship in ships)
            {
                ship.FuelType();

            }

            Console.WriteLine("-------------");

        }

        public void GetInfo()
        {
            Console.WriteLine("Iнформацiя: ");
            foreach (var info in ships)
            {
                Console.WriteLine(info.ToString());

            }

            Console.WriteLine("-------------");
        }

        public void Refuel()
        {
            Console.WriteLine("Ви хочете запрпавити кораблi?");
            string io = Console.ReadLine();
            if (io == "yes")
            {


                foreach (var refual in ships)
                {
                    refual.Refuel(567);
                }
            }
            else
            {
                Console.WriteLine("======================");
            }
        }

       
           
        }
   }
