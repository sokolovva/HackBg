using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyCharacters
{
    class CopyCharacters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Word: ");
            string input = Console.ReadLine();
            Console.WriteLine(CopyEveryChar(input,n));

           
        }
        private static string CopyEveryChar (string word, int k)
        {
            
            StringBuilder builder = new StringBuilder();
            foreach (var item in word)
            {


                for (int i = 0; i < k; i++)
                {
                    builder.Append(item);
                }

               
            }
            return builder.ToString();
        }
    }
}
