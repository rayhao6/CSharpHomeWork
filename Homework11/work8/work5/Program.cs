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
            OrderService myService;
            myService = new OrderService();
            OrderItem car = new OrderItem(0, "car", 4, 6);
            OrderItem bus = new OrderItem(1, "bus", 5, 9);

            Order order1 = new Order("Mike", new List<OrderItem> { car, bus });
            Order order2 = new Order("Jack", new List<OrderItem> { car });
            myService.addorder(order1);
            myService.addorder(order2);
            Console.WriteLine(order1.CustomerName);
            Console.ReadKey();
        }
    }
}
