using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_10_06
{
    /*Создать Метод ArrayGeneration не возвращающий значения, 
     * принимает целое число n, 
     * выводит на консоль сгенерированный массив размерности n*n.
     */
    internal class Program
    {
        /// <summary>
        /// создание и заполнение массива размерности n*n, где n - целое число
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            ArrayGeneration(array,' ');
        }
        /// <summary>
        /// вывод массива без возврата значений
        /// </summary>
        /// <param name="massive">значение массива</param>
        /// <param name="separator">разделитель чисел</param>
        public static void ArrayGeneration(int[,] massive, char separator)
        {
            Random random = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = random.Next(10, 100);
                    Console.Write(massive[i,j] + separator.ToString());
                }
                Console.WriteLine();
            }
                

        }
        
        
    }
}
