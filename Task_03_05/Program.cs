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
            Console.WriteLine("Введите диапазон значений t по Цельсию: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг изменения значения по Цельсию: ");
            double step = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Таблица соответствия в градусах Цельсия и Фаренгейта");
            for (double C = 0;C<t;C+=step)
            {
                double F = C * 1.8 + 32.0;
                Console.Write(Math.Round(C) + "\t|");
                Console.WriteLine(F);
            }
            
        }
    }
}
