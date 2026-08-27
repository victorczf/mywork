using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitTotal();
        }
        private List<Dictionary<string, Control>> ConList = [];
        private void InitTotal()
        {
            /* 功能: 
                 每个输入框 数量变化则 总计统计结果 变化
                    - 输入框的数量 * 单价 得到这一行的 小计
                    - 因为有多行,每一个的数量和单价 需要一一对应起来
                        + 将单价的控件和数量的控件 一起组合 成一个字典(对象)
                        + 多个行的组合字典  放到list中
             */
            // 初始化 将 单价控件和数量控件 组合的字典 添加到 ConList 
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"]=label6,
                ["count"]=textBox1
            });
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"] = label8,
                ["count"] = textBox2
            });
            // 初始化 的 进行统计
            GetTotal();
            // 给数量输入框控件 添加 内容改变事件
            //textBox1.TextChanged += TextBox1_TextChanged;
            //textBox2.TextChanged += TextBox1_TextChanged;

            //遍历给输入框绑定事件
            ConList.ForEach(tb => tb["count"].TextChanged += TextChanged);

            //老师布置的作业 day 04
            //绑定按钮事件
            button2.Click+= button2_Click;
            button1.Click += button1_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberjs(textBox2, -1);
        }
        private void button4_Click(object sender, EventArgs e) 
        {
            numberjs(textBox2, 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            numberjs(textBox1, -1);
        }
        private void button2_Click(object sender, EventArgs e)  
        {
            numberjs(textBox1, 1);
        }
        //这个是优化后的框架，是按钮的逻辑运算调用函数
        private void numberjs(TextBox tb, int step)
        {
            string tbs2 = tb.Text;
            int restbsl = int.Parse(tbs2);
            restbsl += step;
            tb.Text = restbsl.ToString();
        }


        private void TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        // 统计总价方法
        private void GetTotal()
        {
            // 遍历ConList 直接计算总价
            int sum = 0;

            ConList.ForEach(item =>
            {
                // item是每一个字典 { ["price"]=单价控件,["count"] = 数量控件}
                if (!Regex.IsMatch(item["count"].Text, @"^[1-9]\d*$"))
                {
                    item["count"].Text = "1";
                    (item["count"] as TextBox).SelectionStart = 1;
                }
                int price = int.Parse(item["price"].Text);
                int count = int.Parse(item["count"].Text);
                sum += price * count; // 累加当前这一行的 小计结果 
            });

            // 将统计结果给totalLab 展示
            totalLab.Text = sum.ToString();
        }






    }
}
