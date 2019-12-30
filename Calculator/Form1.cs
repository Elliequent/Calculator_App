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

            btn0.MouseEnter += OnMouseEnterButton1;
            btn0.MouseLeave += OnMouseLeaveButton1;
            btn1.MouseEnter += OnMouseEnterButton1;
            btn1.MouseLeave += OnMouseLeaveButton1;
            btn2.MouseEnter += OnMouseEnterButton1;
            btn2.MouseLeave += OnMouseLeaveButton1;
            btn3.MouseEnter += OnMouseEnterButton1;
            btn3.MouseLeave += OnMouseLeaveButton1;
            btn4.MouseEnter += OnMouseEnterButton1;
            btn4.MouseLeave += OnMouseLeaveButton1;
            btn5.MouseEnter += OnMouseEnterButton1;
            btn5.MouseLeave += OnMouseLeaveButton1;
            btn6.MouseEnter += OnMouseEnterButton1;
            btn6.MouseLeave += OnMouseLeaveButton1;
            btn7.MouseEnter += OnMouseEnterButton1;
            btn7.MouseLeave += OnMouseLeaveButton1;
            btn8.MouseEnter += OnMouseEnterButton1;
            btn8.MouseLeave += OnMouseLeaveButton1;
            btn9.MouseEnter += OnMouseEnterButton1;
            btn9.MouseLeave += OnMouseLeaveButton1;
            btnAdd.MouseEnter += OnMouseEnterButton1;
            btnAdd.MouseLeave += OnMouseLeaveButton1;
            btnCE.MouseEnter += OnMouseEnterButton1;
            btnCE.MouseLeave += OnMouseLeaveButton1;
            btnClear.MouseEnter += OnMouseEnterButton1;
            btnClear.MouseLeave += OnMouseLeaveButton1;
            btnDEL.MouseEnter += OnMouseEnterButton1;
            btnDEL.MouseLeave += OnMouseLeaveButton1;
            btnDivide.MouseEnter += OnMouseEnterButton1;
            btnDivide.MouseLeave += OnMouseLeaveButton1;
            btnEquals.MouseEnter += OnMouseEnterButton1;
            btnEquals.MouseLeave += OnMouseLeaveButton1;
            btnMemClear.MouseEnter += OnMouseEnterButton1;
            btnMemClear.MouseLeave += OnMouseLeaveButton1;
            btnMemNeg.MouseEnter += OnMouseEnterButton1;
            btnMemNeg.MouseLeave += OnMouseLeaveButton1;
            btnMemPos.MouseEnter += OnMouseEnterButton1;
            btnMemPos.MouseLeave += OnMouseLeaveButton1;
            btnMultiply.MouseEnter += OnMouseEnterButton1;
            btnMultiply.MouseLeave += OnMouseLeaveButton1;
            btnPeriod.MouseEnter += OnMouseEnterButton1;
            btnPeriod.MouseLeave += OnMouseLeaveButton1;
            btnPlusMinus.MouseEnter += OnMouseEnterButton1;
            btnPlusMinus.MouseLeave += OnMouseLeaveButton1;
            btnSubtract.MouseEnter += OnMouseEnterButton1;
            btnSubtract.MouseLeave += OnMouseLeaveButton1;
        }   // End of Method

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            btn0.BackColor = Color.Black;
            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn9.BackColor = Color.Black;
            btnAdd.BackColor = Color.Black;
            btnCE.BackColor = Color.Black;
            btnClear.BackColor = Color.Black;
            btnDEL.BackColor = Color.Black;
            btnDivide.BackColor = Color.Black;
            btnEquals.BackColor = Color.Black;
            btnMemClear.BackColor = Color.Black;
            btnMemNeg.BackColor = Color.Black;
            btnMemPos.BackColor = Color.Black;
            btnMultiply.BackColor = Color.Black;
            btnPeriod.BackColor = Color.Black;
            btnPlusMinus.BackColor = Color.Black;
            btnSubtract.BackColor = Color.Black;
        }   // End of Method
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            btn0.BackColor = Color.Black;
            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn9.BackColor = Color.Black;
            btnAdd.BackColor = Color.Black;
            btnCE.BackColor = Color.Black;
            btnClear.BackColor = Color.Black;
            btnDEL.BackColor = Color.Black;
            btnDivide.BackColor = Color.Black;
            btnEquals.BackColor = Color.Black;
            btnMemClear.BackColor = Color.Black;
            btnMemNeg.BackColor = Color.Black;
            btnMemPos.BackColor = Color.Black;
            btnMultiply.BackColor = Color.Black;
            btnPeriod.BackColor = Color.Black;
            btnPlusMinus.BackColor = Color.Black;
            btnSubtract.BackColor = Color.Black;
        }   // End of Method

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
                    txtDisplay2.ResetText();
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


        int[] array = new int[1];
        int elementNo = 0;

        private void Memory_Function(object sender, EventArgs e)
        {
            Button mem = sender as Button;

            switch (mem.Text)
            {
                case "M+":
                    if (elementNo <= array.Length - 1)
                    {
                        int number = int.Parse(txtDisplay.Text);
                        array[elementNo] = number;
                        elementNo++;

                        lblOutput.Text = "";

                        for (int i = 0; i <= array.Length - 1; i++)
                        {
                            lblOutput.Text = lblOutput.Text + array[i] + " " + "\n";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Memory Full");
                    }
                    break;
                case "M-":
                    lblOutput.Text = "";
                    Array.Clear(array, 0, 1);
                    elementNo = 0;
                    break;
                case "MC":
                    txtDisplay.Text = lblOutput.Text;
                    break;
            }
        }

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
                case "x":
                    if (operation == "" || operation == "=")
                    {
                        operation = "x";
                        prevOperation = operation;
                        prevEquation = txtDisplay.Text;
                        txtDisplay2.Text = prevEquation + operation;
                        txtDisplay.ResetText();
                    }
                    else
                    {
                        operation = "x";
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
            else if (prevOperation == "x")
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