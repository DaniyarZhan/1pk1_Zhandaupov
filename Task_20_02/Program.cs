namespace Task_20_02
{
    enum GameChoice
    {
        Rock = 1,
        Scissors,
        Paper
    }
    internal class Program
    {
        /*Реализуйте консольную игру "Камень, Ножницы, Бумага" с использованием перечисления GameChoice:
            • Rock
            • Scissors
            • Paper
        Компьютер выбирает случайный вариант. 
        Игрок вводит свой выбор (например, цифрой: 1 – Камень, 2 – Ножницы и т. д.). 
        Определите победителя на основе правил игры и выведите результат.
         */
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                var computer = (GameChoice)rand.Next(1,4);//выбор компьютера
                Console.Write("Выберите: 1 - Камень, 2 - Ножницы, 3 - Бумага - ");
                var player = (GameChoice)Convert.ToInt32(Console.ReadLine());//выбор игрока
                if (player == GameChoice.Rock || player == GameChoice.Scissors || player == GameChoice.Paper)
                {
                    if (player == GameChoice.Rock)//выбор игрока
                    {
                        //выбор компьютера
                        if (computer == GameChoice.Rock)
                            Console.WriteLine($"Ничья \nВыбор компьютера:{computer}, игрока:{player}");
                        else if (computer == GameChoice.Scissors)
                            Console.WriteLine($"Победа \nВыбор компьютера:{computer}, игрока:{player}");
                        else
                            Console.WriteLine($"Поражение \nВыбор компьютера:{computer}, игрока:{player}");
                    }
                    else if (player == GameChoice.Scissors)//выбор игрока
                    {
                        //выбор компьютера
                        if (computer == GameChoice.Rock)
                            Console.WriteLine($"Поражение \nВыбор компьютера:{computer}, игрока:{player}");
                        else if (computer == GameChoice.Scissors)
                            Console.WriteLine($"Ничья \nВыбор компьютера:{computer}, игрока:{player}");
                        else
                            Console.WriteLine($"Победа \nВыбор компьютера:{computer}, игрока:{player}");
                    }
                    else
                    {
                        //выбор компьютера
                        if (computer == GameChoice.Rock)//выбор игрока
                            Console.WriteLine($"Победа \nВыбор компьютера:{computer}, игрока:{player}");
                        else if (computer == GameChoice.Scissors)
                            Console.WriteLine($"Поражение \nВыбор компьютера:{computer}, игрока:{player}");
                        else
                            Console.WriteLine($"Ничья \nВыбор компьютера:{computer}, игрока:{player}");
                    }
                }
                else
                    Console.WriteLine("Вы ввели некорректные данные!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
