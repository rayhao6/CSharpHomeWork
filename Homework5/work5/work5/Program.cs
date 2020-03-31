using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            Console.Write(a);
            OrderItem car = new OrderItem(0,"car",4,6);
            OrderItem bus = new OrderItem(1, "bus", 5, 9);

            Order order1 = new Order(1, "Mike", new List<OrderItem> { car, bus });
            Order order2 = new Order(1, "Jack", new List<OrderItem> { car});
           
            OrderService myService = new OrderService();
            myService.addorder(order1);
            Console.WriteLine("添加订单1成功");
            myService.addorder(order2);
            Console.WriteLine("添加订单2成功");

            List<Order> orders = myService.Orders;
            orders.ForEach(o => Console.WriteLine(o));

            orders = myService.QueryByCustomer("Jack");
            orders.ForEach(o => Console.WriteLine(o));









        }
    }
}
