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

            int[] nums = new int[rand.Next(10,16)];
            int temp;
            int elementNumberInTheOutput = 1;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Array:");

            for (int i = 0; i < nums.Length ; i++)
            {
                nums[i] = rand.Next(0,50);

                WriteArrayElement(i);
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
            
            elementNumberInTheOutput = 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nSorting array:");

            for (int i = 0; i < nums.Length; i++)
            {
                WriteArrayElement(i);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nThe number of array elements: {nums.Length}\n");

            Console.ReadKey();

            void WriteArrayElement(int index)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{index}: ");
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{nums[index]}");
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" || ");

                if (elementNumberInTheOutput > 9)
                {
                    elementNumberInTheOutput=1;
                    Console.WriteLine();
                }
                elementNumberInTheOutput++;
                   // Console.WriteLine();
            }
        }
    }
}
