using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgaria2
{
    class ListToInt
    {
        static void Main(string[] args)
        { 
           

            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            Console.WriteLine(ListToInteger(input));


        }
    
         private static int ListToInteger(string num)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in num)
            {
                builder.Append(item);
            }

            int result = int.Parse(builder.ToString());
            return result;
        }
    }
}
