using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("23-14,8");
            Check.That(result).IsEqualTo(8.2);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5x7,5");
            Check.That(result).IsEqualTo(37.5);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("45/22,5");
            Check.That(result).IsEqualTo(2);
        }
    }
}
