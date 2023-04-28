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
            int[] array = { 10, 11, 15, 19, 20 };

            int low = 0;
            int hight = array.Length - 1;
            int item = 15;
            int mid = array[0];

            while (low <= hight)
            {
                mid = low + hight;
                int guess = array[mid];

                if (guess == item)
                {
                    Console.WriteLine($"Искомый элемент {item} в массиве найден под номером {mid+1}");
                    break;
                }
                else if (guess > item)
                {
                    hight = mid - 1;
                }
                else 
                {
                low = mid + 1;
                }
            }

            Console.WriteLine(mid);
            Console.ReadKey();
        }
    }
}
