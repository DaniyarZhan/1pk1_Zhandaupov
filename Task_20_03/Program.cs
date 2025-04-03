using System.Security.Cryptography.X509Certificates;

namespace Task_20_03
{
    enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    internal class Program
    {
        /*Создайте программу для управления статусом заказа в интернет-магазине. 
         * Используйте перечислениеOrderStatus со значениями:
         * • New (новый)
         * • Processing (в обработке)
         * • Shipped (отправлен)
         * • Delivered (доставлен)
         * • Cancelled (отменён)
         * Напишите метод, который меняет статус заказа. 
         * Если заказ уже доставлен или отменён, запретите изменение статуса. 
         * Выводите сообщение при каждом изменении статуса
         * (например, "Заказ переведён в статус: Отправлен")
         */
        static void Main(string[] args)
        {   
            Person person = new Person();
            Console.WriteLine(person.Status);
            person.Change();
            person.Change();
            person.Cancel();
            person.Change();
        }
  
    }
}
