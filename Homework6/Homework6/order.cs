using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace work5
{
    public class Order:IComparable<Order>
    {
        public DateTime time;
        public int OrderID { get; set; }
        public double OrderPrice;
        public string CustomerName;
        private List<OrderItem> items;
        public Order(int id, string name, List<OrderItem> item)
        {
            this.time = DateTime.Now;
            this.OrderID = id;
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

        public List<OrderItem> Items
        {
            get { return items; }
        }
        public void TotalPrice()
        {
            this.OrderPrice = items.Sum(item => item.Sum);
        }

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

