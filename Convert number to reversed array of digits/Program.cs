using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Convert_number_to_reversed_array_of_digits
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {

            List<long> digits = new List<long>();
            do
            {
                digits.Add(Math.Abs(n % 10));
            } while ((n /= 10) != 0);
            return digits.ToArray();
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, Digitizer.Digitize(35231));
        }
    }
}
