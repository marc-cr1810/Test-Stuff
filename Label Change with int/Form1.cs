﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Change_with_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
