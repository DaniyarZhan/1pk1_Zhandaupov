using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): 
         * Напишите метод, который принимает строку 
         * и возвращает через выходной параметр 
         * количество гласных и согласных букв в этой строке
         */
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Stroke(str, out consonant, out vowel);
            Console.WriteLine("Количество согласных букв - " + consonant);
            Console.WriteLine("Количество гласных букв - " + vowel);
        }
        /// <summary>
        /// Согласные буквы
        /// </summary>
        public static string consonant_letters = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxz";
        /// <summary>
        /// Гласные буквы
        /// </summary>
        public static string vowel_letters = "аеёиоуыэюяaeiouy";
        /// <summary>
        /// Количество гласных букв
        /// </summary>
        public static int vowel = 0;
        /// <summary>
        /// Количество согласных букв
        /// </summary>
        public static int consonant = 0;
        /// <summary>
        /// Строка, введённая с консоли
        /// </summary>
        /// <param name="str1">строка</param>
        /// <param name="cons">кол-во согласных букв</param>
        /// <param name="vow">кол-во гласных букв</param>
        public static void Stroke(string str1, out int cons, out int vow)
        {
            vow = 0;
            cons = 0;
            for (int i = 0; i < str1.Length;i++)
            {
                char sym = str1[i];
                if (vowel_letters.IndexOf(sym) != -1) vow++;
                else if (consonant_letters.IndexOf(sym) != -1) cons++;
            }
        }
    }
}
