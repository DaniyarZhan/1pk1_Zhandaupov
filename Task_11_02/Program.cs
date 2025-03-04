using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_11_02
{
    internal class Program
    {
        /*Передача по ссылке (ref): 
         * Напишите метод, который принимает 
         * два целых числа по ссылке и меняет их местами. 
         * Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число - ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число - ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Perestan(ref num1, ref num2);
            Console.WriteLine("значения вне метода - " + num1 + "," + num2);
        }
        /// <summary>
        /// Два числа, которые меняются местами
        /// </summary>
        /// <param name="number1">первое число</param>
        /// <param name="number2">второе число</param>
        public static void Perestan(ref int number1,ref int number2)
        {
            int a = number1;
            number1 = number2;
            number2 = a;
            Console.WriteLine("значения внутри метода - " + number1 + "," + number2);
        }
    }
}
