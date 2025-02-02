namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерацию двумерного [10*5] 
         * массива по следующему правилу:
         * • 1 столбец содержит нули
         * • 2 столбец содержит числа кратные 2
         * • 3 столбец содержит числа кратные 3
         * • 4 столбец содержит числа кратные 4
         * • 5 столбец содержит числа кратные 5
         * Осуществить переворот массива 
         * (поменять строки и столбцы местами) 
         * вывести обновленный массив 
         */
        static void Main(string[] args)
        {
            int[,] massiv = new int[10, 5];
            Random rnd = new Random();
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        massiv[i, j] = 0;
                    }
                    else if (j == 1)
                    {
                        massiv[i,j] = 2 * rnd.Next(-99,100);
                        if (massiv[i,j] == 0)
                        {
                            massiv[i,j] += 2;
                        }
                        
                    }
                    else if (j == 2)
                    {
                        massiv[i, j] = 3 * rnd.Next(-99, 100);
                        if (massiv[i, j] == 0)
                        {
                            massiv[i, j] += 3;
                        }
                    }
                    else if (j == 3)
                    {
                        massiv[i, j] = 4 * rnd.Next(-99, 100);
                        if (massiv[i, j] == 0)
                        {
                            massiv[i, j] += 4;
                        }
                    }
                    else if (j == 4)
                    {
                        massiv[i, j] = 5 * rnd.Next(-99, 100);
                        if (massiv[i, j] == 0)
                        {
                            massiv[i, j] += 5;
                        }
                    }
                    Console.Write(massiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            //делаем транспонирование матрицы
            Console.WriteLine("\nТранспонированная матрица:\n");
            int[,] transponedNumbers = new int[5, 10];

            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    transponedNumbers[j, i] = massiv[i, j];
                }
            }
            //вывод транспонированной матрицы
            for (int i = 0; i < transponedNumbers.GetLength(0); i++)
            {
                if (i == 0)
                {
                    Console.Write("Нули: ");
                }
                else
                {
                    Console.Write($"Числа, кратные {i + 1}: ");
                }
                
                for (int j = 0; j < transponedNumbers.GetLength(1); j++)
                {
                    Console.Write(transponedNumbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
