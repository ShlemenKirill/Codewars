using NUnit.Framework;
using System;

namespace Sort_the_odd
{
    class Kata
    {
        public static int[] SortArray(int[] array)
        {
            return array;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }
    }
}
