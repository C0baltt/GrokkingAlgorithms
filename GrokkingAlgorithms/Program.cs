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
            int num = 68;

            string result = BinarySearch(array, num);

            string BinarySearch(int[] _array, int item)
            {
                int i = 0;
                int low = 0;
                int hight = _array.Length - 1;

                while (low <= hight)
                {
                    ++i;
                    int mid = (low + hight) / 2;
                    int guess = _array[mid];

                    if (guess == item)
                    {
                        return $"Номер элемента {++mid}, количество итераций {i} ";
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
                
                return $"Элемент не найден, количество итераций {i}";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
