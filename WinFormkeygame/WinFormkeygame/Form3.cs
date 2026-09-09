using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Shown += GameInit;
        }
        private Random Rand = new();
        private System.Windows.Forms.Timer GolbalTimer = new();
        private List<LabelAndTimer> LabTimerList = new();
        private int score = 0;
        private void GameInit(object sender, EventArgs e)
        {
            GolbalTimer.Interval = 1000;
            GolbalTimer.Tick += (object sender, EventArgs e) => CreateLab();
            this.KeyPreview = true;
            this.ActiveControl = null;
            this.KeyUp += Form3_KeyUp;
        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            // e.KeyCode
            // 遍历List
            for (int i = 0; i < LabTimerList.Count; i++)
            {
                //LabTimerList[i].Lab.Text
                if (Enum.TryParse(LabTimerList[i].Lab.Text,true,out Keys k))
                {
                    if (k != e.KeyCode) continue;
                    // 删除对应的label和定时器关闭
                    panel1.Controls.Remove(LabTimerList[i].Lab);
                    LabTimerList[i].LabTimer.Stop();
                    LabTimerList.RemoveAt(i);
                    label2.Text = (++score).ToString();
                    return;
                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 游戏开始
            score = 0;
            label2.Text = "0";
            GolbalTimer.Start();
        }
        private void CreateLab()
        {
            Label lab = new Label();
            lab.Text = ((char)Rand.Next(65, 91)).ToString();
            lab.Size = new Size(30, 30);
            lab.Location = new Point(Rand.Next(panel1.Width - 30), 0);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point);
            // 添加到容器
            panel1.Controls.Add(lab);

            // 设置 这个lab对应的定时器
            System.Windows.Forms.Timer lt = new();
            lt.Interval = 10;
            lt.Tick += (object sender, EventArgs e) => LabeDown(lab);
            lt.Start();
            //记录存储存List中
            LabTimerList.Add(new LabelAndTimer(lab, lt));
            
        }

        private void LabeDown(Label labe)
        {
            labe.Top += 2;
            if (labe.Top >= panel1.Height - 30)
            {
                // 游戏结束
                //关闭所有定时器
                GolbalTimer.Stop();
                LabTimerList.ForEach(item => item.LabTimer.Stop());
                MessageBox.Show("Game Over!!!");
                panel1.Controls.Clear();
                LabTimerList.Clear();
            }
        }

    }


    public class LabelAndTimer
    {
        public Label Lab { get; set; }
        public System.Windows.Forms.Timer LabTimer { get; set; }
        public LabelAndTimer(Label la, System.Windows.Forms.Timer tm)
        {
            Lab = la;
            LabTimer = tm;
        }
    }
}
/*
 可以同时有多个label文字出现
    - 每个label都有自己的定时器
       + 将其存在 List中
 还需要全局定时器 用于控制label生成的
 
 键盘事件中 需要循环判断 按键和List中的Label内容是否一致
 
*/
