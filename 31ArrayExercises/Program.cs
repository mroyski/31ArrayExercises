using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }
        static void Ex1()
        {
            //Write a program in C# Sharp to store elements in an array and print it.
            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
