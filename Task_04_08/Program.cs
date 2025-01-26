namespace Task_04_08
{
    /*Дан массив, содержащий последовательность 
     * 50 случайных чисел. 
     * Найти количество пар элементов,
     * значения которых равны.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //введем данные для массива
            int[] numbers = new int[50];
            Random random = new Random();
            Console.WriteLine("Напишите начальное значение диапазона");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите конечное значение диапазона");
            int m = int.Parse(Console.ReadLine());
            //заполнение массива
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(n,m);
                Console.Write(numbers[i] + " ");
            }
            //поиск пар начиная со 2 элемента
            int countOfPairs = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    countOfPairs++;                  
                }
            }
            Console.WriteLine($"\nКоличество пар чисел равных между собой - {countOfPairs}");
        }
    }
}
