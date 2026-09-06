using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer CountDownTimer { get; set; }

        public Form4()
        {
            InitializeComponent();
            daoji();
            timer();
        }

        private void timer()
        {
            CountDownTimer = new System.Windows.Forms.Timer();
            CountDownTimer.Interval = 1000;
            CountDownTimer.Tick += (s, e) => daoji();
            CountDownTimer.Start();
        }

        private void daoji()
        {

            DateTime nationalDay = DateTime.Parse("2026-10-1 00:00:00");
            DateTime now = DateTime.Now;

            TimeSpan ts = nationalDay - now;

            string dayStr = ts.Days.ToString().PadLeft(2, '0');
            string hourStr = ts.Hours.ToString().PadLeft(2, '0');
            string minStr = ts.Minutes.ToString().PadLeft(2, '0');
            string secStr = ts.Seconds.ToString().PadLeft(2, '0');

            string countStr = dayStr + hourStr + minStr + secStr;

            // 三个冒号图片：pictureBox3、pictureBox6、pictureBox9
            pictureBox3.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox6.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox9.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        
            PictureBox[] picArr = new PictureBox[]
            {
                pictureBox1, pictureBox2,
                pictureBox4, pictureBox5,
                pictureBox7, pictureBox8,
                pictureBox10, pictureBox11
            };

            for (int i = 0; i < picArr.Length; i++)
            {
                picArr[i].SizeMode = PictureBoxSizeMode.Zoom;
                picArr[i].Image = Image.FromFile(@"./images/" + countStr[i] + ".png");
            }
        }
    }
}