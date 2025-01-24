namespace Task_02_04
{
    internal class Program
    {
        /*Пользователь вводит свою дату рождения построчно
         * (сначала год, потом месяц и в конце дату) 
         * произведите расчет 
         * является ли пользователь 
         * совершеннолетним на текущую дату и 
         * выведите соответствующее сообщение об этом
        */
        static void Main(string[] args)
        {
            //переменные для хранения даты рождения
            Console.WriteLine("введите свой год рождения");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите свой месяц рождения числом");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите свой день рождения");
            int day = Int32.Parse(Console.ReadLine());
            //переменные для хранения сегодняшней даты
            Console.WriteLine("теперь введите нынешний год");
            int newyear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите нынешний месяц");
            int newmonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите сегодняшний день");
            int newday = Int32.Parse(Console.ReadLine());
            //проверим месяца
            if (newmonth > month)
            {
                int c = newyear - year;
                if (c >= 18)
                {
                    Console.WriteLine("вы совершеннолетний");
                }
                else
                {
                    Console.WriteLine("вы несовершеннолетний");
                }
            }
            else if (newmonth == month) 
            {
                //проверяем дни
                if (newday >= day)
                {
                    int a = newyear - year;
                    if (a >= 18)
                    {
                        Console.WriteLine("вы совершеннолетний");
                    }
                    else
                    {
                        Console.WriteLine("вы несовершеннолетний");
                    }
                }
                else
                {
                    int d = newyear - year - 1;
                    if (d >= 18)
                    {
                        Console.WriteLine("вы совершеннолетний");
                    }
                    else
                    {
                        Console.WriteLine("вы несовершеннолетний");
                    }
                }
            }
            else
            {
                int b = newyear - year - 1;
                if (b >= 18)
                {
                    Console.WriteLine("вы совершеннолетний");
                }
                else
                {
                    Console.WriteLine("вы несовершеннолетний");
                }
            }


        }
    }
}
