using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IncomeTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIncomeTax.Text = "";
            lblNetSalary.Text = "";
        }

       
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables
            Double dblSalary = 0;
            Double dblIncomeTaxOwed = 0;
            Double dblNetSalary = 0;
            //get user input
            dblSalary = Convert.ToDouble(txtSalary.Text);
            //calculation
            //   income tax amount = salary x 6.5%
            dblIncomeTaxOwed = dblSalary * .065;
            //   net salary = salary - income tax amount
            dblNetSalary = dblSalary - dblIncomeTaxOwed;
            //output results to user
            lblIncomeTax.Text = dblIncomeTaxOwed.ToString("c");
            lblNetSalary.Text = dblNetSalary.ToString("c");

            txtSalary.Focus();
            txtSalary.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Clear();
            lblIncomeTax.Text = "";
            lblNetSalary.Text = "";
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lblIncomeTax.Text = "";
            lblNetSalary.Text = "";
        }
    }
}
