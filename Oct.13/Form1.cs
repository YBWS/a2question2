﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oct._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**

 *

 * Name: Bowen

 * Teacher: Mr.Hardman

 * Assignment #2, Program #2

 * Date Last Modified: Oct.14

 *

 */
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double item1 = Convert.ToDouble(txtoutput1.Text);
            double item2 = Convert.ToDouble(txtoutput2.Text);
            double item3 = Convert.ToDouble(txt3.Text);
            double item4 = Convert.ToDouble(txt4.Text);
            double item5 = Convert.ToDouble(txt5.Text);

            double average = (item1 + item2 + item3 + item4 + item5) / 5.0;
            lblDisplay.Text = "Average"+ average;

            //computer display
            lblDisplay.Text = string.Format("{0,10}{1,15:C2}\n{2,10}{3,15:C2}\n{4,10}{5,15:C2}",
                 "item1", input1, "item2", input2);







        }
    }
}
