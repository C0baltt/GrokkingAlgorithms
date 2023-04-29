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
            int[] array = { 10, 11, 15, 19, 20, 25, 30, 36, 68, 84 };

            int low = 0;
            int hight = array.Length - 1;
            int item = 25;
            int i = 0;

            while (low <= hight)
            {
                ++i;
                int mid = (low + hight)/2;
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

            Console.WriteLine($"Количество итераций {i}");

        //    Console.WriteLine(mid);
            Console.ReadKey();
        }
    }
}
