using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputMirror
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "";

            //sets the cancel button
            this.CancelButton = btnExit;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // PSUEDOCODE
            //1. Get the input from user
            //2. Do calculations
            //3. Output the result


            //declare the string variable strDisplay
            //DECLARATION STATEMENT
            string strDisplay;
            //ASSIGNMENT STATEMENT
            strDisplay = txtDisplay.Text;

            //INITIALIZATION STATEMENT
            //(declaration AND assignment)
            string strFirstName = "Joe"; 
            

            //Some error checking. is it empty? 
            //  is it spelled right?

            lblDisplay.Text = strDisplay;
            txtDisplay.Focus();
            txtDisplay.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblDisplay.Text = "";
            txtDisplay.Focus();
        }
    }
}
