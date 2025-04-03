using System.Threading.Channels;

namespace Task_20_01
{
    enum Day
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    internal class Program
    {
        /*Создайте enum для дней недели (Monday–Sunday).
         * Напишите программу, которая:
         * Принимает от пользователя число (1–7).
         * Преобразует его в день недели.
         * Выводит сообщение:
         *  "Будний день" (для Monday–Friday).
         *  "Выходной" (для Saturday, Sunday
         */
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня в неделе от 1 до 7: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Day day1 = (Day)day;
            if (day1 == Day.Monday || day1 == Day.Tuesday || day1 == Day.Wednesday || day1 == Day.Thursday || day1 == Day.Friday)
                Console.WriteLine("Будний день");
            else if (day1 == Day.Saturday || day1 == Day.Sunday)
                Console.WriteLine("Выходной");
            else Console.WriteLine("Неправильные данные");
        }
    }
}
