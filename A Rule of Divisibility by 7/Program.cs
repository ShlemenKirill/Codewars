using NUnit.Framework;
using System;

namespace A_Rule_of_Divisibility_by_7
{
    class DivSeven
    {
        
        public static long[] Seven(long m)
        {
            int cnt = 0;
                            
            if (m<99)
            {
                
                long[] res2 = new long[2] { m, 0 };
                return res2;
            }
            while (m > 99)
            {
                m = m / 10 - (2 * (m % 10));
                cnt++;
            }
            
            long[] res = new long[2] { m,cnt};
            return res;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(new long[] { 10, 2 }, DivSeven.Seven(1021));
            Assert.AreEqual(new long[] { 7, 2 }, DivSeven.Seven(1603));
            Assert.AreEqual(new long[] { 35, 1 }, DivSeven.Seven(371));
            Assert.AreEqual(new long[] { 42, 1 }, DivSeven.Seven(483));
        }
    }
}
