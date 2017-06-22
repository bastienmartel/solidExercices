using System;
using System.Runtime.InteropServices;
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
        public void CalculateALongerSum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3+5,7+9,6");
            Check.That(result).IsEqualTo(18.6);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("23-14,8");
            Check.That(result).IsEqualTo(8.2);
        }

        [Test]
        public void CalculateALongerSubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("7,6-5,9-23,4-1,5");
            Check.That(result).IsEqualTo(-23.2);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("5x7,5");
            Check.That(result).IsEqualTo(37.5);
        }

        [Test]
        public void CalculateALongerProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2x3x4x5x6");
            Check.That(result).IsEqualTo(720);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("45/22,5");
            Check.That(result).IsEqualTo(2);
        }

        [Test]
        public void CalculateALongerDivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("720/2/5/8");
            Check.That(result).IsEqualTo(9);
        }

        /*
        [Test]
        public void CalculateADivisionByZero()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("60/0");
            Check.That(result).IsEqualTo(string.Format("Impossible to divide a number by 0"));

        }
        */
    }
}
