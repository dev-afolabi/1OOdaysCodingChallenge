using System;
using System.Collections.Generic;

namespace DontGiveMeFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int DontGiveMeFive(int start, int end)
        {

            List<int> values = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (i.ToString().Contains("5"))
                {
                    continue;
                }
                values.Add(i);
            }
            return values.Count;
        }
    }
}
