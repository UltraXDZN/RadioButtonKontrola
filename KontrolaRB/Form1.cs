﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolaRB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rjesenje = "";
            if (radioButtonAvion.Checked) rjesenje = radioButtonAvion.Text;
            else if (radioButtonAutobus.Checked) rjesenje = radioButtonAutobus.Text;
            else if (radioButtonVlastiti.Checked) rjesenje = radioButtonVlastiti.Text;

            textBox1.Text = $"Odabrali ste {rjesenje.ToLower()}.";
        }
    }
}
