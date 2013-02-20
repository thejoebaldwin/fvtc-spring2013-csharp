using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDays.Clear();
            txtMovies.Clear();
            lblTotal.Text = "";
            txtMovies.Focus();

        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            int intMovies = 0;
            int intDays = 0;
            Double dblTotal = 0;
            //get user input
            //Int32.TryParse(txtMovies.Text, out intMovies);
            intMovies = Int32.Parse(txtMovies.Text);
            Int32.TryParse(txtDays.Text, out intDays);

            

            //calculations
            //  Total Cost = # of movies x # days x $3
            dblTotal = intMovies * intDays * 3;
            //output to user
            lblTotal.Text = dblTotal.ToString("c");
            //return focus to first textbox
            txtMovies.Focus();
            txtMovies.SelectAll();
        }
    }
}
