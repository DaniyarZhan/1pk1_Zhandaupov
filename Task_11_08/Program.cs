namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out:
         * Напишите метод, который принимает 
         * переменное количество чисел и возвращает их сумму
         * и максимальное значение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            int summ = 0;
            int maxval = 0;
            Numbers(out summ, out maxval, 1, 3);
            Console.WriteLine($"Сумма чисел: {summ} и максимальное число: {maxval}");
            Numbers(out summ, out maxval, 12, 25, 34, 25, 35, 2);
            Console.WriteLine($"Сумма чисел: {summ} и максимальное число: {maxval}");
            Numbers(out summ, out maxval, 56, 52, 63, 85, 2);
            Console.WriteLine($"Сумма чисел: {summ} и максимальное число: {maxval}");
            Numbers(out summ, out maxval, new int[3]);
            Console.WriteLine($"Сумма чисел: {summ} и максимальное число: {maxval}");
            Numbers(out summ, out maxval, new int[] { 1, 2, 3, 5, 15, 2 });
            Console.WriteLine($"Сумма чисел: {summ} и максимальное число: {maxval}");
        }
        /// <summary>
        /// Числа
        /// </summary>
        /// <param name="sum">сумма чисел</param>
        /// <param name="maxvalue">максимальное число</param>
        /// <param name="numbers">числа</param>
        /// <returns></returns>
        public static int Numbers(out int sum, out int maxvalue, params int[] numbers)
        {
            maxvalue = 0;
            sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
                if (number > maxvalue)
                {
                    maxvalue = number;
                }
            }
            return maxvalue;
        }
    }
}
