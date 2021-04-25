using System;

namespace FindDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int FindDifference(int[] a, int[] b)
        {
            //loading...
            int sumA = 0;
            int sumB = 0;

            foreach (var item in a)
            {
                sumA+=item;
            }
            foreach (var item in b)
            {
                sumB+=item;
            }
            return Math.Abs(sumA - sumB);
        }
    }
}
