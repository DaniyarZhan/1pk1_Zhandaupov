namespace Task_05_09
{
    /*Дан квадратный массив размерность n*n.
     * Произведите анализ данной матрицы 
     * и выясните является ли данная матрица Z-матрицей
     * (это матрица, где все недиагональные элементы меньше нуля)
     * Если данное условие выполняется, 
     * то вывести данную матрицу с цветовой индикацией главной диагонали.
     * Если не выполняется, то вывести сообщение,
     * что данная матрица не является Z-матрицей 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //введём размер массива с консоли
            Console.Write("Введите размер квадратного массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] ints = new int[n, n];
            //введём значения в массив
            Random rnd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(-2, 2);
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] vectorMainDiagonal = new int[n];//значения главной диагонали
            int[] vectorSideDiagonal = new int[n];//значения побочной диагонали            
            int[] ints1 = new int[n];//все остальные значения
            //выделим главную диагональ
            Console.Write("Значения главной диагонали: ");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        vectorMainDiagonal[i] = ints[i, j];
                        Console.Write(vectorMainDiagonal[i] + ", ");
                    }
                }
            }
            Console.WriteLine();
            //выделим побочную диагональ
            Console.Write("Значения побочной диагонали: ");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (i == n - j - 1)
                    {
                        vectorSideDiagonal[i] = ints[i, j];
                        Console.Write(vectorSideDiagonal[i] + ", ");
                    }
                }
            }
            Console.WriteLine();
            //выделим все остальные значения
            Console.Write("Все значения не на диагоналях: ");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (i != n - j - 1 && i != j)
                    {
                        ints1[i] = ints[i, j];
                        Console.Write(ints1[i] + ", ");
                    }
                } 
            }
            Console.WriteLine(); 
            //проверим, есть ли отрицательные значения на диагоналях
            //и положительные значения на не диагоналях
            bool isDiagonal = true;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (vectorMainDiagonal[i] < 0 || vectorSideDiagonal[i] < 0  || ints1[i] >= 0)
                    {
                        isDiagonal = false;
                        break;
                    }
                }
            }

            //проверим на Z-матрицу, если да, то выделим цветом главную диагональ
            if (isDiagonal == true)
            {
                for (int i = 0; i < ints.GetLength(0); i++)
                {
                    for (int j = 0; j < ints.GetLength(1); j++)
                    {
                        if (ints[i, j] == vectorMainDiagonal[i])
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(ints[i, j]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрица не является Z-матрицей");
            }
        }
    }
}
