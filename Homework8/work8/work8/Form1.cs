using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using work5;

namespace work8
{
    public partial class Form1 : Form
    {

        public OrderService myService;
        public List<OrderItem> ItemSource;
        public Order theAdd;
        public AddOrder addOrderForm;
        BindingSource fieldsBS = new BindingSource();
        public String Keyword { get; set; }


        public Form1()

        {

            InitializeComponent();
            myService = new OrderService();
            ItemSource = new List<OrderItem>();

            
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderItem car = new OrderItem(0, "car", 4, 6);
            OrderItem bus = new OrderItem(1, "bus", 5, 9);

            Order order1 = new Order( "Mike", new List<OrderItem> { car, bus });
            Order order2 = new Order( "Jack", new List<OrderItem> { car });
            myService.addorder(order1);
            myService.addorder(order2);
            orderSource.DataSource = myService.Orders;
       
            textBox1.DataBindings.Add("Text", this, "Keyword");


        }





















        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (addOrderForm == null || addOrderForm.IsDisposed)
            {
                addOrderForm = new AddOrder(myService);
            }
            addOrderForm.ShowDialog();
            SearchAll();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            Order order = orderSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            myService.removeorder(order.OrderID);
            SearchAll();
        }


        private void orderitem_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                   
                    //Order or = (Order)bindingSourceOrder[e.RowIndex];

                    //这里可以编写你需要的任意关于按钮事件的操作~
                    //MessageBox.Show("点击");
                }
            }
        }

        private void SearchAll()
        {
            orderSource.DataSource = myService.Orders;
            orderSource.ResetBindings(false);
        }
        private void searchAll_Click(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            Order order = myService.GetOrder(id);
            List<Order> result = new List<Order>();
            if (order != null) result.Add(order);
            orderSource.DataSource = result;
        }

        private void import_Click(object sender, EventArgs e)
        {

            string fileName = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "E:\\C sharp\\CSharpHomeWork1-1\\Week8\\WinFormOrderSystem\\WinFormOrderSystem\\WinFormOrderSystem\\bin\\Debug";
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    fileName = openFileDialog.FileName;
                    myService.Import(fileName);
                   
                    
                }
                SearchAll();
            }

        }

        private void export_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "...\\bin\\Debug";
                saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    fileName = saveFileDialog.FileName;
                    myService.Export(fileName);
                }
            }

        }
    }
}
