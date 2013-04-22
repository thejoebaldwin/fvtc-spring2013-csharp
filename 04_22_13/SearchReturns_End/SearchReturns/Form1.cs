using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SearchReturns
{
    public partial class Form1 : Form
    {

        private string[] Students = {"John", "Stacy", "Tony", "Jeff", "Rick",
                                    "Tom", "Peter", "Tanya", "Betty", "Suzie",
                                     "Ronald", "Roxanne", "Keith", "Ken", "Liz",
                                     "James", "Pattty", "Paul", "Judd", "Ashley" };
        
        private int[] SavingsBalance = {0, 200, 10000, 12000, 7000,
                                        340, 56, 45, 56, 800, 
                                        9400, 800, 6400, 5600, 4800, 
                                        45, 560, 28 , 0, 20};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 0;
            while (counter < Students.Length)
            {
                lbStudents.Items.Add(Students[counter]);
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTotal.Text = getTotal().ToString("c");
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intSelectedIndex = lbStudents.SelectedIndex;
            lblBalance.Text = SavingsBalance[intSelectedIndex].ToString("c");
        }

        private int getTotal()
        {
            int intTotal = 0;
            //loop goes here
            int counter = 0;
            while (counter < SavingsBalance.Length)
            {
                intTotal += SavingsBalance[counter];
                counter++;
            }
            return intTotal;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int intTotal = getTotal();
            double dblAverage = intTotal / SavingsBalance.Length;
            lblAverage.Text = dblAverage.ToString("c");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int intSelectedIndex = -1;
            string strSearch = txtName.Text.ToUpper();
            while (counter < Students.Length)
            {
                if (strSearch == Students[counter].ToUpper())
                {
                    intSelectedIndex = counter;
                    break;
                }
                counter++;
            }

            if (intSelectedIndex > -1)
            {
                lbStudents.SelectedIndex = intSelectedIndex;
            }

        }
    }
}
