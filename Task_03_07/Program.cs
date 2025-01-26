namespace Task_03_07
{
    internal class Program
    {
        /*Написать программу,
         * которая выводит таблицу скорости (через каждые 0,5с)
         * свободно падающего тела v = g * t , 
         * где g = 9,8 м/с2 – ускорение свободного падения.
         */
        static void Main(string[] args)
        {
            //введем конечное значение времени t
            Console.Write("Введите конечное значение времени t: ");
            double i = double.Parse(Console.ReadLine());
            //напишем шапочку для таблицы
            Console.WriteLine("Таблица скорости (через каждые 0,5с) свободно падающего тела");
            Console.WriteLine("____________________________________________________________");
            double g = 9.8;
            double a = 0.5;
            Console.WriteLine("t" + "\t|v");
            for (double t = 0; t <= i; t += a)
            {
                double v = g * t;
                Console.Write(t + "\t|");
                Console.WriteLine(Math.Round(v,2));
            }
        }
    }
}
