﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThu1.Text);
            int b = int.Parse(txtSoThu2.Text);
            Calculation c = new Calculation(a,b);
            txtKQ.Text = c.Execute("+").ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n;
            double x, KetQua;
            n = int.Parse(txtSoThu2.Text); 
            x = double.Parse(txtSoThu1.Text);
            KetQua = Calculation.Power(x, n);
            txtKQ.Text=KetQua.ToString();
        }
    }
}
