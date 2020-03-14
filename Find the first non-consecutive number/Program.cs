using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Find_the_first_non_consecutive_number
{
    class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            int a = 0;
            List<int> list = new List<int>();
            for (int i = 1; i < arr.Length; i++)
            {                
                if ((arr[i]<arr.Length+1)&&(arr[i-1]+1 != arr[i]))
                {                    
                    a = arr[i];                   

                }                
            }
            return a; 
        }
        static void Main(string[] args)
        {
            Assert.AreEqual(6, Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
           
        }
    }
}
