using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class TrapezoidIntegral : IntegralCalculator
    {
        private double Function(double x)
        {
            return x * x;
        }
        public double Calculate(double a, double b, int count)
        {
            double h = (b - a) / count;
            double S = 0;
            for (int i = 0; i < count; i++)
            {
                //S += (2 * (a + h * i) - Math.Log((2 * (a + h * i))) + 234);
                S += Function((a + h * i));
            }
            //return h * (S + ((2 * (a) - Math.Log((2 * (a))) + 234) + (2 * (b) - Math.Log((2 * (b))) + 234)) / 2);
            return h * (S + (Function(a) + Function(b)) / 2);
        }
    }
}
