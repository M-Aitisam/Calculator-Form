using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
       
        string option;
        int result;
        int num1;
        int num2;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";   //button12.Text
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            option = "-";   //button12.Text
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = "*";   //button12.Text
            num1= int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";   //button12.Text
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);
            if (option.Equals("+")) result = num1 + num2; // method 2 option == ("+")
            else if (option.Equals("-")) result = num1 - num2;
            else if (option.Equals("*")) result = num1 * num2;
           else if (option.Equals("/"))
            {
                if (num2 != 0) // Add check for division by zero.
                    result = num1 / num2;
                else
                    MessageBox.Show("Cannot divide by zero");
            }

            txtTotal.Text = result + "";
        }
    }
}
