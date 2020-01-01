using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Calculator
{
    public partial class Graph_Generator : Form
    {
        public Graph_Generator()
        {
            InitializeComponent();
        }

        double[] arrayX;
        double[] arrayY;
        int elementNo = 0;
        int maxArraySize;

        private void Data_Submit(object sender, EventArgs e)
        {
            try
            {
                maxArraySize = int.Parse(txtData.Text);
                lblOutput.Text = maxArraySize.ToString();
            }
            catch (Exception)
            {
                lblOutput.Text = "Need to add a number Dumbass!";
            }
            
        }

        private void btnXAxis_Click(object sender, EventArgs e)
        {
            try
            {
                if (arrayX == null)
                {
                    arrayX = new double[maxArraySize];
                }

                if (elementNo <= maxArraySize - 1)
                {
                    int number = int.Parse(txtXAxis.Text);
                    arrayX[elementNo] = number;
                    elementNo++;

                    lblOutputX.Text = "";

                    for (int i = 0; i <= maxArraySize - 1; i++)
                    {
                        lblOutputX.Text = lblOutputX.Text + arrayX[i] + " ";
                    }
                }
                else if (elementNo >= 1)
                {
                    elementNo = 0;
                }
                else
                {
                    MessageBox.Show("Memory Full"); // Error message when array is full
                }
            }
            catch (IndexOutOfRangeException)
            {
                lblOutput.Text = "Please reload the Graphic Display Application";
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has occured - Error Report: \n " + error);
            }
        }

        private void btnYAxis_Click(object sender, EventArgs e)
        {
            try
            {
                if (arrayY == null)
                {
                    arrayY = new double[maxArraySize];
                }

                if (elementNo <= maxArraySize - 1)
                {
                    int number = int.Parse(txtYAxis.Text);
                    arrayY[elementNo] = number;
                    elementNo++;

                    lblOutputY.Text = "";

                    for (int i = 0; i <= maxArraySize - 1; i++)
                    {
                        lblOutputY.Text = lblOutputY.Text + arrayY[i] + " ";
                    }
                }
                else if (elementNo >= 1)
                {
                    elementNo = 0;
                }
                else
                {
                    MessageBox.Show("Memory Full"); // Error message when array is full
                }
            }
            catch (IndexOutOfRangeException)
            {
                lblOutput.Text = "Please reload the Graphic Display Application";
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has occured - Error Report: \n " + error);
            }

        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            try
            {
                if (maxArraySize == arrayX.Length && maxArraySize == arrayY.Length)
                {
                    for (int i = 0; i <= maxArraySize - 1; i++)
                    {
                        string valueX = arrayX[i].ToString();
                        string valueY = arrayY[i].ToString();
                        chrtGraph.Series[0].Points.AddXY(valueX, valueY);
                    }
                }
                else
                {
                    MessageBox.Show("To Make a char you must have two completed X and Y entries");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("An Error has occured - Error Record: \n" + error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chrtGraph.Series.Clear();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            try
            {
                if (arrayX.Length > 0)
                {
                    lblOutputX.Text = "";
                    Array.Clear(arrayX, 0, maxArraySize);
                }
                else
                {
                    lblOutputX.Text = "";
                }
                if (arrayY.Length > 0)
                {
                    lblOutputY.Text = "";
                    Array.Clear(arrayY, 0, maxArraySize);
                }
                else
                {
                    lblOutputY.Text = "";
                }
                lblOutput.Text = "";
                maxArraySize = 0;
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show("An Error has occured - Error Record: \n" + error);
            }
           
        }
    }
}
