using System.Diagnostics;

namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения
         * о количестве осадков за месяц (30 дней).
         * Необходимо определить общее количество осадков,
         * выпавших за каждую декаду месяца, 
         * вывести день с самыми сильными осадками за месяц 
         * и отдельно вывести дни без осадков. 
         * Массив с осадками заполнятся с помощью рандома
         * в диапазоне от 0 – нет осадков, до 300 мм выпавших осадков.
         */
        static void Main(string[] args)
        {
            //введем переменные для количества дней
            int[] array = new int[30];
            Random random = new Random();
            int countZero = 0;
            int countRainfall = 0; //количество осадков в декаду
            int a = 0; //количество декад
            int b = 0; //максимальное количество осадков
            Console.WriteLine("Количество осадков за месяц(30 дней)");
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = random.Next(0,300); //заполняем массив рандомными числами
                countRainfall += array[i];
                if ((i + 1) % 10 == 0) //разделение на декады
                {
                    a++;
                    Console.Write($"Общее количество осадков за {a} декаду: ");
                    Console.WriteLine(countRainfall);
                    countRainfall = 0;
                }
                if (array[i] > array[b]) //день с наибольшим значением осадков
                {
                    b = i;
                }
            }
            foreach (int i in array)
                if (i == 0) //нахождение дней без осадков           
                {
                    countZero++;          
                }
            Console.WriteLine(countZero != 0 ? $"Дней без осадков: {countZero}." : "Дней без осадков нет.");   
            Console.WriteLine(b + " день с наибольшим значением количества осадков");
        }
    }
}
