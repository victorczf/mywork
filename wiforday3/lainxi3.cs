using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class lainxi3 : Form
    {
        //在类里面声明变量
        string[] parr = [@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg",];
        int index ;

        List<Button> listbt = new List<Button>() ;
        Label[] lbarr ;


        public lainxi3()
        {
            InitializeComponent();
            init();
            lunbo();
        }

        private void init()
        {
            parr=[@"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg",];
             index = 0;

            listbt = new List<Button>() { button1, button2, button3 };
            lbarr = new Label[] { label1, label2 };


            foreach (Label label in lbarr) {
                label.Click += lbclick;
            }
            foreach (Button button in listbt) {
                button.Click += btclick;
            }

        }
        private void btclick(object sender ,EventArgs e) 
        {
            //获取这个按下的这个按钮的下标，因为按钮的下标和图片的下标是一致的
            index = listbt.IndexOf((sender as Button));
            
            lunbo();
        }
        private void lbclick(object sender ,EventArgs e) 
        {
            if ("label1" == (sender as Label).Text.ToString())
            {
                if (index == 0) { 
                    index = parr.Length-1;
                //MessageBox.Show(index.ToString());
                }
                else
                    index--;
            
            }
            if ("label2" == (sender as Label).Text.ToString())
            {
                if (index == parr.Length-1)
                    index = 0;
                else
                    index++;

            }


            lunbo();

        }

        private void lunbo() 
        {

            //把所有按钮的高亮状态恢复成默认状态，因为不知道上一个按钮是什么状态
            foreach (Button button in listbt)
            {
                button.BackColor = SystemColors.Control;

            }

            //把现在这个下标的按钮变成高亮的颜色
            listbt[index].BackColor = Color.Red;
            //把这个图片放上来显示
            pictureBox1.Image = Image.FromFile(parr[index]);

        }

    }
}
