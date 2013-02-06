using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Totals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtValue.Focus();

            //string strMessage;
            //int intTotal = 0;
            //strMessage = intTotal.ToString();
            //MessageBox.Show(strMessage);
            //Application.Exit();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //psuedocode:
            //1.declare variables
            int intValue;
            int intTotal;
            //2.get the user input
            intValue = Convert.ToInt32(txtValue.Text);
            //3.calculate
            intTotal = intValue * 2;
            //4.output to the user
            lblMessage.Text = intTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //psuedocode
            //1.declare variables
            double dblValue;
            double dblTotal;
            //2.get the user input
            dblValue =  Convert.ToDouble(txtValue.Text);
            //3.calculate
            dblTotal = dblValue / 2;
            //4.output to the user
            lblMessage.Text = dblTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //psuedocode:
            //1.declare variables
            double dblValue;
            int intTotal;
            //2.get the user input
            dblValue = Convert.ToDouble(txtValue.Text);
            //3.calculate
            intTotal = (int) dblValue / 2;
            //4.output to the user
            lblMessage.Text = intTotal.ToString();
        }


    }
}
