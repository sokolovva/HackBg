using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnagram
{
    class StringAnagram
    {
        static void Main(string[] args)
        {
            string strOne = Console.ReadLine();
            string strTwo = Console.ReadLine();
            Console.WriteLine(IsAnagram(strOne, strTwo));
        }
        static bool IsAnagram(string one, string two)
        {
            char[] arrStr1 = one.ToCharArray();
            char[] arrStr2 = two.ToCharArray();
            Array.Sort(arrStr1);
            Array.Sort(arrStr2);
            return arrStr1.SequenceEqual(arrStr2);
        }
    }
}
