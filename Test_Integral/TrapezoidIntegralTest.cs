using Integral.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Integral
{
    [TestClass]
    public class TrapezoidIntegralTest
    {
        [TestMethod]

        public void CalculateXX_Success()
        {
            //Arrange
            double a = 0;
            double b = 1000;
            int count = 1000000;
            double expect = 333333333.3333;

            //Act
            TrapezoidIntegral calc = new TrapezoidIntegral();
            double result = calc.Calculate(a, b, count);

            //Assert
            Assert.AreEqual(expect, result, 0.01);
        }
    }
}
