using NUnit.Framework;
using System;

namespace Duplicate_Encoder
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            return word;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
    }
}
