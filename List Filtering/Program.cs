using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace List_Filtering
{
    class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            Regex regex = new Regex(@"\d");
            string a = listOfItems.ToString;
            IEnumerable<int> evens = from i in listOfItems
                                     where i => regex
                                     select i;
            return evens;
        }
        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = ListFilterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
            Console.WriteLine("Hello World!");
        }
    }
}
