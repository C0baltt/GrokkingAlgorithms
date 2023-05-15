using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] nums = new int[rand.Next(10,30)];
            int temp;

            Console.WriteLine($"The length of array: {nums.Length + 1}\n");

            Console.WriteLine("Array:");

            for (int i = 0; i < nums.Length ; i++)
            {
                Console.WriteLine(nums[i] = rand.Next(0,100));
            } 

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }

                }
            }

            Console.WriteLine("\nSorting array:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadKey();

        }
    }
}
