using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BurgerCity
{
    public partial class Form1 : Form
    {

        const double BURGER_PRICE = 8;
        const double EXTRAS_PRICE = 1.10;

        public Form1()
        {
            InitializeComponent();
        }

        private void chkExtraCount_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkExtraCount.Checked == true)
            //{
            //    lblExtraCount.Visible = true;
            //    txtExtraCount.Visible = true;
            //} //end if statement
            //if (chkExtraCount.Checked != true)
            //{
            //    lblExtraCount.Visible = false;
            //    txtExtraCount.Visible = false;
            //}

            //if (chkExtraCount.Checked == false)
            //{
            //    lblExtraCount.Hide();
            //    txtExtraCount.Hide();
            //}
            //else
            //{
            //    lblExtraCount.Show();
            //    txtExtraCount.Show();
            //}


            if (chkExtraCount.Checked)
            {
                lblExtraCount.Enabled = true;
                txtExtraCount.Enabled = true;
            }
            else
            {
                lblExtraCount.Enabled = false;
                txtExtraCount.Enabled = false;
            }

            //lblExtraCount.Visible = chkExtraCount.Checked;
            //txtExtraCount.Visible = chkExtraCount.Checked;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
            lblBurgerCost.Text = BURGER_PRICE.ToString("c");
            lblExtrasCost.Text = EXTRAS_PRICE.ToString("c");


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            int intBurgerCount = 0;
            Double dblTotal = 0;
            int intExtrasCount = 0;
            Double dblExtrasTotal = 0;
            Double dblFinalTotal = 0;
   
            //get user input
            Int32.TryParse(txtBurgerCount.Text, out intBurgerCount);
            Int32.TryParse(txtExtraCount.Text, out intExtrasCount);
            //calculations
            //  # of burgers x $8
            dblTotal = intBurgerCount * BURGER_PRICE;
            //only calculate extras total if checkbox is checked
            if (chkExtraCount.Checked)
            {
                // extra total = # of extras x 1
                dblExtrasTotal = intExtrasCount * EXTRAS_PRICE;
            }
            dblFinalTotal = dblTotal + dblExtrasTotal;
            //output results to user
            lblTotal.Text = dblFinalTotal.ToString("c");


        }
    }
}
