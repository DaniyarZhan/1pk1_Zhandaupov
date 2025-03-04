namespace Task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): 
         * Напишите метод, который принимает массив чисел 
         * и возвращает их среднее значение. 
         * Используйте ключевое слово params
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Среднее значение массива чисел: " + ArithmeticMean(new int[] { 1, 3}));
            Console.WriteLine("Среднее значение массива чисел: " + ArithmeticMean(new int[] { 12, 25, 34, 25, 35, 2}));
            Console.WriteLine("Среднее значение массива чисел: " + ArithmeticMean(new int[] { 56, 52, 63, 85, 2}));
            Console.WriteLine("Среднее значение массива чисел: " + ArithmeticMean(new int[3] ));
            Console.WriteLine("Среднее значение массива чисел: " + ArithmeticMean(new int[] {1, 2, 3, 5, 15, 2}));
        }
        /// <summary>
        /// Среднее значение массива чисел
        /// </summary>
        /// <param name="array">массив чисел</param>
        /// <returns>Среднее значение каждого массива</returns>
        public static int ArithmeticMean(params int[] array)
        {
            int summ = 0;
            int count = 0;
            foreach (int i in array)
            {
                summ += i;
                count++;
            }
            return  summ/count ;
        }
    }
}
