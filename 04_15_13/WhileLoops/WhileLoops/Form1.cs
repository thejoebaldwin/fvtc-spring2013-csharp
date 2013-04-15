using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhileLoops
{
    public partial class Form1 : Form
    {

        int oneTimeCounter = 0;
        string[] StudentNames = { "Betty", "Bill", "Rick", "George", "Ron" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //acculator (counter)
            int i = 0;
            string strDisplay = "";

            //run this loop until i = 10
            while (i < StudentNames.Length)
            {
                strDisplay += StudentNames[i] + "\n";
                lblDisplay.Text = strDisplay;
                i++;
            }

            lblDisplay.Text = strDisplay;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string strDisplay = "";

            strDisplay = StudentNames[oneTimeCounter];


            lblDisplay.Text = strDisplay;

            oneTimeCounter++;
            if (oneTimeCounter >= StudentNames.Length)
            {
                oneTimeCounter = 0;
            }
        }
    }
}
