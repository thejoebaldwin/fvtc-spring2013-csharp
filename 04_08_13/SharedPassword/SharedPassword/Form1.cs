﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharedPassword
{
    public partial class Form1 : Form
    {
        const string PASSWORD_ONE = "secret";
        const string PASSWORD_TWO = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare variables & get input
            string strPassword1 = txtPassword1.Text;
            string strPassword2 = txtPassword2.Text;
            string strMessage = string.Empty;    
            //logic
            //if (strPassword1 == PASSWORD_ONE && strPassword2 == PASSWORD_TWO)
            if (strPassword1 == PASSWORD_ONE || strPassword2 == PASSWORD_TWO)
            {
                strMessage = "This is the super secret";
            }
            else
            {
                strMessage = "Neither of the passwords were correct";
            }
            //output to user
            lblMessage.Text = strMessage;






        }
    }
}
