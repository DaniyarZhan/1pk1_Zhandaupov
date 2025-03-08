using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    internal class Newspaper
    {
        #region поля
        public DateTime dataizd; //поле класса - хранит дату газеты
        public string title; //поле класса - хранит название газеты
        public string headline; //поле класса - хранит заголовок главной полосы газеты
        public int countstr; //поле класса - хранит количество страниц газеты
        public int price;//поле класса - хранит цену газеты
        public int money;//поле класса - хранит деньги покупателя
        #endregion
        //метод класса - печатает в консоль информацию о покупке газеты
        public void GetBoot()
        {
            if (money >= price)
                Console.WriteLine($"газета {title} куплена");
            else
            {
                Console.WriteLine($"вы не можете купить газету {title}");
            }
        }
    }
}
