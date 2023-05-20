using System.Collections.Generic;
using System;

namespace GrokkingAlgorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> startArray = new List<int>() { 45, 15, 89, 10, 12 };

            int[] finalArray = SelectionSorting(startArray);

            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.WriteLine(finalArray[i]);
            }

            Console.ReadKey();

            int[] SelectionSorting(List<int> arr)
            {
                var newArr = new int[arr.Count];

                for (int i = 0; i < newArr.Length; i++)
                {
                    var smallestIndex = FindSmallest(arr);
                    newArr[i] = arr[smallestIndex];
                    arr.RemoveAt(smallestIndex);
                }
                return newArr;
            }

            int FindSmallest(List<int> arr)
            {
                var smallest = arr[0];
                var smallestIndex = 0;

                for (int i = 0; i < arr.Count; i++)
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