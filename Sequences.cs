using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{
    class Sequences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            List<int> input = new List<int>();
            string number = null;

            while ((number = Console.ReadLine()) != string.Empty)
            {
                input.Add(int.Parse(number));
            }
            int[] array = input.ToArray();

            Console.Write("The number are in increasing line? ");
            Console.WriteLine(IsIncreasing(array));
            Console.Write("The number are in decreasing line? ");
            Console.WriteLine(IsDecreasing(array));


        }


        static private bool IsIncreasing(int [] arr)

        { 
            for (int i = 0; i < arr.Length-1-1; i++)
            {
                if (arr[i] > arr[i + 1]) 
                {
                    return false;
                }
              
            }
            return true;

        }
        static private bool IsDecreasing(int[] arr)

        {
            for (int i = 0; i < arr.Length - 1 - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
        }
    }
