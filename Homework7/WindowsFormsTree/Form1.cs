using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;//right angle
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;//right length:
        double per2 = 0.7;
        double leng;//length
        int n;//depth

        Pen pen;
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen,
                (int)x0, (int)y0, 
                (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            if (graphics == null) graphics = panel1.CreateGraphics();
            try
            {
                th2 = double.Parse(left_angle.Value.ToString());
                th1 = double.Parse(right_angle.Value.ToString());
                leng = double.Parse(mainLength.Value.ToString());
                per1 = double.Parse(leftLength.Value.ToString())/100;
                per2 = double.Parse(rightLength.Value.ToString())/100;
            }
            catch(Exception x)
            {
                MessageBox.Show("Wrong input");
                return;
            }
            try
            {
                switch (penColor.SelectedIndex)
                {
                    case 0:
                        pen = Pens.Blue;
                        break;
                    case 1:
                        pen = Pens.Red;
                        break;
                    case 2:
                        pen = Pens.Yellow;
                        break;
                    case 3:
                        pen = Pens.Green;
                        break;

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Wrong input");
                return;
            }
            n = int.Parse(recurLength.SelectedItem.ToString());
        

        drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void right_angle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mainLength_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void leftLength_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rightLength_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void left_angle_Scroll(object sender, EventArgs e)
        {

        }
    }
}
