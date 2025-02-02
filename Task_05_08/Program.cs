namespace Task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10,
         * заполненные целыми числами в диапазоне от 1 до 9 вкл.
         * Создать новый массив, который будет
         * произведением двух предыдущих 
         * (перемножить элементы первых двух массивов,
         * стоящие на одинаковых позициях и 
         * записать их в результирующий массив).
         * Вывести результирующий массив  
        */
        static void Main(string[] args)
        {
            //вводим массивы
            int[,] numbers = new int[10,10];
            int[,] numbers1 = new int[10,10];
            Random rnd = new Random();
            Console.WriteLine("Первый массив");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i,j] = rnd.Next(1,10);
                    Console.Write(numbers[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второй массив");
            for (int i = 0; i < numbers1.GetLength(0); i++)
            {
                for (int j = 0; j < numbers1.GetLength(1); j++)
                {
                    numbers1[i, j] = rnd.Next(1,10);
                    Console.Write(numbers1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив");
            //вводим новый массив, который будет произведением элементов первого и второго массива
            int[,] intsProisv = new int[10,10];
            for (int i = 0;i < intsProisv.GetLength(0); i++)
            {
                for(int j = 0;j < intsProisv.GetLength(1); j++)
                {
                    intsProisv[i,j] = numbers[i,j] * numbers1[i,j];
                    Console.Write(intsProisv[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
