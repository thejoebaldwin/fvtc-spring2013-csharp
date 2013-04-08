using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTemp_TextChanged(object sender, EventArgs e)
        {
            SelectClothes();
        }

        private void SelectClothes()
        {
            int intTemp = 0;
            string strMessage = string.Empty;
            //get user input
            if (Int32.TryParse(txtTemp.Text, out intTemp) == false)
            {
                strMessage = "Please enter numeric input";
            }

            switch (intTemp)
            {
                case 60:
                    strMessage = "Red Jacket";
                    break;
                case 61:
                    strMessage = "Blue Jacket";
                    break;
                case 62:
                    strMessage = "Green Jacket";
                    break;
                case 63:
                    strMessage = "White Jacket";
                    break;
                case 64:
                    strMessage = "Purple Jacket";
                    break;
                case 65:
                    strMessage = "Black Jacket";
                    break;
                default:
                    strMessage = "This is only a fair weather calculator";
                    //SelectClothesOld();
                    break;
             
            }

            lblMessage.Text = strMessage;
        }

        private void SelectClothesOld()
        {
            //declare variables
            double dblTemp = 0;
            string strMessage = string.Empty;
            //get user input
            if (double.TryParse(txtTemp.Text, out dblTemp) == false)
            {
                strMessage = "Please enter numeric input";
            }
            //logic!

            if (dblTemp < -40 || dblTemp > 130)
            {
                strMessage = "Please check your input for a valid temperature";
            }
            //   Greater than 70 = t-shirt
            else if (dblTemp >= 70)
            {
                strMessage = "It's T-Shirt Weather!";
            }
            //   In between 40 and 70 = sweater
            else if (dblTemp < 70 && dblTemp > 40)
            {
                strMessage = "You should think about wearing a sweater today";
            }
            //   Less than 40 = jacket
            else if (dblTemp <= 40)
            {
                strMessage = "Better wear a jacket";
            }
            else
            {
                strMessage = "Temperature Not Accounted For";
            }
            //output results to user
            lblMessage.Text = strMessage;
        }

    }
}
