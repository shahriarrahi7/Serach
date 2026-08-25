using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 14, 17, 21, 26, 29, 30, 42 };
            int target = 14;
            int index = BinarySearch(numbers, target);

            if (index != -1)
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
