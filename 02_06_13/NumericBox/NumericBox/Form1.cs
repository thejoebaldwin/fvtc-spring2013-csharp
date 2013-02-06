using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumericBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string oldValue = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string newValue = textBox1.Text;
            bool isOK = true;
            for (int i = 0; i < newValue.Length; i++)
            {
                switch (newValue[i])
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '0':
                        break;
                    default:
                        isOK = false;
                        break;
                }
            }

            if (isOK)
            {
                oldValue = newValue;
            }
            else
            {
                textBox1.Text = oldValue;
                textBox1.Select(oldValue.Length, 0);
            }


        }
    }
}
