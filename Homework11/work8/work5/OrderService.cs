using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
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
            using (var context = new Model1())
            {
                try
                {
                    var order1 = context.Orders.Include("OrderItem").Where(b => b.OrderID == id).FirstOrDefault();
                    return order1;
                }
                catch(Exception x)
                {
                    Console.WriteLine("error input id");
                    return null;
                }
                

            } }
        public void addorder(Order x)
        {
                try
                {
                    using (var context = new Model1())
                    {

                        context.Orders.Add(x);
                        context.SaveChanges();
                    }
                }
                catch (DbEntityValidationException dbEx)
                {
                    //TODO 需要更加错误类型返回不同错误信息
                    throw new ApplicationException($"添加错误: {dbEx.Message}");
                }
                //Console.WriteLine("please enter the order id");          

            }
        public void removeorder(int id)
        {
                using (var context = new Model1())
                {
                Order order = context.Orders.Include("OrderItems").FirstOrDefault(p => p.OrderID == id);
                if (order != null)
                {
                    try
                    {
                        context.Orders.Remove(order);
                        context.SaveChanges();
                    }
                    catch(Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }
                    
                }

                }

            }


        public void ModifyOrder(Order newOrder)
        {

            using (var context = new Model1())
            {
                var order2 = context.Orders.Where(p => p.OrderID == newOrder.OrderID).FirstOrDefault();
                orders.Remove(order2);
                orders.Add(order2); ;
                context.SaveChanges();

            }
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


        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach((Action<Order>)(order =>
                {
                    if (!this.Orders.Contains(order))
                    {
                        this.Orders.Add(order);
                    }
                }));
            }
        }



    }
}
