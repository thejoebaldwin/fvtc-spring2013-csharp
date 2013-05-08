using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{

  
     
    public partial class frmMain : Form
    {
        public frmAbout about;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Chocolate");
            listBox1.Items.Add("Vanilla");
            listBox1.Items.Add("Strawberry");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            about = new frmAbout();
            about.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            about.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //about.lblFlavor.Text = listBox1.SelectedItem.ToString();

            string strFlavor = listBox1.SelectedItem.ToString();

            about.SetFlavor(strFlavor);

        }
    }
}
