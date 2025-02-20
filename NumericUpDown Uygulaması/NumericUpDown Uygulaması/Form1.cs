﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;
            numericUpDown2.Increment = 5;
            numericUpDown2.ReadOnly = true;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;
            numericUpDown3.Increment = 5;
            numericUpDown3.ReadOnly = true;

            textBox1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numericUpDown1.Value);
            int value2 = Convert.ToInt32(numericUpDown2.Value);
            int value3 = Convert.ToInt32(numericUpDown3.Value);

            textBox1.BackColor = Color.FromArgb(value, value2, value3);
        }
    }
}
