using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class lainxi1 : Form
    {
        public lainxi1()
        {
            InitializeComponent();
            //给这个窗体绑定鼠标移动
            this.MouseMove += locktion;
        }
        //鼠标坐标
        private void  locktion( object sender,MouseEventArgs e) 
        { 
            label3.Text=e.Location.X.ToString();
            label4.Text=e.Location.Y.ToString();
        
        }



    }
}
