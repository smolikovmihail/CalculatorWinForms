using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //#########method for entering numbers##########
        private void button_Num_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string tmp = b.Text;
            if (textBox2.Text == "0"||textBox2.Text=="Error!") //if before entering the number an error was received or textbox contain 0,
                                                                //then replace the error message with the number
            {
                textBox2.Text = tmp;
            }
            else
            {
                textBox2.Text += tmp;
            }

        }
        //##############method for entering operators of mathematical operations
        private void button_Operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string operation = b.Text;
            string tmp = textBox1.Text;
            if (textBox1.Text == "")
            {
                if(textBox2.Text=="Error!")
                    {
                        textBox2.Text = "0";
                    }
                else
                    {
                        textBox1.Text = textBox2.Text + operation;
                        textBox2.Text = "0";
                    }
            }
            else
            {
                //if the sign of the mathematical action is already there, then replace it by clicking on the button with a different sign
                if ((tmp.Contains("+") || tmp.Contains("-") || tmp.Contains("X") || tmp.Contains("÷")) && textBox2.Text == "0")
                {
                    textBox1.Text = tmp.Substring(0, tmp.Length - 1) + operation;
                }
                //and if two numbers and a sign are entered, we first calculate the result
                else if ((tmp.Contains("+") || tmp.Contains("-") || tmp.Contains("X") || tmp.Contains("÷")) && textBox2.Text != "0")
                {
                    SolveIt();
                    textBox1.Text = textBox2.Text + operation;
                    textBox2.Text = "0";
                }
                /*else
                {
                    SolveIt();
                }*/

            }
                   
        }
        //######This method is used to perform arithmetic operations selected by the user.################
        private void SolveIt()
        {
            double x, y;
            string input = textBox1.Text;
            string tmp = "";
            string operation = input.Substring(input.Length - 1);
            string xText = textBox1.Text.Remove(input.Length - 1);
            x = double.Parse(xText);        //if your operating system has decimal fractions separated
            y = double.Parse(textBox2.Text);// by a comma, replace these 2 lines with
                                            //x = double.Parse(xText.Replace(".", ",")); and y = double.Parse(textBox2.Text.Replace(".", ","));
            switch (operation)
            {
                case "+":
                    tmp = (x + y).ToString();
                    break;
                case "-":
                    tmp = (x - y).ToString();
                    break;
                case "X":
                    tmp = (x * y).ToString();
                    break;
                case "÷":
                    tmp = (x / y).ToString();
                    if (y != 0)  //check when dividing by 0
                    {
                        tmp = (x / y).ToString();
                    }
                    else
                    {
                        tmp = "Error!";  //when trying to divide by zero we report an error
                    }
                    break;
            }
            textBox1.Text = "";
            textBox2.Text = tmp;
        }
        //#########################entering dot in number

        private void button_Point_Click(object sender, EventArgs e)
        {

            if (!(textBox2.Text.Contains('.')))   //if the entered number does not yet contain a point, then add it
            {
                textBox2.Text += ".";
            }
            else if (textBox2.Text == "Error!")  //if before a new calculation an error message was
                                                 //received, then we delete it and replace it with 0.
            {
                textBox2.Text = "0.";
            }

        }
        //############## this is the method for the enter button — calculations are performed if they are possible
        private void button_Enter_Click(object sender, EventArgs e)  
        {
            if (textBox1.Text != ""&&textBox2.Text!="Error!")
            {
                SolveIt();
            }
            
        }
        //################### This, naturally, clearing TextBoxes fields
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = "";
        }
    }
}
