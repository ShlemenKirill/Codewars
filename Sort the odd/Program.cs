using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Sort_the_odd
{
    class Kata
    {
        public static int[] SortArray(int[] array)
        {
            List<int> odd = new List<int>(array.Length);
            List<int> index = new List<int>(array.Length);
            int[] mas = new int[array.Length];            
            for (int i = 0; i < array.Length; i++)
            {                
                if (array[i]%2 == 1)
                {
                    odd.Add(array[i]);
                    index.Add(i);
                }
                else
                {
                    mas[i] = array[i];
                }                
            }
            odd.Sort();            
            
            for (int j = 0; j < odd.Count; j++)
            {
                mas[index[j]] = odd[j];
                
            }
                        
            return mas;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }
    }
}
