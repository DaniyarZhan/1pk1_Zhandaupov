namespace Task_03_05
{
    internal class Program
    {
        /* Написать программу, 
         * которая выводит на экран 
         * таблицу соответствия температуры
         * в градусах Цельсия и Фаренгейта(F = C * 1,8 + 32).
         * Диапазон изменения температуры в градусах Цельсия
         * и шаг должны вводиться во время работы программы
         */
        static void Main(string[] args)
        {
            //введем диапазон значений по Цельсию для таблицы
            Console.WriteLine("Введите начальное значение tmin по Цельсию: ");
            double tmin = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение tmax по Цельсию: ");
            double tmax = double.Parse(Console.ReadLine());
            //введем шаг, на который должен увеличиваться значение
            Console.WriteLine("Введите шаг изменения значения по Цельсию: ");
            double step = double.Parse(Console.ReadLine());
            Console.Clear();
            //напишем шапочку для таблицы
            Console.WriteLine("Таблица соответствия в градусах Цельсия и Фаренгейта");
            Console.WriteLine("C\t|F");
            for (double C = tmin;C<=tmax;C+=step)
            {
                double F = C * 1.8 + 32.0;
                Console.Write(Math.Round(C,2) + "\t|");
                Console.WriteLine(Math.Round(F,2));
            }
        }
    }
}
