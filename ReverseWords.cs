using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string str = Console.ReadLine();
            Console.WriteLine(ReverseWordsInString(str));
            
        }
        private static string ReverseWordsInString(string input)
        {
            string[] words = input.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                builder.Append(ReverseMe(word));
                builder.Append(" ");
            }
            return builder.ToString(); 
 
        }
        private static string ReverseMe(string input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();

        }
    }
}
