namespace Task_03_09
{
    internal class Program
    {
        /*Вклад в банке составляет x рублей.
         * Ежегодно он увеличивается на p процентов,
         * после чего дробная часть копеек отбрасывается.
         * Каждый год сумма вклада становится больше.
         * Определите, через сколько лет вклад составит не менее y рублей. 
         * Примеры
         * входные данные
         * 100
         * 10
         * 200
         * выходные данные
         * 8
         */
        static void Main(string[] args)
        {
            //введем наши переменные для расчета вклада
            Console.WriteLine("введите вклад в банке x рублей: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("введите процент p: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("введите конечный вклад y рублей: ");
            int y = int.Parse(Console.ReadLine());
            int countYear = 0; //вводим счетчик количество лет
            while (y > x)
            {
                x = x + (int)(x * p / 100);
                countYear++;
            }
            Console.WriteLine("через " + countYear + " лет вклад составит больше " + y + " рублей");
        }
    }
}
