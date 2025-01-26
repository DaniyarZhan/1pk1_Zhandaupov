namespace Task_03_08
{
    internal class Program
    {
        /*Даны натуральные числа от 20 до 50.
         * Напечатать те из них, 
         * которые делятся на 3, но не делятся на 5.
         */
        static void Main(string[] args)
        {
            //введем диапазон значений
            int nmin = 20;
            int nmax = 50;
            //выведем числа, кратные 3 и не кратные 5
            Console.WriteLine("Числа кратные 3 и не кратные 5");
            while (nmax > nmin)
            {
                if (nmin % 3 == 0 && nmin % 5 != 0)
                {
                    Console.Write(nmin + "\t");
                }
                nmin++;
            }
        }
    }
}
