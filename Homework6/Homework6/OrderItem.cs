using System;
using System.Collections.Generic;
using System.Text;

namespace work5
{
    public class OrderItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductNum { get; set; }
        public int ProductPrice { get; set; }

        public OrderItem() { }
        public OrderItem(int id, string name, int num, int price)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.ProductNum = num;
            this.ProductPrice = price;
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            if (item != null && ProductName == item.ProductName)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"[No.:{ProductID},goods:{ProductName},quantity:{ProductPrice},totalPrice:{ProductNum}]";
        }

        public double Sum {
            get => ProductPrice * ProductNum;
        }
    }
}
