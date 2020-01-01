using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Programmers_Calculator : Form
    {
        public Programmers_Calculator()
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
            btnMultiply.MouseEnter += OnMouseEnterButton1;
            btnMultiply.MouseLeave += OnMouseLeaveButton1;
            btnPeriod.MouseEnter += OnMouseEnterButton1;
            btnPeriod.MouseLeave += OnMouseLeaveButton1;
            btnPlusMinus.MouseEnter += OnMouseEnterButton1;
            btnPlusMinus.MouseLeave += OnMouseLeaveButton1;
            btnSubtract.MouseEnter += OnMouseEnterButton1;
            btnSubtract.MouseLeave += OnMouseLeaveButton1;
            btnConBin.MouseEnter += OnMouseEnterButton1;
            btnConBin.MouseLeave += OnMouseLeaveButton1;
            btnConDec.MouseEnter += OnMouseEnterButton1;
            btnConDec.MouseLeave += OnMouseLeaveButton1;
            btnConDex.MouseEnter += OnMouseEnterButton1;
            btnConDex.MouseLeave += OnMouseLeaveButton1;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)    // Mouse over any buttons
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
            btnMultiply.BackColor = Color.Black;
            btnPeriod.BackColor = Color.Black;
            btnPlusMinus.BackColor = Color.Black;
            btnSubtract.BackColor = Color.Black;
            btnConBin.BackColor = Color.Black;
            btnConDec.BackColor = Color.Black;
            btnConDex.BackColor = Color.Black;
            btnConBin.BackColor = Color.Black;
            btnConDec.BackColor = Color.Black;
            btnConDex.BackColor = Color.Black;
        }   // End of Method

        private void OnMouseLeaveButton1(object sender, EventArgs e)    // Mouse leaving button space
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
            btnMultiply.BackColor = Color.Black;
            btnPeriod.BackColor = Color.Black;
            btnPlusMinus.BackColor = Color.Black;
            btnSubtract.BackColor = Color.Black;
        }   // End of Method

        // Global Variables
        public static string prevEquation = "", prevOperation = "", operation = "";
        public static double answer = 0;

        private void Allbtn_ClickEvent(object sender, EventArgs e)  // Event for number buttons, CE, C DEL, +/-, . and =
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

        public bool hex_void_test(string txtDisplay)    // Confirm txtDisplay is a hexidecimal entry
        {
            return Regex.IsMatch(txtDisplay, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public bool Bin_void_test(string txtDisplay)
        {
                bool vaild = Regex.IsMatch(txtDisplay.ToString(), "^[01]+$");
                return vaild;
        }

        private void btnConDex_Click(object sender, EventArgs e)    // Decimal or binary to Hex
        {
            try
            {
                string input = txtDisplay.Text;

                if (Bin_void_test(txtDisplay.Text) == true)
                {
                    string hex = txtDisplay.Text;
                    string hexvalue = Convert.ToInt32(hex.ToString(), 2).ToString("X");
                    txtDisplay.Text = hexvalue;
                }
                else if (hex_void_test(txtDisplay.Text) == true)
                {
                    int num = int.Parse(input);
                    string hexvalue = num.ToString("X");
                    txtDisplay.Text = hexvalue;
                }
                
            }
            catch (FormatException)
            {
                txtDisplay.Text = "Error";
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has Occured - Error Report: \n " + error);
            }
           
        }

        private void btnConBin_Click(object sender, EventArgs e)    // Decimal or hex to Binary
        {
            try
            {
                string input = txtDisplay.Text;
                int num;

                if (Bin_void_test(txtDisplay.Text) == true)
                {
                    txtDisplay.Text = "Error";
                }
                else if (int.TryParse(input, out num))
                {
                    string binary = Convert.ToString(num, 2);
                    txtDisplay.Text = binary.ToString();
                }
                else if (hex_void_test(txtDisplay.Text) == true)
                {
                    string binary = Convert.ToString(Convert.ToInt64(input, 16), 2);
                    txtDisplay.Text = binary.ToString();
                }
                

            }
            catch (FormatException)
            {
                txtDisplay.Text = "Error";
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has Occured - Error Report: \n " + error);
            }
        }

        private void btnConDec_Click(object sender, EventArgs e)    // Hex or binary to decimal
        {
            try
            {
                string input = txtDisplay.Text;
                int num;

                if (int.TryParse(input, out num))
                {
                    string dec = Convert.ToInt32(num.ToString(), 2).ToString();
                    txtDisplay.Text = dec.ToString();
                }
                else if (hex_void_test(txtDisplay.Text) == true)
                {
                    int dec = int.Parse(input.ToString(), NumberStyles.HexNumber);
                    txtDisplay.Text = dec.ToString();
                }

            }
            catch (FormatException)
            {
                txtDisplay.Text = "Error";
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has Occured - Error Report: \n " + error);
            }
            
        }

        private void Operation_Click(object sender, EventArgs e)   // Operator buttons
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

        private void multi_equations()  // Calculations determined by operator buttons above
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) + Convert.ToDouble(txtDisplay.Text);    // +

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if (prevOperation == "-")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) - Convert.ToDouble(txtDisplay.Text);    // -

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if (prevOperation == "/")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) / Convert.ToDouble(txtDisplay.Text);    // /

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }
            else if (prevOperation == "x")
            {
                prevOperation = operation;

                answer = Convert.ToDouble(prevEquation) * Convert.ToDouble(txtDisplay.Text);    // x

                prevEquation = answer.ToString();
                txtDisplay2.Text = prevEquation + operation;
                txtDisplay.ResetText();
            }

        }   // End of Method
    }
}
