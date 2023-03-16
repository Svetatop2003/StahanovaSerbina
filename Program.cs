using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StahanovaAndSerbina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = (8 * Math.Sin(2 * x)) - Math.Cos(2 * x);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
        }
    }
}
