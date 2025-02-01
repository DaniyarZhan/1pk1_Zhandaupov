namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n.
         * Произведите анализ данной матрицы и 
         * выясните является ли данная матрица
         * диагональной (все элементы вне главной диагонали равны нулю)
         * Если матрица является диагональной, 
         * то вывести ее повторно с цветовым выделением главной диагонали.
         * Если нет, то вывести сообщение что матрица не является диагональной. 
         */
        static void Main(string[] args)
        {
            //введём размер массива с консоли
            Console.Write("Введите размер квадратного массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] ints = new int[n,n];
            //введём значения в массив
            Random rnd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(0,2);
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] vectorMainDiagonal = new int[n];//значения главной диагонали
            int summMainDiagonal = 0;//cумма значений главной диагонали
            int summ = 0;//сумма всех значений массива
            //выделим главную диагональ
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    summ += ints[i, j];
                    if (i == j)
                    {
                        vectorMainDiagonal[i] = ints[i, j];
                        summMainDiagonal += ints[i,j];
                        Console.Write(vectorMainDiagonal[i] + " ");
                    }
                }
            }
            Console.WriteLine("- Значения главной диагонали");//выведем значения главной диагонали
            Console.WriteLine(summ + " - сумма всех значений массива");//выведем сумму всех значений
            Console.WriteLine(summMainDiagonal + " - сумма значений главной диагонали");//выведем сумму значений главной диагонали
            //проверим, есть ли нулевые значения на главной диагонали
            bool isMainDiagonal = true;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (vectorMainDiagonal[i] == 0)
                    {
                        isMainDiagonal = false;
                        break;
                    }
                }
            }
            //проверяем на диагональность матрицу, если да, то выделим цветом гланую диагональ
            if (summ == summMainDiagonal && isMainDiagonal == true)
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
                Console.WriteLine("Матрица не является диагональной");
            }
        }
    }
}
