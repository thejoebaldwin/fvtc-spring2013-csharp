using System;
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
        const string SECRET_MESSAGE = "this is the secret!";

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
            
            string strMessage = string.Empty;

            switch (strPassword1)
            {
                case "secret":
                    strMessage = SECRET_MESSAGE;
                    break;
                case "1234":
                    strMessage = SECRET_MESSAGE;
                    break;
                case "password1":
                    strMessage = SECRET_MESSAGE;
                    break;
                default:
                    strMessage = "Incorrect Password";
                    break;
            }


            //logic
            //if (strPassword1 == PASSWORD_ONE && strPassword2 == PASSWORD_TWO)
            /*
            if (strPassword1 == PASSWORD_ONE || strPassword1 == PASSWORD_TWO)
            {
                strMessage = "This is the super secret";
            }
            else
            {
                strMessage = "Neither of the passwords were correct";
            }
             */
            //output to user
            lblMessage.Text = strMessage;
        }
    }
}
