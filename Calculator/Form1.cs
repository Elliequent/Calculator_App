using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string prevEquation = "", prevOperation = "", operation = "";

        public static double answer = 0;

        private void Allbtn_ClickEvent(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnDEL":
                    if (txtDisplay.Text.Length > 0)
                    {
                        txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    }
                    break;
                case "btnClear":
                    operation = "";
                    txtDisplay.ResetText();
                    break;
                case "btnCE":
                    operation = "";
                    txtDisplay.ResetText();
                    break;
                case "btnPeriod":
                    if (!txtDisplay.Text.Contains("."))
                    {
                        txtDisplay.Text = ".";
                    }
                    break;
                case "btnPlusMinus":
                    if (txtDisplay.Text.Length > 0)
                    {
                        if (!txtDisplay.Text.Contains("-"))
                        {
                            txtDisplay.Text = "-" + txtDisplay.Text;
                        }
                        else if (txtDisplay.Text.Contains("-"))
                        {
                            txtDisplay.Text = txtDisplay.Text.Substring(1, txtDisplay.Text.Length - 1);
                        }
                    }
                    break;
                default:
                    if (operation == "=")
                    {
                        operation = "";
                        txtDisplay.ResetText();
                    }
                    txtDisplay.Text += btn.Text;

                    break;
            }
        }   // End of Method

        private void Operation_Click (object sender, EventArgs e)
        {
            Button opr = sender as Button;

            switch (opr.Text)
            {
                case "+":
                    if (txtDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            prevEquation = txtDisplay.Text;
                            txtDisplay2.Text = prevEquation + operation;
                            txtDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "+";
                        multi_equations();
                    }
                    break;
                case "-":
                    if (operation == "" || operation == "=")
                    {
                        operation = "-";
                        prevOperation = operation;
                        prevEquation = txtDisplay.Text;
                        txtDisplay2.Text = prevEquation + operation;
                        txtDisplay.ResetText();
                    }
                    else
                    {
                        operation = "-";
                        multi_equations();
                    }
                        break;
                case "/":
                    if (operation == "" || operation == "=")
                    {
                        operation = "/";
                        prevOperation = operation;
                        prevEquation = txtDisplay.Text;
                        txtDisplay2.Text = prevEquation + operation;
                        txtDisplay.ResetText();
                    }
                    else
                    {
                        operation = "/";
                        multi_equations();
                    }
                    break;
                case "X":
                    if (operation == "" || operation == "=")
                    {
                        operation = "X";
                        prevOperation = operation;
                        prevEquation = txtDisplay.Text;
                        txtDisplay2.Text = prevEquation + operation;
                        txtDisplay.ResetText();
                    }
                    else
                    {
                        operation = "X";
                        multi_equations();
                    }
                    break;
                case "=":
                    if (txtDisplay.Text.Length > 0)
                    {
                        operation = "=";
                        multi_equations();
                        txtDisplay2.ResetText();
                        txtDisplay.Text = answer.ToString();
                    }
                    break;
            }
        }   // End of Method

        private void multi_equations()
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(txtDisplay.Text);

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if(prevOperation == "-")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(txtDisplay.Text);

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if (prevOperation == "/")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(txtDisplay.Text);

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if (prevOperation == "X")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(txtDisplay.Text);

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }

        }   // End of Method
    }
}