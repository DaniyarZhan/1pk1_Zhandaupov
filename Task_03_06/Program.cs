namespace Task_03_06
{
    internal class Program
    {
        /* Написать программу,
         * которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4,
         * с шагом h = 0,5.
         */
        static void Main(string[] args)
        {
            //напишем шапочку для таблицы
            Console.WriteLine($"Таблица значений функции y=|x| для -4<=x<=4, с шагом h = 0,5");
            Console.WriteLine("\n_______________________________________________________________________________________");
            Console.WriteLine("\tx" + "\t|y" );
            double h = 0.5;
            //выведем значения x и y
            for (double x = -4; x <= 4; x += h)
            {
                double y = Math.Abs(x);
                Console.Write("\t" + x + "\t|");
                Console.WriteLine(y);
            }
        }
    }
}
