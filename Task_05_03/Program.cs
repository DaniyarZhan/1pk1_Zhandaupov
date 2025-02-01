namespace Task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами
         * английского алфавита размером 3*3. 
         * Проверить, являются ли матрицы равными, 
         * если да, то вывести сообщение о том,
         * что они равны, если нет, 
         * то вывести повторно матрицы с цветовой индикацией
         * только тех элементов, которые равны. 
         * (матрицы считаются равными, если их соответствующие элементы равны.
         * Пример:
         * f h h f c h
         * w g k m g z
         * a f j a o d
         * =>
         * f h h f c h
         * w g k m g z
         * a f j a o d
         */
        static void Main(string[] args)
        {
            //создаем двумерный массив
            char[,] chars = new char[3, 3];
            char[,] chars1 = new char[3, 3];
            Random rnd = new Random();
            //заполняем первый массив данными
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    chars[i, j] = (char)rnd.Next(97, 123);
                    Console.Write(chars[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int i = 0; i < chars1.GetLength(0); i++)
            {
                for (int j = 0; j < chars1.GetLength(1); j++)
                {
                    chars1[i, j] = (char)rnd.Next(97, 123);
                    Console.Write(chars1[i, j] + " ");
                }
                Console.WriteLine();
            }
            bool isRav = true;
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i,j] != chars1[i,j])
                    {
                        isRav = false;
                        break;
                    }
                }
            }
            //посмотрим, чему равно isCentralSimmetric
            Console.WriteLine(isRav);
            Console.WriteLine("---------------");
            if (isRav == false)
            {
                for (int i = 0; i < chars.GetLength(0); i++)
                {
                    for (int j = 0; j < chars.GetLength(1); j++)
                    {
                        if (chars[i, j] == chars1[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(chars[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < chars1.GetLength(0); i++)
                {
                    for (int j = 0; j < chars1.GetLength(1); j++)
                    {
                        if (chars[i, j] == chars1[i, j])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(chars1[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрицы равны");
            }

        }
    }
}
