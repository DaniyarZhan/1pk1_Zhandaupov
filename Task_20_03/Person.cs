using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class Person
    {
        public OrderStatus Status { get; set; }
        public void Change()
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
                Console.WriteLine($"Нельзя изменить статус заказа, так как {Status}");
            else
            {
                Status++;
                Console.WriteLine($"Заказ переведён в статус: {Status}");
            }
        }
        public void Cancel()
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
                Console.WriteLine($"Нельзя изменить статус заказа, так как {Status}");
            else
            {
                Status = OrderStatus.Cancelled;
                Console.WriteLine($"Заказ переведён в статус: {Status}");
            }
        }
        public Person()
        {
            Status = OrderStatus.New;
        }
    }
}
