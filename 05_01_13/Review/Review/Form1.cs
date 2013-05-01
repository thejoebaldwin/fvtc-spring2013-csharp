using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Review
{
    public partial class Form1 : Form
    {

        const double MOVIE_PRICE = 9.50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //a
            int i = 0;
            //b
            int dtotal = 0;
            //c
            do
            {
                //d
                dtotal = dtotal + Int32.Parse(lbxPrice.SelectedItem.ToString());
                //e
                i++;
            } while (i < lbxPrice.Items.Count);

            //a) 0
            //b) 1
            //c) 2
            //d) 3
            //e) 4
            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {


            int intQuantity = 0;
            Int32.TryParse(txtQuantity.Text, out intQuantity);
            int i = 0;
            while (i < intQuantity)
            {
                //multiply the price times the iteration (plus one)
                double dblTotal = (i + 1) * MOVIE_PRICE;
                lbxPrice.Items.Add(dblTotal.ToString("c"));
                i++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intQuantity = 0;
            Int32.TryParse(txtQuantity.Text, out intQuantity);
            double dblTotal = 0;
            for (int i = 0; i < intQuantity; i++)
            {
                //accumulate the price each iteration
                dblTotal += MOVIE_PRICE;
                lbxPrice.Items.Add(dblTotal.ToString("c"));
            }
        }
    }
}
