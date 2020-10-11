using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static App.Task01;

namespace App.Tests
{
    [TestFixture]
    public class Task01Tests
    {
        
        [TestCase(123, 3, ExpectedResult = true)]
        [TestCase(123, 4, ExpectedResult = false)]
        [TestCase(103, 3, ExpectedResult = true)]
        [TestCase(103, 4, ExpectedResult = false)]
        [TestCase(-103, 3, ExpectedResult = true)]
        [TestCase(-103, 4, ExpectedResult = false)]
        [TestCase(0, 0, ExpectedResult = true)]
        [TestCase(0, 4, ExpectedResult = false)]
        [TestCase(4, 4, ExpectedResult = true)]
        public bool CheckHasDigit(int number, int digit)
        {
            return HasDigit(number, digit);
        }

        [TestCase(12, -1)]
        [TestCase(12, -15)]
        [TestCase(12, 10)]
        public void CheckHasDigitException(int number, int digit)
        {
            Assert.That(() => HasDigit(number, digit), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
