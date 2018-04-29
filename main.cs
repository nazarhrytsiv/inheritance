using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Classes;
using Project4.Enums;
using Project4.Utility;

namespace Project4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto> 
            {
                {new Sportcar("Lamborghini","Aventador",(Colors)3,(Fuel_types)1,530,200,5.0,false)},
                {new Truck("Zaz", "Kamaz", (Colors)2, (Fuel_types)2, 200, 300, 3.5, (Transmission_brand)2)},
                {new Sportcar("Bugatti","Veyron",(Colors)1,(Fuel_types)1,290,310,2.0,true)},
                {new Car("Opel","C",(Colors)2, (Fuel_types)2, 100, 370, 2.2, (Motor_brand)2) }
            };

            Console.WriteLine("The most economical auto: \n");
            Console.WriteLine(Task.find_econominal(autos, 120));

            Console.WriteLine("The fastest auto: \n");
            Console.WriteLine(Task.find_fastest_auto(autos));

            List<Auto> sorted = Task.sort_by_horsepower(autos);
            Console.WriteLine("Auto sorted by horsepower \n");
            Task.print(sorted);

            Console.ReadKey();
        }
    }
}
