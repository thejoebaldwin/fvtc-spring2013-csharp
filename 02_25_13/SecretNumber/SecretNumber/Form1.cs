using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecretNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //Declare variables
            int intNumber = 0;
            int intSecret = 6;
            //get the user input
            Int32.TryParse(txtNumber.Text, out intNumber);
            //logic!
            // is intNumber equal to intSecret?
            // if equal then display "you are correct!"
            if (intNumber == intSecret)
            {
                //MessageBox.Show("you are correct!");
                lblMessage.Text = "You are correct!";
                //output to the user
            }
            if (intNumber != intSecret)
            {
                lblMessage.Text = "Try Again!";
            }





            if (intSecret == intNumber)
            {

            }

            



            
        } //end of function brace

    } //end of class brace
    //end of namespace brace
}
