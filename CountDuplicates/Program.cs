using System;
using System.Collections.Generic;

namespace CountDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("Indivisibilities"));
        }

        public static int DuplicateCount(string str)
        {
            char[] temp = str.ToLower().ToCharArray();

            Dictionary<char,int> dict = new Dictionary<char, int>();
            int maxCount = 0;
            foreach (var item in temp)
            {
                if(dict.ContainsKey(item))
                {
                    ++dict[item];
                }
                else{
                    dict[item] = 1;
                }
            }
            foreach (var item in dict.Values)
            {
                if(item > 1)
                    ++maxCount;
            }

            return maxCount;
        }
    }
}
