using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasAnagram
{
    class AnagramSubsequence
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            Console.WriteLine(HasAnagrams(firstWord,secondWord));
        }
        static bool HasAnagrams(string one, string two)
        {
            int counter = 0;
            char[] arr1 = one.ToCharArray();
            char[] arr2 = two.ToCharArray();
            for (int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {

                    if (arr1[i] == arr2[j])
                    {
                        counter++;
                        break;

                    }

                    if (counter == arr1.Length)
                    {
                        return true;
                    }

                }
            }
            return false;



        }
    }
    
}
