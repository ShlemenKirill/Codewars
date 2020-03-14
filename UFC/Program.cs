using System;

namespace UFC
{
    class Program
    {
        public static string Quote(string fighter)
        {
            string McGregor = "Conor McGregor";
            string McGregor_speech = "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            string SaintPierre = "george saint pierre";
            string SaintPierre_speech = "I am not impressed by your performance.";
            if (fighter == McGregor)
            {
                return McGregor_speech;
            }
            return SaintPierre_speech;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
