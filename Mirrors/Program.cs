using System;
using System.Linq;

namespace Mirrors
{
    class Program
    {
        delegate string del (string n);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    
        public static string VertMirror(string strng)
        {
            string value ="";
            foreach (var item in strng.Split('\n'))
            {
                value += item.Reverse();
                value += '\n';
            }
            return value.TrimEnd('\n');
        
        }

        
        public static string HorMirror(string strng)
        {
            string value = string.Join('\n',strng.Split('\n').Reverse());

            return value.TrimEnd('\n');
        }

        public static string Oper(, string s)
        {
            // your code and complete ... before operator
        }
    }
}
