using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        //метод для упражнения 1
        static int[] SortQuick(int[] array, int minindex, int maxindex) 
        {
            if (minindex >= maxindex)
            {
                return array;
            }
            int pivot_index = GetPivotIndex(array, minindex, maxindex);
            SortQuick(array, minindex, pivot_index - 1);
            SortQuick(array, pivot_index + 1, maxindex);
            return array;
        }
        static int GetPivotIndex(int[] array, int min_index, int max_index) //метод для получения pivot, разделяющего массив на подмассивы
        {
            int pivot = min_index - 1;
            for (int i = min_index; i <= max_index; i++)
            {
                if (array[i] < array[max_index])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[max_index]);
            return pivot;
        }
        static void Swap(ref int left_number, ref int right_number) //метод для обмена левого и правого числа
        {
            int swap = left_number;
            left_number = right_number;
            right_number = swap;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int elements = int.Parse(Console.ReadLine());
            int[] sequence = new int[elements];
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                sequence[i] = random.Next(100);
            }
            Console.WriteLine("Неотсортированный массив: \n" + string.Join(" ", sequence));
            int[] sorted_array = SortQuick(sequence, 0, sequence.Length - 1);
            Console.WriteLine("Отсортированный массив: \n" + string.Join(" ", sorted_array));
            //задание 2
            Console.WriteLine("task 2");
            

        }
    }

}
