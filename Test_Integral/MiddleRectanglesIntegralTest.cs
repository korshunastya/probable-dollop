using Integral.Classes;

namespace Test_Integral
{
    [TestClass]
    public class MiddleRectanglesIntegralTest
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
            MiddleRectanglesIntegral calc = new MiddleRectanglesIntegral();
            double result = calc.Calculate(a,b,count);

            //Assert
            Assert.AreEqual(expect, result, 0.01);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void CalculateXX_NegativeCount_Error()
        {
            //Arrange
            double a = 0;
            double b = 1000;
            int count = -1000000;

            //Act
            MiddleRectanglesIntegral calc = new MiddleRectanglesIntegral();
            double result = calc.Calculate(a, b, count);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void CalculateXX_LowerAndUpper_Error()
        {
            //Arrange
            double a = 1000;
            double b = 0;
            int count = 1000000;

            //Act
            MiddleRectanglesIntegral calc = new MiddleRectanglesIntegral();
            double result = calc.Calculate(a, b, count);
        }
    }
}