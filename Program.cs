using System;


namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {  
            Fleet fleet = new Fleet();
            fleet.createShip(new Cargo("Вантажне судно ", 60000, 60, 56738));
            fleet.createShip(new Cater("Катер ", 1200, 18, 2819));
            fleet.createShip(new Tanker("Танкер ", 100000, 26, 18923));
            fleet.GetInfo();
            fleet.Fuel();
            Console.WriteLine("Спiльна ванатжопiдйомнiсть: " + fleet.generalCapacity());
            fleet.Refuel();
            
        } 
        
    }
    
}
