using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(4, 6, 10)]
        [TestCase(-4, -6, -10)]
        public void CheckAdd(double a, double b, double expected)
        {
            var calculator = new Calculator();
            var result = calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(6, 2, ExpectedResult = 3)]
        public double CheckDivide(double a, double b)
        {
            var calculator = new Calculator();
            var result = calculator.Divide(a, b);
            return result;
        }

        [TestCase(6, 0)]
        public void CheckDivideException(double a, double b)
        {
            var calculator = new Calculator();
            Assert.That(() => calculator.Divide(a, b), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
