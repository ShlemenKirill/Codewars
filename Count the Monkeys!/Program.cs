using System;

namespace Count_the_Monkeys_
{
    class Program
    {
        public static int[] MonkeyCount(int n)
        {

            int[] mas = new int[n];
            for (int i = 0; i < n ; i++)
            {
                mas[i] = i+1;

            }
            return mas;
        }
        static void Main(string[] args)
        {
            MonkeyCount(5);
        }
    }
}
