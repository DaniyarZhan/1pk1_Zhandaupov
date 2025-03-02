namespace Task_10_07
{
    /*Создайте метод с помощью которого можно сгенерировать 
     * и вернуть символьный двумерный массив
     * (состоящий из символов русского алфавита) и 
     * выведите на консоль данный массив с помощью другого метода
     * (который принимает данный массив в качестве параметра)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива по горизонтали - ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер массива по вертикали - ");
            int j = Convert.ToInt32(Console.ReadLine());
            PrintCharArray(RussianAlphabet(i,j));
        }
        /// <summary>
        /// Ввод размера массива
        /// </summary>
        /// <param name="n"> длина </param>
        /// <param name="k"> ширина </param>
        /// <returns>заполненный массив</returns>
        public static char [,] RussianAlphabet(int n, int k)
        {
            Random rnd = new Random();
            char c = 'а';
            char d = 'я';
            char[,] letters = new char[n,k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    letters[i,j] = (char)rnd.Next(c,d + 1);
                }
            }
            return letters;
        }
        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="arr">массив букв</param>
        public static void PrintCharArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
