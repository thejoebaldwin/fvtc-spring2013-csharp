using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SearchReturns
{
    public partial class Form1 : Form
    {

        private string[] Students = {"John", "Stacy", "Tony", "Jeff", "Rick",
                                    "Tom", "Peter", "Tanya", "Betty", "Suzie",
                                     "Ronald", "Roxanne", "Keith", "Ken", "Liz",
                                     "James", "Pattty", "Paul", "Judd", "Ashley" };
        
        private int[] SavingsBalance = {0, 200, 10000, 12000, 7000,
                                        340, 56, 45, 56, 800, 
                                        9400, 800, 6400, 5600, 4800, 
                                        45, 560, 28 , 0, 20};

        public Form1()
        {
            InitializeComponent();
        }
    }
}
