using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorC
{
    public partial class calc : Form
    {
        UTF8Encoding utf8 = new UTF8Encoding();
        double FirstNumber;
        string Operation;
        public calc()
        {
            InitializeComponent();
        }
        private void LabelOperation_Click(object sender, EventArgs e)
        {
            //labelForOperation.Text = "0";
            // labelForOperation.Text = labelForOperation.Text;
        }

        private void Numb1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
                labelForOperation.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
                labelForOperation.Text = labelForOperation.Text + "1";
            }
        }

        private void Numb2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
                labelForOperation.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
                labelForOperation.Text = labelForOperation.Text + "2";
            }
        }

        private void Numb3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
                labelForOperation.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
                labelForOperation.Text = labelForOperation.Text + "3";
            }
        }

        private void Numb4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
                labelForOperation.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
                labelForOperation.Text = labelForOperation.Text + "4";
            }
        }

        private void Numb5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
                labelForOperation.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
                labelForOperation.Text = labelForOperation.Text + "5";
            }
        }

        private void Numb6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
                labelForOperation.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
                labelForOperation.Text = labelForOperation.Text + "6";
            }
        }

        private void Numb7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
                labelForOperation.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                labelForOperation.Text = labelForOperation.Text + "7";
            }
        }

        private void Numb8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
                labelForOperation.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
                labelForOperation.Text = labelForOperation.Text + "8";
            }
        }

        private void Numb9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
                labelForOperation.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
                labelForOperation.Text = labelForOperation.Text + "9";
            }
        }

        private void Numb0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            labelForOperation.Text = labelForOperation.Text + "0";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }
        private void Per_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "%";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelForOperation.Text = (FirstNumber + SecondNumber) + "=" + Convert.ToString(Result);
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelForOperation.Text = "=" + Convert.ToString(Result);
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelForOperation.Text = "=" + Convert.ToString(Result);
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    labelForOperation.Text = "=" + Convert.ToString(Result);
                }
            }
            if (Operation == "%")
            {
                Result = FirstNumber * 0.01;
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                labelForOperation.Text = "=" + Convert.ToString(Result);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            labelForOperation.Text = "0";
        }
    }
}