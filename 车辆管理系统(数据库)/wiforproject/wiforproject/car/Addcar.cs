using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiforproject.car
{
    public partial class Addcar : Form
    {
        public Addcar()
        {
            InitializeComponent();
            
            //绑定事件
            button1.Click += addAndeditbutton;
        }
        public Addcar(string text)
        {
            InitializeComponent();
            label1.Text = text;
            button1.Text = "保存"+text ;
        }

        private void addAndeditbutton(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();

        }
    }
}
