using System.Diagnostics.Metrics;

namespace Task_12_01
{
    internal class Program
    {
        /* добавить в класс Book метод с помощью которого пользователь
         * возвращает книгу и ее статус снова переводится в «свободен»
            в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
            дата издания, предметно-тематическая направленность журнала, 
            название, количество страниц, цена, функционал класса:
            покупка журнала
            просмотр содержания журнала
            в этом же проекте реализуйте класс Newspaper (газета) со следующими данными:
            дата издания, название газеты, заголовок главной полосы, количество страниц, цена, функционал класса:
            покупка газеты
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите из списка: книга, журнал, газета");
            string r = Console.ReadLine();
            #region книга
            if (r == "книга")
            {
                Book book1 = new Book();
                var book2 = new Book();
                var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
                Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };

                book1.autor = "Рей Бредберри";
                book1.title = "Марсианские хроники";
                book1.GetInfo();    //Рей Бредберри : Марсианские хроники

                book2.autor = "Джона Роулинг";
                book2.title = "Гарри Поттер и философский камень";
                book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

                //выдача книги
                book2.GetBoot(); // книга выдана на неделю

                //попытка выдать уже занятую книгу
                book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

                book1.VosvratBoot();// книга Марсианские хроники возвращена
            }
            #endregion
            #region журнал
            else if (r == "журнал")
            {
                Journal journal1 = new Journal();
                var journal2 = new Journal();
                var journal3 = new Journal() { dataizd = DateTime.Now, tema = "красота", title = "Cosmopoliten", countstr = 100, price = 500, money = 1000};
                Journal journal4 = new Journal() { dataizd = DateTime.Now, tema = "детская", title = "Эрудит", countstr = 50, price = 150, money = 150};

                journal1.dataizd = DateTime.Now;
                journal1.tema = "информация об артистах";
                journal1.title = "Все звёзды";
                journal1.countstr = 60;
                journal1.price = 250;
                journal1.money = 240;
                journal1.GetInfo();    //Дата издания журнала: 08.03.2025 19:55:44;
                                       //тема: информация об артистах;
                                       //название журнала: Все звёзды;
                                       //количество страниц: 60;
                                       //цена журнала: 250

                Console.WriteLine();
                journal2.dataizd = DateTime.Now;
                journal2.tema = "информация о автомобилях";
                journal2.title = "Автопилот";
                journal2.countstr = 100;
                journal2.price = 500;
                journal2.money = 5200;
                journal2.GetInfo();    //Дата издания журнала: 08.03.2025 19:58:20;
                                       //тема: информация о автомобилях;
                                       //название журнала: Автопилот;
                                       //количество страниц: 100;
                                       //цена журнала: 500

                //выдача журнала
                journal1.GetBoot();    //вы не можете купить журнал Все звёзды
            }
            #endregion
            #region газета
            else if (r == "газета")
            {
                Newspaper newspaper1 = new Newspaper();
                var newspaper2 = new Newspaper() { dataizd = DateTime.Now, title = "Аргументы и факты", 
                    headline = "Когда настанет конец света", countstr = 100, price = 500, money = 1000 };

                newspaper1.dataizd = DateTime.Now;               
                newspaper1.title = "Ведомости";
                newspaper1.headline = "Ждать ли в этом году наводнение?";
                newspaper1.countstr = 60;
                newspaper1.price = 250;
                newspaper1.money = 240;
                newspaper1.GetBoot();  //вы не можете купить газету Ведомости
            }
            #endregion

        }
    }
}
