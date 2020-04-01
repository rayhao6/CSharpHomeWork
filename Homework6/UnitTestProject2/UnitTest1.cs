using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using work5;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace UnitTestProject2
{
    [TestClass()]
    public class theservice
    {


        OrderService myservice = new OrderService();
        OrderItem car = new OrderItem(1, "car", 10, 80);
        OrderItem bus = new OrderItem(2, "bus", 1, 200);
        OrderItem plane = new OrderItem(3, "plane", 50, 1000);
        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order(1, "Jack", new List<OrderItem> { car, bus, plane });
            Order order2 = new Order(2, "Mike", new List<OrderItem> { car, bus });
            Order order3 = new Order(3, "John", new List<OrderItem> { plane, bus });
            myservice = new OrderService();
            myservice.addorder(order1);
            myservice.addorder(order2);
            myservice.addorder(order3);
        }

        [TestMethod()]
        public void TestMethod1()
        {
            Order order4 = new Order(4, "Mike", new List<OrderItem> { car });
            myservice.addorder(order4);
            Assert.AreEqual(4, myservice.Orders.Count);
            CollectionAssert.Contains(myservice.Orders, order4);

        }
        [TestMethod()]
        public void TestMethod2()
        {
            myservice.removeorder(3);
            Assert.AreEqual(2, myservice.Orders.Count);
            myservice.removeorder(100);
            Assert.AreEqual(2, myservice.Orders.Count);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            Assert.AreEqual(1 ,myservice.QueryByCustomer("Jack").Count);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Order order3 = new Order(3, "Henry", new List<OrderItem> { car });
            myservice.ModifyOrder(order3);
            Assert.AreEqual(3, myservice.Orders.Count);
            Order o = myservice.GetOrder(3);
            Assert.AreEqual("Henry", o.CustomerName);
        }

    }
}
