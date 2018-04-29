using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project4.Classes;

namespace Project4
{
    public class Task
    {
        public static List<Auto> sort_by_horsepower(List<Auto> autos)
        {
            return autos.OrderBy(node => node.horsepower).ToList();
        }

        public static Auto find_econominal(List<Auto> autos, double average_speed)
        {
            return autos.OrderBy(node => node.find_breakdown_fuel(average_speed)).FirstOrDefault();
        }

        public static Auto find_fastest_auto(List<Auto> autos)
        {
            return autos.OrderBy(node => node.max_speed).LastOrDefault();
        }

        public static void print(List<Auto> autos)
        {
            autos.ForEach(node => Console.WriteLine(node));
        }
    }
}
