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
            int[] startArray = new[] {0, 2, 1, 4, 9, 8, 5, 3, 7, 6 };
            int[] newArray = new int[10];
            int smallest;
            int smallestIndex;

            newArray = SelectionSort(startArray);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ");
            }

            Console.ReadKey();

            int[] SelectionSort(int[] tempArray)
            {

                for (int i = 0; i < newArray.Length; i++)
                {
                    smallest = FindSmallest(tempArray);
                    newArray[i] = smallest;
                }

                return tempArray;
            }

            int FindSmallest(int[] arr)
            {
                smallest = arr[0];
                smallestIndex = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < smallest)
                    {
                        smallest = arr[i];
                        smallestIndex = i;
                    }
                }
                        return smallestIndex;
            }

        }
    }
}
