namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводит в консоли произвольный текст.
         * После каждого ввода консоль очищается. 
         * Когда пользователь вводить слово «exit»
         * или пустую строку – ввод останавливается
         * и выводиться количество строк 
         * введенных пользователем.
         */
        static void Main(string[] args)
        {
            //ввод слов, записываемых пользователем
            Console.WriteLine("осуществите ввод текста построчно");
            int countOfWords = 0;

            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "" || temp == "exit")
                    break;
                //считаем количество строк
                countOfWords++;
                Console.Clear();
            }
            Console.WriteLine("вы ввели " + countOfWords + " строк ");
        }
    }
}
