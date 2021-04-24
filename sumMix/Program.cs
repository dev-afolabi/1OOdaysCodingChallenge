using System;
using System.Linq;

namespace sumMix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumMix(new object[] {9, 3, "7", "3"}));
        }

        public static int SumMix(object[] x)
        {
            return x.Select(c => int.Parse(c.ToString())).Sum();
        }
    }
}
