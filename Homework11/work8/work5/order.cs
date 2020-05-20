using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace work5
{
    public class Order : IComparable<Order>
    {
        public static string GenerateRandomCode(int length)
         {
           var result = new StringBuilder();             
            for (var i = 0; i<length; i++)
               {
                 var r = new Random(Guid.NewGuid().GetHashCode());
                 result.Append(r.Next(0, 10));
            }
             return result.ToString();
         }


public DateTime time;
        [Key]
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> items;
        public double OrderPrice { get => items.Sum(item => item.Sum); }
        public Order(string name, List<OrderItem> item)
        {
            this.time = DateTime.Now;
            this.OrderID = int.Parse(GenerateRandomCode(6));
            this.CustomerName = name;
            if (item == null)
            {
                items = new List<OrderItem>();
            }
            else
            {
                items = item;
            }
        }
        public Order() { this.OrderID = int.Parse(GenerateRandomCode(6)); }

        public List<OrderItem> Items
        {
            get { return items; }
        }
       /* public void TotalPrice()
        {
            this.OrderPrice = items.Sum(item => item.Sum);
        }*/

        public void AddItem(OrderItem theorder)
        {
            if (Items.Contains(theorder))
            {
                Console.WriteLine("重复");
            }
            else
            {
                Items.Add(theorder);
            }
        }

        public void RemoveItem(OrderItem theorder)
        {
            Items.Remove(theorder);
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderID.CompareTo(other.OrderID);
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && OrderID == order.OrderID;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string str = "\nOrderNum:" + CustomerName;
            int i = 1;
            foreach (OrderItem x in Items)
            {
                str += "Item " + i + ":\n";
                str += x.ToString();
                i++;
            }

            return "\nOrder Time:" + time.ToString("yyyy-MM-dd HH:mm:ss");
        }


    }



    }

