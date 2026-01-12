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
        private bool isAddOperation = true;

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
                if (isAddOperation)
                {
                    result = input1 + input2;
                }
                else
                {
                    result = input1 - input2;
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
                isAddOperation = true;
            }
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSub.Checked)
            {
                isAddOperation = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
