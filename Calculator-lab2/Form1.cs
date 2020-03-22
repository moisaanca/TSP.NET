using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_lab2
{
    public partial class Form1 : Form
    {

        public String text = "";
        public String operand;
        double number;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            concatText("1");
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            concatText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            concatText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            concatText("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            concatText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            concatText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            concatText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            concatText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            concatText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBoxResult.Text.ElementAt(textBoxResult.Text.Length - 1).Equals('.') && !textBoxResult.Text.Contains(".") && textBoxResult.Text.Length >= 1)
            {
                textBoxResult.Text = textBoxResult.Text + ".";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double value;
            double result;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxResult.Text, @"^\-{0,1}[0-9]*(?:\.[0-9]*)?$"))
            {

                value = Convert.ToDouble(textBoxResult.Text);

                if (operation == " + ")
                {
                    result = (number + value);
                    textBoxResult.Text = Convert.ToString(result);
                    number = result;
                }
                if (operation == "-")
                {
                    result = (number - value);
                    textBoxResult.Text = Convert.ToString(result);
                    number = result;
                }
                if (operation == "*")
                {
                    result = (number * value);
                    textBoxResult.Text = Convert.ToString(result);
                    number = result;
                }
                if (operation == "/")
                {
                    if (value == 0)
                    {
                        textBoxResult.Text = "artihmetic error";

                    }
                    else
                    {
                        result = (number / value);
                        textBoxResult.Text = Convert.ToString(result);
                        number = result;
                    }
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxResult.Text, @"^\-{0,1}[0-9]*(?:\.[0-9]*)?$"))
                addOperand("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxResult.Text, @"^\-{0,1}[0-9]*(?:\.[0-9]*)?$"))
                addOperand("/");
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxResult.Text, @"^\-{0,1}[0-9]*(?:\.[0-9]*)?$"))
                addOperand("+");
        }

        private void buttonDif_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxResult.Text, @"^\-{0,1}[0-9]*(?:\.[0-9]*)?$"))
                addOperand("-");
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void concatText(String text)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = text;
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + text;
            }
        }

        private void addOperand(String type)
        {
            if (textBoxResult.Text == " " && type == "-")
            {
                textBoxResult.Text = type;
            }
            else
            {
                number = Convert.ToDouble(textBoxResult.Text);
                textBoxResult.Text = "0";
                operation = type;
            }
        }
    }
}
