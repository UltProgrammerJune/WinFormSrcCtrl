using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSrcCtrl
{
    public partial class Form1 : Form
    {
        private enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private Operation currentOperation = Operation.Add;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parse input values
            if (double.TryParse(txtInput1.Text, out double input1) && 
                double.TryParse(txtInput2.Text, out double input2))
            {
                double result;

                // Perform calculation based on selected operation
                switch (currentOperation)
                {
                    case Operation.Add:
                        result = input1 + input2;
                        break;
                    case Operation.Subtract:
                        result = input1 - input2;
                        break;
                    case Operation.Multiply:
                        result = input1 * input2;
                        break;
                    case Operation.Divide:
                        if (input2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.", 
                                           "Invalid Operation", 
                                           MessageBoxButtons.OK, 
                                           MessageBoxIcon.Error);
                            return;
                        }
                        result = input1 / input2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                // Display result in txtTotal
                txtTotal.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both input fields.", 
                               "Invalid Input", 
                               MessageBoxButtons.OK, 
                               MessageBoxIcon.Warning);
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAdd.Checked)
            {
                currentOperation = Operation.Add;
            }
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSub.Checked)
            {
                currentOperation = Operation.Subtract;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioDiv_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioDiv.Checked)
            {
                currentOperation = Operation.Divide;
            }
        }

        private void radioMulti_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioMulti.Checked)
            {
                currentOperation = Operation.Multiply;
            }
        }
    }
}
