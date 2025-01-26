namespace Task_04_07
{
    /*В массиве на 30 элементов содержатся данные
     * по росту учеников в классе. 
     * Рост мальчиков условно задан отрицательными значениями.
     * Вычислить и вывести количество мальчиков и девочек в классе 
     * и средний рост для мальчиков и девочек. 
     * При выводе избавиться от отрицательных значений.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //введем массив класса
            int[] students = new int[30];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                //считаю, что могут быть ростом и 130 и 215, поэтому беру такой диапазон значений
                students[i] = rnd.Next(130, 220) * (rnd.Next(0, 2) * 2 - 1);
            }
            //введем данные для подсчета количества мальчиков и девочек, а также их среднего роста
            int summBoys = 0;
            int summGirls = 0;
            double summHeightBoys = 0;
            double summHeightGirls = 0;
            for (int i = 0;i < students.Length;i++)
            {
                if (students[i] > 0)
                {
                    summGirls++;
                    summHeightGirls += students[i];
                }
                else
                {
                    summBoys++;
                    summHeightBoys += Math.Abs(students[i]);
                }
            }
            Console.WriteLine("Количество мальчиков в классе: " + summBoys);
            Console.WriteLine("Количество девочек в классе: " + summGirls);
            Console.WriteLine("Средний рост девочек в классе: " + Math.Round(summHeightGirls / summGirls,2));
            Console.WriteLine("Средний рост мальчиков в классе: " + Math.Round(summHeightBoys / summBoys,2));
        }
    }
}
