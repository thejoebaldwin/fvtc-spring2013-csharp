using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPractical1
{
    public partial class Exer1Form : Form
    {
        public Exer1Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // make the label say "good luck!"
            lblDisplay.Text = "Good Luck!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the top label to say Practice Practical #1
            lblPractical.Text = "Practice Practical #1";
            //clear out the bottom label
            lblDisplay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear out both labels
            lblPractical.Text = "";
            lblDisplay.Text = "";
        }
    }
}
