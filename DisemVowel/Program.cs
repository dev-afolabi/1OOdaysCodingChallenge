using System;
using System.Linq;

namespace DisemVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("Hello World!"));
        }
        public static string Disemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            return String.Join("",str.ToLower().Where(c => !vowels.Contains(c)).ToArray());
        }
    }
}
