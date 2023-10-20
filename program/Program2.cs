using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание многомерного массива 
            int[,,] multiArray = new int[4, 3, 2];

            // Создание экземпляра класса Random
            Random random = new Random();

            // Заполнение массива случайными числами в диапазоне 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        multiArray[i, j, k] = random.Next(-20, 21);
                    }
                }
            }

            // Нахождение минимального элемента
            int minElement = multiArray[0, 0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (multiArray[i, j, k] < minElement)
                        {
                            minElement = multiArray[i, j, k];
                        }
                    }
                }
            }

            // Вывод минимального элемента
            Console.WriteLine("Минимальный элемент в массиве: " + minElement);
        }
    }
}
