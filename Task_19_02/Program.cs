using static System.Net.Mime.MediaTypeNames;

namespace Task_19_02
{
    internal class Program
    {
        /*2.Напишите программу, которая запрашивает у пользователя произвольный текст,
         * содержащий предложения (есть знаки препинания). 
         * программу после анализа выводит текст, разделенный на части:
            a)По пробелам (отдельные слова построчно)
            b)По предложениям (отдельные предложения построчно)
            (используйте метод Split())
         */
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();
            char[] separator = { ' ', '.', ',', '!', '?', ';', '"', '@', '#', '/' };
            // Разделить строку на части
            string[] parts = str.Split(separator);
            Console.WriteLine("Результат разделения строки по пробелам: ");
            for (int i = 0; i <= (parts.Length - 1); i++)
                    Console.WriteLine(parts[i]);
            // Разделить строку на части
            char[] separator1 = { '.', '!', '?' };
            string[] parts1 = str.Split(separator1);
            Console.WriteLine("Результат разделения строки по предложениям: ");
            for (int i = 0; i <= (parts1.Length - 1); i++)
                Console.WriteLine(parts1[i]);
        }
    }
}
