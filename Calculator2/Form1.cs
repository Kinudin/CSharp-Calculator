using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void clickNumber(string number)
        {
            this.textBox1.Text = "";
            input += number;
            this.textBox1.Text += input;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clickNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickNumber("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickNumber("4");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickNumber("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickNumber("7");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickNumber("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            clickNumber("0");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation) { 
                case '+':
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num1;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "DIV/Zero!";
                    }
                    break;
            }
           
        }
    }
}
