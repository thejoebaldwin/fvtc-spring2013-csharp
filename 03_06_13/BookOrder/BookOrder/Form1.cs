using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookOrder
{
    public partial class Form1 : Form
    {
        const double BOOK_COST = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            Double dblTotal = 0;
            Double dblBookQuantity = 0;
            string strFirstName = string.Empty;
            string strLastName = string.Empty;
            string strUserName = string.Empty;
            string strMessage = string.Empty;
            //get user input
            bool blnBookQuantitySuccess = Double.TryParse(txtBookQuantity.Text, out dblBookQuantity);
            if (blnBookQuantitySuccess == false)
            {
                MessageBox.Show("Must Be Numeric Input");
            }
            strFirstName = txtFirstName.Text;
            strFirstName = strFirstName.Trim();
            strLastName = txtLastName.Text.Trim();
            if (strFirstName == string.Empty)
            {
                MessageBox.Show("Please enter your first name!");
            }
            if (strLastName == string.Empty)
            {
                MessageBox.Show("Please enter your last name!");
            }

            //do calculations
            //Total = # of books times BOOK_COST
            dblTotal = dblBookQuantity * BOOK_COST;
            //Username = First Name + Last Name
            strUserName = strFirstName + " " + strLastName;
            //output to user
            //Final output = Username owes $Total
            strMessage = strUserName + " owes " + dblTotal.ToString("c");
            //output first and last name and total
            lblMessage.Text = strMessage.ToLower();
                
        }
    }
}
