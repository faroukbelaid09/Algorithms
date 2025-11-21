using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void SelectionSortASC(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int MinIndex = i;

                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[MinIndex] > arr[j])
                    {
                        MinIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[MinIndex];
                arr[MinIndex] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0;i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 14, 2, 30, 50, 10, 25, 5, 70};

            Console.WriteLine("Original Array: ");
            PrintArray(arr);

            SelectionSortASC(arr);

            Console.WriteLine("\n\nSorted Array Using Selection Sort:");
            PrintArray(arr);
        }
    }
}
