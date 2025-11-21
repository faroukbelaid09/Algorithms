using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int x)
        {
            int start = 0;
            int end = arr.Length -1;
            
            while(start <= end)
            {
                int middle = start + (end - start) / 2;

                if (x == arr[middle]) return middle;

                if (x > arr[middle])
                {
                    start = middle + 1;
                    continue;
                }

                if (x < arr[middle])
                {
                    end = middle - 1;
                    continue;
                }
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};

            int index = BinarySearch(arr, 7);

            if(index != -1)
            {
                Console.WriteLine("Element was found at position: " + index);
            }
            else
            {
                Console.WriteLine("Element was not found.");
            }
        }
    }
}