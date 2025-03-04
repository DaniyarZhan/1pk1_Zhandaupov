namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: 
         * Напишите метод, который принимает 
         * два числа по ссылке (ref) и возвращает их сумму 
         * и произведение через выходные параметры (out).
         */
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число - ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число - ");
            int b = Convert.ToInt32(Console.ReadLine());
            Number(ref a, ref b, out c, out d);
            Console.WriteLine($"Сумма этих чисел: {c}");
            Console.WriteLine($"Произведение этих чисел: {d}");
        }
        /// <summary>
        /// Сумма чисел
        /// </summary>
        public static int c = 0;
        /// <summary>
        /// Произведение чисел
        /// </summary>
        public static int d = 1;
        /// <summary>
        /// Два числа, введённых с консоли
        /// </summary>
        /// <param name="num1">первое число</param>
        /// <param name="num2">второе число</param>
        /// <param name="sum">сумма этих чисел</param>
        /// <param name="proisv">произведение этих чисел</param>
        public static void Number(ref int num1, ref int num2, out int sum, out int proisv)
        {
            sum = num1 + num2;
            proisv = num1 * num2;
        }
    }
}
