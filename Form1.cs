﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1030220045
{
    public partial class Form1 : Form
    {
        int angka1, angka2, hasil, hasil2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            hasil2 = hasil2 * 10 + 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            hasil2 = hasil2 * 10 + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            hasil2 = hasil2 * 10 + 7;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            hasil2 = hasil2 * 10 + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            hasil2 = hasil2 * 10 + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            hasil2 = hasil2 * 10 + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            hasil2 = hasil2 * 10 + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            hasil2 = hasil2 * 10 + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = hasil2  + hasil;
            textBox1.Text = hasil.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            hasil2 = hasil2 * 10 + 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            hasil2 = hasil2 * 10 + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hasil = hasil + hasil2;
            hasil2 = 0;
            textBox1.Text = "";
        }
    }
}
