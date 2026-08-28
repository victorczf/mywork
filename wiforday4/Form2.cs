using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace day04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initsj();
        }

        private void initsj() {

            textBox1.TextChanged += textBox1_TextChanged;
        }
        int num;
        private void textBox1_TextChanged(object sender ,EventArgs e) 
        {

            num = 0;
            if (Regex.IsMatch(textBox1.Text, @"\d"))
            {
                num++;
            }
            if (Regex.IsMatch(textBox1.Text, @"[a-z]"))
            {
                num++;
            }
            if (Regex.IsMatch(textBox1.Text, @"[A-Z]"))
            {
                num++;
            }


            if (num == 1)
            {
                label1.Text = "弱";
            
            }
            if (num == 2)
            {
                label1.Text = "中";
               
            }
            if (num == 3)
            {
                label1.Text = "强";
              
            }
        }
    }
}
