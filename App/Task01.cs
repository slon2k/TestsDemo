using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    public static class Task01
    {
        public static bool HasDigit(int number, int digit)
        {
            if (digit > 9 || digit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(digit));
            }

            number = Math.Abs(number);

            do
            {
                int lastDigit = number % 10;
                if (lastDigit == digit)
                {
                    return true;
                }

                number /= 10;
            } while (number > 0);

            return false;
        }
    }
}
