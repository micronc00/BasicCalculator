using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass calculator;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            calculator = new CalculatorClass();
            num1 = 0;
            num2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = txtBoxInput1.Text == "" ? 0 : Convert.ToDouble(txtBoxInput1.Text);
            num2 = txtBoxInput2.Text == "" ? 0 : Convert.ToDouble(txtBoxInput2.Text);
            string output = cbOperator.Text;

            if (output == "+")
            {
                calculator.CalculateEvent += new Formula<double>(calculator.GetSum);
                lblDisplayTotal.Text = calculator.GetSum(num1, num2).ToString();
                calculator.CalculateEvent -= new Formula<double>(calculator.GetSum);
            }
            else if (output == "-")
            {
                calculator.CalculateEvent += new Formula<double>(calculator.GetDifference);
                lblDisplayTotal.Text = calculator.GetDifference(num1, num2).ToString();
                calculator.CalculateEvent -= new Formula<double>(calculator.GetDifference);
            }
            else if (output == "*")
            {
                calculator.CalculateEvent += new Formula<double>(calculator.GetProduct);
                lblDisplayTotal.Text = calculator.GetProduct(num1, num2).ToString();
                calculator.CalculateEvent -= new Formula<double>(calculator.GetProduct);
            }
            else if (output == "/")
            {
                calculator.CalculateEvent += new Formula<double>(calculator.GetQuotient);
                lblDisplayTotal.Text = calculator.GetQuotient(num1, num2).ToString();
                calculator.CalculateEvent -= new Formula<double>(calculator.GetQuotient);
            }
        }
    }
}
