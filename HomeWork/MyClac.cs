using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }

        Calculator calculator = new Calculator();

        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public int Division(int a, int b)
            {
                return a / b;
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(num1_txt.Text, out int num1) && int.TryParse(num2_txt.Text, out int num2))
            {
                int result = calculator.Add(num1, num2);
                ans_txt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
        }

        private void reduce_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(num1_txt.Text, out int num1) && int.TryParse(num2_txt.Text, out int num2))
            {
                int result = calculator.Subtract(num1, num2);
                ans_txt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
        }

        private void cross_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(num1_txt.Text, out int num1) && int.TryParse(num2_txt.Text, out int num2))
            {
                int result = calculator.Multiply(num1, num2);
                ans_txt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(num1_txt.Text, out int num1) && int.TryParse(num2_txt.Text, out int num2))
            {
                if (num2 != 0)
                {
                    int result = calculator.Division(num1, num2);
                    ans_txt.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("除數不能為零。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
        }
    }
}

