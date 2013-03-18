using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IceCreamShoppe
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // checkBox1.Checked = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateFlavor();



        }


        /// <summary>
        /// 
        /// </summary>
        private void UpdateFlavor()
        {
            if (rbChocolate.Checked)
            {
                lblFlavor.Text = "You selected Chocolate";
            }
            else if (rbVanilla.Checked)
            {
                lblFlavor.Text = "You selected Vanilla";
            }
            else if (rbStrawberry.Checked)
            {
                lblFlavor.Text = "You selected Strawberry";
            }

        }

        private void rbChocolate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();

        }

        private void rbVanilla_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();



        }

      private void rbStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlavor();



        }
    }
}
