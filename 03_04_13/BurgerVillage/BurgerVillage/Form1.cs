using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BurgerVillage
{
    public partial class Form1 : Form
    {

        const double LETTUCE_PRICE = 0.5;
        const double TOMATO_PRICE = 0.75;
        const double ONION_PRICE = 0.25;
        double dblTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
        }

        private void chkLettuce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLettuce.Checked)
            {
                dblTotal = dblTotal + LETTUCE_PRICE;
            }
            else
            {
                dblTotal = dblTotal - LETTUCE_PRICE;
            }
            lblTotal.Text = dblTotal.ToString("c");

            //double dblTotalCost = 0;
            //if (chkLettuce.Checked)
            //{
            //    dblTotalCost = dblTotalCost + LETTUCE_PRICE;
            //}

            //if (chkTomato.Checked)
            //{
            //    dblTotalCost = dblTotalCost + TOMATO_PRICE;
            //}

            //if (chkOnion.Checked)
            //{
            //    dblTotalCost = dblTotalCost + ONION_PRICE;
            //}

            //lblTotal.Text = dblTotalCost.ToString("c");
        }

        private void chkTomato_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTomato.Checked)
            {
                dblTotal = dblTotal + TOMATO_PRICE;
            }
            else
            {
                dblTotal = dblTotal - TOMATO_PRICE;
            }
            lblTotal.Text = dblTotal.ToString("c");

            //double dblTotalCost = 0;
            //if (chkLettuce.Checked)
            //{
            //    dblTotalCost = dblTotalCost + LETTUCE_PRICE;
            //}

            //if (chkTomato.Checked)
            //{
            //    dblTotalCost = dblTotalCost + TOMATO_PRICE;
            //}

            //if (chkOnion.Checked)
            //{
            //    dblTotalCost = dblTotalCost + ONION_PRICE;
            //}

            //lblTotal.Text = dblTotalCost.ToString("c");
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                dblTotal = dblTotal + ONION_PRICE;
            }
            else
            {
                dblTotal = dblTotal - ONION_PRICE;
            }
            lblTotal.Text = dblTotal.ToString("c");

            //double dblTotalCost = 0;
            //if (chkLettuce.Checked)
            //{
            //    dblTotalCost = dblTotalCost + LETTUCE_PRICE;
            //}

            //if (chkTomato.Checked)
            //{
            //    dblTotalCost = dblTotalCost + TOMATO_PRICE;
            //}

            //if (chkOnion.Checked)
            //{
            //    dblTotalCost = dblTotalCost + ONION_PRICE;
            //}

            //lblTotal.Text = dblTotalCost.ToString("c");
        }
    }
}
