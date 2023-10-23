using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива с 30 случайными элементами
            int[] myArray = new int[30];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 101); // Заполняем случайными числами от 0 до 100
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(myArray);

            // Сортировка пузырьком
            BubbleSort(myArray);

            Console.WriteLine("Отсортированный массив:");
            PrintArray(myArray);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Обмен элементов, если они находятся в неправильном порядке
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        /* Метод для вывода элементов массива в консоль.
         Принимает массив `arr` в качестве аргумента и печатает его элементы, разделенные пробелами.
         Этот метод упрощает вывод содержимого массива, чтобы не дублировать код для вывода в нескольких местах программы.*/
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
