using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Are_they_the_same
{
    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            List<double> list = new List<double>();            
            if (a == null || b == null) return false;
            Array.Sort(a);
            Array.Sort(b);            
            for (int i = 0; i < b.Length; i++)
            {
                list.Add(Math.Sqrt(b[i]));
            }
            if (list.Count != a.Length)
            {
                return false;
            }
            for (int j = 0; j < list.Count; j++)
            {
                if (a[j] != list[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.AreEqual(false, r);
        }
    }
}
