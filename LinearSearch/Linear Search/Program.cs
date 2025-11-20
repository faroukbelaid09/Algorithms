using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static private int LinearSearch(int[] arr, int x)
        {
            for(int i = 0;i < arr.Length; i++)
            {
                if(arr[i] == x) return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5};
            int x = 5;

            int index = LinearSearch(arr, x);

            if (index != -1) 
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
