using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtremeElements
{
    class ExtremeElements
    {
        static void Main(string[] args)
        {
            Console.Write("How many element will you would like to compare? ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
         

            for (int i = 0; i < n; i++)
            {
                array[i] =int.Parse(Console.ReadLine());

            }
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < n; i++)
            {
                if(min > array[i]) min = array[i];
                if (max < array[i]) max = array[i];
            }
            Console.WriteLine($"Min number is: {min}");
            Console.WriteLine($"Max number is: {max}");

          
            Console.Write("Nth min: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("How many element will you would like to compare? ");
            int numbers = int.Parse(Console.ReadLine());
            int[] array1 = new int[numbers];


            NthMin(numbers,array1,number);

            NthMax(numbers, array1,number);




        } 
        private static void NthMin (int n, int []arr, int number)
        {


            for (int i = 0; i <n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);


            Console.WriteLine(arr[number]);




        } 
        private static void NthMax(int n,int [] array1, int number)
        {

            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(array1);
            Array.Reverse(array1);
            Console.WriteLine(array1[number]);
         
        }
     
    }
}
