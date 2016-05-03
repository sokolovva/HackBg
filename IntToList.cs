using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToList
{
    class IntToList
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer: ");
            int integer = int.Parse(Console.ReadLine());

            var list = IntToList(integer);
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine();

            Console.WriteLine(IntToList(integer));


        }
        private static List<int> IntToList(int integer)
        {
            List<int> integers = new List<int>();
            while (integer != 0)
            {
                integers.Add(integer % 10);
                integer = integer / 10;
            }

            integers.Reverse();
            return integers;
        }
    }
    }

