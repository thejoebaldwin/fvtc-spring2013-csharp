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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        public void SetFlavor(string strFlavor)
        {
            lblFlavor.Text = strFlavor;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
