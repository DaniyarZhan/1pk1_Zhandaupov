using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n,
         * генерируется квадратный массив целых числе [n*n].
         * Заполнение случайными числами в диапазоне от 10 до 99 включительно.
         * Найти и вывести отдельно минимальный элемент в матрице 
         * (LINQ под запретом) Осуществить умножение матрицы на ее 
         * минимальный элемент, при выводе цветом выделить 
         * пять максимальных значений в массиве
         */
        static void Main(string[] args)
        {
            //просим пользователя ввести размер массива
            Console.Write("Введите размер массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] ints = new int[n, n];
            Random rnd = new Random();
            //введём значения в массив
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(10, 100);
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
            //для нахождения минимального числа
            int c = 100;
            for (int i = 0;i < ints.GetLength(0); i++)
            {
                for(int j = 0;j < ints.GetLength(1); j++)
                {
                    
                    if (ints[i,j] < c)
                    {
                        c = ints[i,j];
                    }
                } 
            }
            Console.WriteLine("Минимальный элемент в матрице: " + c);
            //количество максимальных значений
            int[] b = new int[5];
            //для нахождения больших чисел
            Console.WriteLine("Зелёным выделены 5 максимальных значений");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] *= c;
                }
            }
            Console.Write("Максимальные значения в матрице: ");
            int d = 0;
            for (int i = 0; i < b.Length; i++) // Вычисление макс. значений
            {
                foreach (int a in ints)
                {
                    // Не добавлять элементы, которые больше или равны уже присутствующим в массиве,
                    // чтобы записать в массив при повторном прохождении
                    if (i > 0 && a >= b[i - 1])
                    {
                        d++;
                        break;
                    }
                    if  (a > b[i] && d == 0)
                    {
                        b[i] = a;                            
                    }
                    else if (a > b[i] && d == 1)
                    {
                        if (b[i-1] > b[i])
                        {
                            b[i] = a;
                        }
                        else
                        {

                        }
                        
                    }
                    else if (a > b[i] && d == 2)
                    {
                        b[i] = a;
                    }
                    else if (a > b[i] && d == 3)
                    {
                        b[i] = a;
                    }
                    else if (a > b[i] && d == 4)
                    {
                        if (b[i - 4] < b[i])
                        {
                            b[i] = a;

                        }
                    }
                }
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    foreach (int maxNum in b)
                    {
                        if (ints[i, j] == maxNum)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                    }
                    Console.Write(ints[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
