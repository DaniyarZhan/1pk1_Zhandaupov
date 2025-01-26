namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными 
        * и отрицательными числами таким образом, 
        * чтобы все числа по модулю были разными.
        * Это значит, 
        * что в массиве не может быть ни только двух равных чисел,
        * но не может быть двух равных по модулю.
        * В полученном массиве найти наибольшее по модулю число.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            int[] numbers1 = new int[numbers.Length];          
            Random rnd = new Random();
            int i = 0;
            while (i < numbers.Length)
            {
                int num = rnd.Next();
                if (Array.IndexOf(numbers1, num) != -1)
                {
                    continue;
                }
                numbers[i] = num * (rnd.Next(0, 2) == 0 ? 1 : -1);
                numbers1[i] = num;
                i++;
            }
            Console.WriteLine("Содержимое массива: ");
            foreach (int a in numbers)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine("");
            //Самое большое по модулю число
            Console.WriteLine($"Самое большое по модулю число: {numbers[Array.IndexOf(numbers1, numbers1.Max())]}");
        }
    }
}
