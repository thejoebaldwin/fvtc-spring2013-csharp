using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSalary.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declare variables
            Double dblWage = 0;
            Double dblHours = 0;
            Double dblSalary = 0;
            //get input from the user
            //get the wage from the user
            //dblWage = Convert.ToDouble(txtWage.Text);
            //this following line is the same as the line above
            // EXCEPT this won't crash the program
            Double.TryParse(txtWage.Text,out dblWage);

            //dblHours = Convert.ToDouble(txtHours.Text);
            Double.TryParse(txtHours.Text, out dblHours);

            //calculate
            //salary = wage * hours per week * 52 weeks
            dblSalary = dblWage * dblHours * 52;
            //output to the user
            lblSalary.Text = Convert.ToString(dblSalary);


            txtWage.Focus();
            txtWage.SelectAll();


            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this is the same thing
            txtHours.Text = "";
            txtHours.Clear();

            txtWage.Clear();
            txtWage.Focus();
            lblSalary.Text = "";
        }
    }
}
