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
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            Ex5();
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

        static void Ex2()
        {
            //Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
            int[] arr = { 2, 5, 7 };
            int[] arr2 = new int[arr.Length];
            int count = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr2[count] = arr[i];
                count++;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"{j} : {arr[j]} , {arr2[j]}");
            }
        }

        static void Ex3()
        {
            //Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 2, 5, 8 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        static void Ex4()
        {
            //Write a program in C# Sharp to copy the elements one array into another array.
            int[] arr = { 15, 10, 12 };
            int[] arrCopy = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
                Console.WriteLine($"{arr[i]}, {arrCopy[i]}");
            }
        }

        static void Ex5()
        {
            //Write a program in C# Sharp to count a total number of duplicate elements in an array.
            int[] arr = { 5, 2, 7, 7, 5, };
            int dupe = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int repeat = 0;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        repeat++;
                    }
                }
                if (repeat == 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            dupe++;
                        }
                    }
                }
            }
            Console.WriteLine(dupe);
        }
    }
}
