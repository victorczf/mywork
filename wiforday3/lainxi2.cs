using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class lainxi2 : Form
    {
        //失去光标并且文本为空的时候 显示出来标签=>文本不能为空
        //当得到光标时，不能为空的提示标签是隐藏的
        //和老师不一样的地方是没有没有采用文本改变事件

        public lainxi2()
        {
            InitializeComponent();
            init();
        }
        private void init( ) 
        {
            textBox1.Leave += leave;
            textBox1.Enter += Enter;
            label1.Visible = false;
        }
        private void leave(object sender ,EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            { 
                label1.Visible = true;
            }
        
        }
        private void Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        

    }
}
