using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Task_04_09
{
    /*В массиве найти элементы,
     * которые в нем встречаются только один раз,
     * и вывести их на экран. 
     * То есть найти и вывести уникальные элементы массива.
     * (LINQ использовать нельзя)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //введём данные для массива
            Console.Write("Введите количество значений в массиве: ");
            int massiv = int.Parse(Console.ReadLine());
            Console.Write("Введите начальное значение в массиве: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[massiv];
            Random rnd = new Random();

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(m, n);
            }
            //выведем уникальные элементы массива
            Console.WriteLine("Уникальные элементы массива: ");
            for (int i = 0; i < ints.Length; i++)
            {
                int numbers = 0;
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j]) 
                    numbers++;
                }
                if (numbers == 1) Console.Write(ints[i] + " ");
            }
        }
    }
}
