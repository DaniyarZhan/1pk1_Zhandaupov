namespace Task_04_10
{
    internal class Program
    {
        /*Заполнить массив из 10 элементов
         * случайными числами в интервале [-10..10]
         * и сделать реверс элементов отдельно для 1-ой и 2-ой половин массива. 
         * Реверс реализовать через цикл. 
         * Стандартные методы класса Array использовать нельзя. 
         * Например, исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]. 
         * Результат: [4,0,-10,2,5,-7,9,2,7,-6]
         */
        static void Main(string[] args)
        {
            //введем данные для массива
            int[] numbers = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-10,11);
                Console.Write(numbers[i] + "\t");
                if ((i+1) % 5 == 0 && i==4)
                {
                    Console.WriteLine("Первая часть массива");
                    int num = numbers[0];
                    int num1 = numbers[1];
                    int num2 = numbers[2];
                    int num3 = numbers[3];
                    int num4 = numbers[4];
                    Console.Write($"{num4}" + $"\t{num3}" + $"\t{num2}" + $"\t {num1}" + $"\t{num}");
                    Console.WriteLine("\tРеверс первой части массива");
                }
                else if ((i+1) % 5 == 0 && i == 9)
                {
                    Console.WriteLine("Вторая часть массива");
                    int num = numbers[5];
                    int num1 = numbers[6];
                    int num2 = numbers[7];
                    int num3 = numbers[8];
                    int num4 = numbers[9];
                    Console.Write($"{num4}" + $"\t{num3}" + $"\t{num2}" + $"\t {num1}" + $"\t{num}");
                    Console.WriteLine("\tРеверс второй части массива");
                }
            }
        }
    }
}
