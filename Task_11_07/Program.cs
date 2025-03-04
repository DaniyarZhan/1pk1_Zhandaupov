namespace Task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке (ref):
         * Напишите метод, который принимает массив целых чисел
         * по ссылке и изменяет его элементы, 
         * увеличивая каждый на 1. Проверьте, 
         * изменился ли оригинальный массив вне метода.
         */
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[a];
            Random rnd = new Random();            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }
            Massive(ref array);
            Console.Write("массив вне метода: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Массив, значения которого увеличились на 1 
        /// </summary>
        /// <param name="arr">изменённый массив</param>
        public static void Massive(ref int[] arr)
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
