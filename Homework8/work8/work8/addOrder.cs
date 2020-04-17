using System;
using work5;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work8
{
    public partial class AddOrder : Form
    {
        public OrderService orderService;
        public Order order = new Order();
        public List<OrderItem> orderItemList = new List<OrderItem>();
        public AddOrder(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (GoodName.Text == "" || GoodPrice.Text == "")
                {
                    MessageBox.Show("请完善订单信息");
                    return;
                }
                else
                {
                    int goodnum = int.Parse(GoodNum.Text);
                    int goodPrice = int.Parse(GoodPrice.Text);
                    int id = int.Parse(GoodID.Text);


                    string goodName = GoodName.Text;
                    OrderItem theItem = new OrderItem(id, goodName, goodnum, goodPrice);

                    orderItemList.Add(theItem);
                    GoodName.Clear();
                    GoodPrice.Clear();
                    GoodNum.Clear();
                    GoodID.Clear();
                    MessageBox.Show("Item添加成功");

                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("数据输入有误!");
            }
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {

                order.items= orderItemList;
                order.CustomerName = CustomerName.Text;
                orderService.addorder(order);
                MessageBox.Show("添加完成！");
                this.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show("数据有误！");
            }
        }
    }
}
