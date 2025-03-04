namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: Напишите метод, 
         * который принимает два целых числа и меняет их местами. 
         * Проверьте, изменились ли значения переменных вне метода
         */
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число - ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число - ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Perestan(num1, num2);
            Console.WriteLine("значения вне метода - " + num1 + "," + num2);
        }
        /// <summary>
        /// Два числа, которые меняются местами
        /// </summary>
        /// <param name="numbers1">первое число</param>
        /// <param name="numbers2">второе число</param>
        public static void Perestan(int numbers1, int numbers2)
        {
            int a = numbers1;
            numbers1 = numbers2;
            numbers2 = a;
            Console.WriteLine("значения внутри метода - " + numbers1 + "," + numbers2);
        }
    }
}
