namespace Task_02_02
{
    internal class Program
    {
        /*найти значение выражения 
         * при a = 8, b = 14, c = 3.14/4
         */
        static void Main(string[] args)
        {
            //ввод данных
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            //поэтапное решение
            double step1 = Math.Cbrt(a - 1);
            double step2 = Math.Pow(b - step1, 1.0 / 4.0);
            double step3 = Math.Abs(a - b);
            double step4 = Math.Sin(c) * Math.Sin(c) + Math.Tan(c);
            //находим значение выражения
            double result = step2 / step3 / step4;
            //выводим полученное значение выражения
            Console.WriteLine(result);
        }
    }
}
