using System.Runtime.InteropServices;

namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает 
         * одномерный массив и число для поиска, 
         * верните индекс искомого элемента в массиве. 
         * Если элемента нет – верните индекс = -1
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер одномерного массива - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какое число искать? ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Search(Massive(a),s));
            
        }
        /// <summary>
        /// Одномерный массив
        /// </summary>
        /// <param name="c">количество чисел в массиве(a)</param>
        /// <returns>входные данные массива(Massive)</returns>
        public static int[] Massive(int c)
        {
            int[] massive = new int[c];
            Random random = new Random();
            for (int i = 0; i < c; i++)
            {
                massive[i] = random.Next(1,101);
                Console.Write(massive[i] + " ");  
            }
            Console.WriteLine();
            return massive;
        }

        /// <summary>
        /// Поиск определённого числа(s)
        /// </summary>
        /// <param name="massive">массив, в котором ищут это число(Massive(a))</param>
        /// <param name="b">искомое число(s)</param>
        /// <returns>индекс искомого числа s (i)</returns>
        public static int Search(int[] massive, int b)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] == b)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
