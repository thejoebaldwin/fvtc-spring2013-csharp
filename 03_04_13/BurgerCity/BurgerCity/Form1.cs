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
        s
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
            lblBurgerCost.Text = "All Burgers Are " + BURGER_PRICE.ToString("c");
            lblExtrasCost.Text = "All Extras Are " + EXTRAS_PRICE.ToString("c");
            //string strPricingMessage = "All Burgers Are " + BURGER_PRICE.ToString("c")
            //            + "\nAll Extras Are " + EXTRAS_PRICE.ToString("c");
            //lblBurgerCost.Text = strPricingMessage;


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
            bool blnBurgerSuccess = Int32.TryParse(txtBurgerCount.Text, out intBurgerCount);
            bool blnExtrasSuccess = Int32.TryParse(txtExtraCount.Text, out intExtrasCount);
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

            string strErrorMessage = string.Empty;

            if (blnBurgerSuccess)
            {
                //lblError.Text = string.Empty;
            }
            else
            {
                //lblError.Text = "Please enter a number for Burger Count";
                strErrorMessage = "Please enter a number for Burger Count. ";
            }
            if (chkExtraCount.Checked)
            {
                if (blnExtrasSuccess)
                {
                    //lblError.Text = string.Empty;
                }
                else
                {
                    //lblError.Text = "Please enter a number for Extras Count";
                    strErrorMessage = strErrorMessage + "\nPlease enter a number for Extras Count.";

                }

            }

            lblError.Text = strErrorMessage;



        }

        private void txtBurgerCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblExtraCount_Click(object sender, EventArgs e)
        {

        }

        private void txtExtraCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void lblExtrasCost_Click(object sender, EventArgs e)
        {

        }
    }
}
