using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Integral.Classes
{
    public class MiddleRectanglesIntegral : IntegralCalculator
    {
        private double Function(double x)
        {
            return x * x;
        }
        public double Calculate(double a, double b, int count)
        {
            if (count <= 0 | a > b)
                throw new ArgumentException();
            double h = (b - a) / count;
            double S = 0;
            a += h * 0.5;
            for (int i = 0; i < count; i++)
            {
                //S += 2 * (a + h * i) - Math.Log((2 * (a + h * i))) + 234;
                S += Function(a + h * i);
            }
            return h * S;
        }
    }
}
