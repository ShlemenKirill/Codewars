using NUnit.Framework;
using System;

namespace UFC
{
    class Kata
    {
        public static string Quote(string fighter)
        {
            string figter_lower = fighter.ToLower();
            string McGregor = "conor mcgregor";
            string McGregor_speech = "I'd like to take this chance to apologize.. To absolutely NOBODY!";            
            string SaintPierre_speech = "I am not impressed by your performance.";
            if (figter_lower == McGregor)
            {
                return McGregor_speech;
            }
            return SaintPierre_speech;
        }
        static void Main(string[] args)
        {
            Assert.AreEqual("I am not impressed by your performance.", Kata.Quote("george saint pierre"));
            Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", Kata.Quote("conor mcgregor"));
            Assert.AreEqual("I am not impressed by your performance.", Kata.Quote("George Saint Pierre"));
            Assert.AreEqual("I'd like to take this chance to apologize.. To absolutely NOBODY!", Kata.Quote("Conor McGregor"));
        }
    }
}
