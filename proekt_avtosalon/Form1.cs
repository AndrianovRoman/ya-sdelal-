using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_avtosalon
{
    public partial class Form1 : Form
    {
        Form9 frm9;
        Form8 frm8;
        Form7 frm7;
        Form6 frm6;
        Form5 frm5;
        Form4 frm4;
        Form3 frm3;
        Form2 frm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm4 = new Form4();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm5 = new Form5();
            frm5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm6 = new Form6();
            frm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm7 = new Form7();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm8 = new Form8();
            frm8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm9 = new Form9();
            frm9.Show();
        }
    }
}
