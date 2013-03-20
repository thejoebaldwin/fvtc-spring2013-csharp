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

            string strMessage = string.Empty;

            if (rbChocolate.Checked)
            {
                strMessage = "You selected Chocolate";
                this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.chocolate;
            }
            else if (rbVanilla.Checked)
            {
                strMessage = "You selected Vanilla";
                this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.vanilla;
            }
            else if (rbStrawberry.Checked)
            {
                strMessage = "You selected Strawberry";
                this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.strawberry;
            }


            if (rbChocolate2.Checked)
            {
                strMessage = strMessage + " and Chocolate";
                //this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.chocolate;
            }
            else if (rbVanilla2.Checked)
            {
                strMessage = strMessage + " and Vanilla";
                //this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.vanilla;
            }
            else if (rbStrawberry2.Checked)
            {
                strMessage = strMessage + " and Strawberry";
                //this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.strawberry;
            }

            lblFlavor.Text = strMessage;

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

      private void rbChocolate2_CheckedChanged(object sender, EventArgs e)
      {
          UpdateFlavor();
      }

      private void rbVanilla2_CheckedChanged(object sender, EventArgs e)
      {
          UpdateFlavor();
      }

      private void rbStrawberry2_CheckedChanged(object sender, EventArgs e)
      {
          UpdateFlavor();
      }
    }
}
