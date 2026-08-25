using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        static int LinearSearch(int[]arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 14, 17, 21, 26, 29, 30, 42 };
            int target = 26;
            int index = LinearSearch(numbers, target);

            if(index != -1)
            {
                Console.WriteLine("Number found at index no : " + index);
            }

            else
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
