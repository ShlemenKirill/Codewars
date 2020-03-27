using NUnit.Framework;
using System;

namespace Number_of_Decimal_Digits
{
    public class DecTools
    {
        public static int Digits(ulong n)
        {
            string s = n.ToString();
            int res = s.Length;
            return res;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual(1, DecTools.Digits(5ul));
            Assert.AreEqual(5, DecTools.Digits(12345ul));
            Assert.AreEqual(10, DecTools.Digits(9876543210ul));
        }
    }
}
