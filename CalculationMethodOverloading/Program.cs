using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations c1 = new Calculations();
            int result1 = c1.Cal(10, 20);
            c1.Cal(29.8, 30.7);
            Console.WriteLine($"Addition = {result1}");
            double result2 = c1.Cal(2.2, 22.10);
            Console.WriteLine($"Substraction = {result2}");
            double result3 = c1.Cal(20, 10.55);
            Console.WriteLine($"Multiplication = {result3}");
            

        }
    }
}
