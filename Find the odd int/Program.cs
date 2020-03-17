using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_odd_int
{
    class Kata
    {
        public static int find_it(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count % 2 != 0)
                    return arr[i];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(-1, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, -1 }));
        }
    }
}
