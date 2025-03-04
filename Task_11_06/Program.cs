namespace Task_11_06
{
    internal class Program
    {
        /*Передача массива по значению:
         * Напишите метод, который принимает 
         * массив целых чисел и изменяет его элементы, 
         * увеличивая каждый на 1. Проверьте, 
         * изменился ли оригинальный массив вне метода.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Random rnd = new Random();
            Console.Write("массив вне метода: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Massive(array);
                       
        }
        /// <summary>
        /// Массив, значения которого увеличились на 1 
        /// </summary>
        /// <param name="arr">изменённый массив</param>
        public static void Massive(int[] arr)
        {
            Console.Write("массив внутри метода: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
