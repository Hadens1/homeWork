using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5]; // Создаем массив из 5 элементов

            // Добавляем 5 элементов в массив
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = i * 10; 
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(myArray);

            // Удаляем массив
            myArray = null;

            Console.WriteLine("Массив после удаления: " + myArray);

           
            Random random = new Random();
            myArray = new int[12];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 101); 
            }

            Console.WriteLine("Массив после создания и заполнения случайными числами от 0 до 100:");
            PrintArray(myArray);
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
