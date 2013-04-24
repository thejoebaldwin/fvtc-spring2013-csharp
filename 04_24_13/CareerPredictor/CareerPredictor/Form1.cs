using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CareerPredictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSalary.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbSalary.Items.Clear();
            //declare variables
            double dblBaseSalary = 0;
            double dblOldSalary = 0;
            double dblRaise = 0;
            double dblTotal = 0;
            double dblYear = 0;

            int counter = 0;
            //get input
            Double.TryParse(txtSalary.Text, out dblBaseSalary);
            Double.TryParse(txtRaise.Text, out dblRaise);
            Double.TryParse(textBox1.Text, out dblYear);
            dblRaise = 1 + (dblRaise / 100);
            //logic!
            //  start with base salary
            //  loop 5 times
            //  new salary = old salary * 1.03
            //  output new salary
            dblOldSalary = dblBaseSalary;

            for (int i = 0; i < dblYear; i++)
            {
                string strDisplay = "Year " + (i + 1).ToString() + ":" + dblOldSalary.ToString("c");
                lbSalary.Items.Add(strDisplay);
                Double dblNewSalary = dblOldSalary * dblRaise;
                dblTotal += dblOldSalary;
                dblOldSalary = dblNewSalary;
            }

            lbSalary.SelectedIndex = lbSalary.Items.Count - 1;

            //while (counter < dblYear)
            //{
            //    string strDisplay = "Year " + (counter + 1).ToString() + ":" + dblOldSalary.ToString("c");
            //    lbSalary.Items.Add(strDisplay);
            //    Double dblNewSalary = dblOldSalary * dblRaise;
            //    dblTotal += dblOldSalary;
            //    dblOldSalary = dblNewSalary;
            //    counter++;
            //}
            lbltotal.Text = dblTotal.ToString("c");
            txtSalary.Focus();
            txtSalary.SelectAll();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRaise_TextChanged(object sender, EventArgs e)
        {
            lbSalary.Items.Clear();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            lbSalary.Items.Clear();
        }
    }
}
