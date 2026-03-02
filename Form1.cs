using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientific_cal
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        //double num2 = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "+";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}+";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "-";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}-";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "*";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}*";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "/";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}/";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num2 = 0;
            double result = 0;
            if (operation == "^2")
            {
                result = Math.Pow(num1, 2);
                textBox1.Text = $"{num1}²";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "^3")
            {
                result = Math.Pow(num1, 3);
                textBox1.Text = $"{num1}³";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "√")
            {
                if (num1 >= 0)
                {
                    result = Math.Sqrt(num1);
                    textBox1.Text = $"√{num1}";
                    textBox2.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Cannot take square root of a negative number");
                    textBox1.Clear();
                }
                return;
            }
            else if (operation == "^1.0/3.0")
            {
                if (num1 >= 0)
                {
                    result = Math.Pow(num1, 1.0 / 3.0);
                    textBox1.Text = $"∛{num1}";
                    textBox2.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Cannot take cube root of a negative number");
                    textBox1.Clear();
                }
                return;
            }
            else if (operation == "yroot")// confused
            {
                string[] parts = textBox1.Text.Split('√');
                double y = Convert.ToDouble(parts[1]);
                if (y != 0)
                {
                    result = Math.Pow(num1, 1.0 / y);
                    textBox1.Text = $"{num2}√{num1}";
                    textBox2.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Cannot take root with degree zero");
                    textBox1.Clear();
                }
                return;
            }
            else if (operation == "sin")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = Math.Sin(degrees);
                textBox1.Text = $"sin({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "cos")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = Math.Cos(degrees);
                textBox1.Text = $"cos({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "tan")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = Math.Tan(degrees);
                textBox1.Text = $"tan({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "cot")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = 1 / Math.Tan(degrees);
                textBox1.Text = $"cot({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "cosec")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = 1 / Math.Sin(degrees);
                textBox1.Text = $"cosec({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "sec")
            {
                double degrees = num1 * (180.0 / Math.PI);
                result = 1 / Math.Cos(degrees);
                textBox1.Text = $"sec({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "log")
            {
                result = Math.Log10(num1);
                textBox1.Text = $"log({num1})";
                textBox2.Text = $"{result}";
                return;
            }
            else if (operation == "e")
            {
                result = Math.Exp(num1);
                textBox1.Text = $"{num1}";
                textBox2.Text = $"{result}";
            }
            else if (operation == "!")
            {
                if (num1 >= 0 && num1 % 1 == 0)
                {
                    int n = (int)num1;
                    long factres = 1;

                    for (int i = 1; i <= n; i++)
                    {
                        factres *= i;
                    }

                    result = factres;
                }
                textBox1.Text = $"{num1}!";
                textBox2.Text = $"{result}";
                return;
            }
            else if(operation == "|x|")
            {
                result = Math.Abs(num1);
                textBox1.Text = $"|{num1}|";
                textBox2.Text = $"{result}";
            }
            else if (operation == "1/x")
            {
                result = 1/num1;
                textBox1.Text = $"1/{num1}";
                textBox2.Text = $"{result}";
            }
            else if (operation == "%")
            {
                string[] parts = textBox1.Text.Split(new string[] { "% of " }, StringSplitOptions.None);
                double num2percent = Convert.ToDouble(parts[1]);
                result = (num1 * num2percent) / 100;
                textBox1.Text = $"{num1}% of {num2percent}";
                textBox2.Text = $"{result}";
                return;
            }
                //double num2 = Convert.ToDouble(parts[2]); 
                string expression = textBox1.Text;
            if (expression.Contains(operation))
            {
                string[] parts = expression.Split(new string[] { operation }, StringSplitOptions.None);
                num2 = Convert.ToDouble(parts[1]);
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;

                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else if (num1 == 0)
                        {
                            result = 0;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            textBox1.Clear();
                        }
                        break;
                    case "^":
                    {
                        result = Math.Pow(num1, num2);
                        break;
                    }
                    /*case "%":
                    {

                        result = (num1*num2) / 100;
                        break;
                    }*/

                }
                textBox1.Text = $"{num1}{operation}{num2}";
                textBox2.Text = $"{result}";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "^";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}^";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "^2";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}²";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "√";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"√{num1}";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "sin";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"sin({num1})";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "yroot";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}√";
            } //having many doubts about this
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "^1.0/3.0";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"∛{num1}";
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "cos";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"cos({num1})";
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "^3";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}³";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "tan";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"tan({num1})";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "cot";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"cot({num1})";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "cosec";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"cosec({num1})";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "sec";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"sec({num1})";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "log";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"log({num1})";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "e";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"e={num1}";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "!";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}!";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "|x|";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"|{num1}|";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "1/x";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"1/{num1}";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
             {
                num1 = Convert.ToDouble(textBox1.Text);
                operation = "%";
                //num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = $"{num1}% of ";
             }
        }
    } 
}
