using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CombinationLock
{
    public partial class Form1 : Form
    {
        const string PIN_1 = "1";
        const string PIN_2 = "2";
        const string PIN_3 = "3";


        public Form1()
        {
            InitializeComponent();
        }

        private void cbPin1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCombinationLock();
        }

        private void cbPin2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCombinationLock();
        }

        private void cbPin3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCombinationLock();
        }

        private void CheckCombinationLock()
        {
            //declare variables
            string strPin1 = "";
            string strPin2 = "";
            string strPin3 = "";
            //get user input
            if (cbPin1.SelectedItem != null) 
            {
                strPin1 = cbPin1.SelectedItem.ToString();
            }
            if (cbPin2.SelectedItem != null)
            {
                strPin2 = cbPin2.SelectedItem.ToString();
            }
            if (cbPin3.SelectedItem != null)
            {
                strPin3 = cbPin3.SelectedItem.ToString();
            }
            //logic!
            /*
            if (strPin1 == PIN_1)
            {
                if (strPin2 == PIN_2)
                {
                    if (strPin3 == PIN_3)
                    {
                        btnUnlock.Enabled = true;
                    }
                }
            }
            */

            if (strPin1 == PIN_1 
                && strPin2 == PIN_2
                && strPin3 == PIN_3)
            {
                btnUnlock.Enabled = true;
            }
            else
            {
                btnUnlock.Enabled = false;
            }

            //output to user
            Double dblTest = 4.5678;
            //dblTest = Math.Truncate(
        }

    }
}
