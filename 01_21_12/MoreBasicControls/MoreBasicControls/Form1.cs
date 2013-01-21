using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoreBasicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set label to say "This text is set on startup"
            lblLoadMessage.Text = "This text is set on startup";
            //clear out the click label so it isn't visible
            lblClickMessage.Text = string.Empty;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //Set the label to say "This text is set on button click"
            lblClickMessage.Text = "This text is set on button click";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear out both labels!
            lblClickMessage.Text = "";
            lblLoadMessage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
