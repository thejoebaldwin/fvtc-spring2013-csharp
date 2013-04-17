using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int intNice = 1;
            int intIterations = 10;
            //get user input!
            Int32.TryParse(txtIterations.Text, out intIterations);

            listBox1.Items.Clear();


            while (i < intIterations)
            {
                
                listBox1.Items.Add("Item #" + intNice.ToString());

                i++;
                intNice++;
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            MessageBox.Show("You selected Item #" + index.ToString());
        }
    }
}
