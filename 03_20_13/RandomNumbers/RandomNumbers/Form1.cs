using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //****version 1
            //create the random generator
            Random r = new Random();
            //use NextDouble() to generate a random double
            Double dblRandomNumber = r.NextDouble();
            //multiply by large number to move decimal point
            dblRandomNumber = dblRandomNumber * 100000000;
            //limit value to between 0 and 51
            dblRandomNumber = dblRandomNumber % 52;
            //add one to get value between 1 and 52
            dblRandomNumber = dblRandomNumber + 1;
            //cast into int to truncate decimal points
            int intRandomNumber = (int)dblRandomNumber;

            //*****version 2
            //create random number generator
            Random randomGenerator = new Random();
            //get next double, multiply by 10000 to get larger value, mod by 52 and add 1 to limit values
            int intRandom = (int)((randomGenerator.NextDouble() * 10000) % 52 + 1);



            lblRandom.Text = intRandomNumber.ToString();

        }

        private void lblRandom_Click(object sender, EventArgs e)
        {

        }
    }
}
