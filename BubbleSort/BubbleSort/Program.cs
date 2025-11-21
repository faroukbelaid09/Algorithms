using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArr(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 30, 50, 25, 10, 60};

            Console.WriteLine("Original Array:");
            PrintArr(arr);

            BubbleSort(arr);

            Console.WriteLine("\n\nSorted Array Using Bubble Sort:");
            PrintArr(arr);
        }
    }
}
