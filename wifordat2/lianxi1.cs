using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class lianxi1 : Form
    {
        string[] parr = ["off.png", "on.png"];
        public lianxi1()
        {
            InitializeComponent();
            init();
        }
        private void init() 
        {
            button1.Click += click;
            button1.Text = "打开";
        }

        private void click(object sender ,EventArgs e) 
        {
            if (button1.Text == "打开")
            { 
                pictureBox1.Image=Image.FromFile(parr[0]);
                button1.Text = "关闭";
            }
            else if(button1.Text == "关闭")
            {
                pictureBox1.Image = Image.FromFile(parr[1]);
                button1.Text = "打开";
            }


        }
    }
}
