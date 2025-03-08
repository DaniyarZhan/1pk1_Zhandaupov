using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01
{
    internal class Journal
    {
        #region поля
        public DateTime dataizd; //поле класса - хранит дату журнала
        public string tema; //поле класса - хранит предметно-тематическую направленность журнала
        public string title; //поле класса - хранит название журнала
        public int countstr; //поле класса - хранит количество страниц журнала
        public int price;//поле класса - хранит цену журнала
        public int money;//поле класса - хранит деньги покупателя
        #endregion
        //метод класса - печатает в консоль информацию о просмотре содержания журнала
        public void GetInfo()
        {
            Console.WriteLine($"Дата издания журнала: {dataizd}; \nтема: {tema}; \nназвание журнала: {title}; \nколичество страниц: {countstr}; \nцена журнала: {price}");
        }
        //метод класса - печатает в консоль информацию о покупке журнала
        public void GetBoot()
        {
            if (money >= price)
                Console.WriteLine($"журнал {title} куплён");
            else
            {
                Console.WriteLine($"вы не можете купить журнал {title}");
            }
        }
    }
}
