﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiselneSoustavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prevody prevody = new Prevody();
            MessageBox.Show("" + prevody.BinToDec(111100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prevody prevody1 = new Prevody();
            MessageBox.Show("" + prevody1.DecToBin(27));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prevody prevody2 = new Prevody();
            MessageBox.Show("" + prevody2.HexToDec("1A7F"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prevody prevody3 = new Prevody();
            MessageBox.Show("" + prevody3.DecToHex(6783));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prevody prevody4 = new Prevody();
            MessageBox.Show("" + prevody4.BinToHex("111100"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Prevody prevody5 = new Prevody();
            MessageBox.Show("" + prevody5.HexToBin("3C"));
        }
    }
}
