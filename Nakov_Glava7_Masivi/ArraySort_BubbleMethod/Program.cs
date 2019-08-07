using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort_BubbleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] nums = new int[lenght];
            

            Console.WriteLine("Input array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"[{i}] = ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            
            Console.WriteLine("Unsorted array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-i; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int n = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = n;
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
