using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text;

namespace work5
{
   public class OrderService
    {
        public List<Order>orders = new List<Order>();

        public OrderService()
        {
            orders = new List<Order>();
        }

        public Order GetOrder(int id)
        {
            return orders.Where(o => o.OrderID == id).FirstOrDefault();
        }
        public void addorder(Order x)
        {
            orders.Add(x);
            Console.WriteLine("please enter the order id");          

        }
        public void removeorder(int id)
        {
            Order order = GetOrder(id);
            if (order!=null)
            {
                orders.Remove(order);
            }
            
        }


        public List<Order> QueryByCustomer(string customername)
        {
           return orders
          .Where(order => order.CustomerName == customername)
          .OrderBy(o => o.OrderPrice)
          .ToList();
        }
        public void ModifyOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.OrderID);
            if (oldOrder == null)
                throw new ApplicationException($"Update Error：the order with id {newOrder.OrderID} does not exist!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public void sort()
        {
            orders.Sort();
        }
        public List<Order> Orders { get => orders; }
        public void Sort(Func<Order, Order, int> func)
        {
            
            Orders.Sort((o1, o2) => func(o1, o2));
        }





    }
}
