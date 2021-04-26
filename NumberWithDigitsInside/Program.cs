using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberWithDigitsInside
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersWithDigitInside(11, 1));
        }
        public static long[] NumbersWithDigitInside(long x, long d)
        {
            long[] result = new long[3];
            List<long> values = new List<long>(); 

            for (int i = 1; i <= x; i++)
            {
                if(i.ToString().Contains(d.ToString())  )
                {
                    values.Add(i);
                }
            }
            if(values.Count == 0)
                return result;
            result[0] = values.Count;
            result[1] = values.Sum();
            result[2] = values.Aggregate((acc, val) => acc * val);
            return result;
        }
    }
}
