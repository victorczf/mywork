using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wiforproject.car;

namespace wiforproject
{
    public partial class carForm : Form
    {
        public carForm()
        {
            InitializeComponent();
        }


        //点击新增车辆按钮
        private void button1_Click(object sender, EventArgs e)
        {
            Addcar addcarAndedit = new Addcar((sender as Button).Text);
            addcarAndedit.Show();
            this.Hide();
            addcarAndedit.FormClosed += addAndeditclose;

        }

        private void addAndeditclose(object? sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Show();

        }
    }
}
