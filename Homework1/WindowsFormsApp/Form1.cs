using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operate_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            //num1 = Convert.ToDouble(input1.Text);
            num2 = Convert.ToDouble(input3.Text);
            try
            {
                num1 = Convert.ToDouble(input1.Text);
                num2 = Convert.ToDouble(input3.Text);
            }
            catch (Exception x)
            {
                output.Text = ":“输入字符串的格式不正确";
                return;
            }
        
                switch (input2.Text)
                {
                    case "+":
                        output.Text = $"{num1 + num2}";
                        break;
                    case "-":
                        output.Text = $"{num1 - num2}";
                        break;
                    case "*":
                            try
                        {
                        output.Text = $"{num1 * num2}";
                            
                             }
                        catch(ArithmeticException x)
                         {
                        output.Text = "越界";
                        break;
                             }
                     break;
                case "/":
                        if (num2 != 0)
                        {
                            output.Text = $"{num1 / num2}";
                            break;
                        }
                        else
                        {
                            output.Text = "除数为零";
                            break;
                        }
                    default:
                        output.Text = "输入不为加减乘除";
                        break;
                };
            }
        }
    }


