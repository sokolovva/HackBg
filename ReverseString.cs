using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string str = Console.ReadLine();
            Console.WriteLine(ReverseMe(str));

           

        }
        private static string ReverseMe(string input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = input.Length-1;  i>=0 ;  i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();

        }
    }
}
