using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationMethodOverloading
{
    internal class Calculations
    {
        public int Cal(int a, int b) 
        {
            return a + b;
        }
        public double Cal(double x, double y)
        {
            return x - y;
        }
        public double Cal(int p , double q)
        {
            return p * q;
        }

    }
}
