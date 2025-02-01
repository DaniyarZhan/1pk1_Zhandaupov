namespace Task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m,
         * генерируется прямоугольный массив целых числе [n*m]. 
         * Заполнение случайными числами в диапазоне от -99 до 99 включительно.
         * Осуществите без создания нового массива 
         * преобразование текущего по следующему правилу:
         * • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
         * • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
         */
        static void Main(string[] args)
        {
            //запрашиваем размер массива
            Console.Write("Введите значение для числа: n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа: m = ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            //выведем массив с рандомными значениями
            int[,] ints = new int[n,m];
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(-99, 100);
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //выведем изменённый массив с цветовой подсветкой нулей и отрицательных чисел
            for (int i = 0;i < ints.GetLength(0); i++)
            {
                for(int j = 0;j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] < 0)
                    {
                        ints[i, j] = ints[i, j] * (-1);
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (ints[i, j] == 0)
                    {
                        ints[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(ints[i,j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
