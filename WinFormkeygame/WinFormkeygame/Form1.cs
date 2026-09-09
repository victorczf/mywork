namespace WinFormkeygame
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer=new();
        //新建一个label
        Label lb=new ();
        //实例化random类
        Random random = new ();
        //定义一个字符串
        string lbstr = "QWERTPOIUYASDFGLKJHZMNXBCV";

        //定义文本离容器上方的高度
        int lbhige;
        public Form1()
        {
            InitializeComponent();
        }
        //点击开始游戏
        private void button1_Click(object sender, EventArgs e)
        {
            label();
            //创建定时器
            timer.Interval = 300;
            timer.Tick -= Timer_Tick;
            timer.Tick += Timer_Tick;
            timer.Start();
            //创建一个键盘事件

            this.KeyUp -= Form1_KeyUp;
            this.KeyUp += Form1_KeyUp;

            this.KeyPreview = true; // 让窗体得到光标
            this.ActiveControl = null;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Enum.TryParse(lb.Text ,true,out Keys k)) return;
            if (e.KeyCode == k)
            {
                panel1.Controls.Remove(lb);
                label();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //文本开始往下
            lbhige += 50;
            lb.Top = lbhige;
            if (lb.Top >= panel1.Height - 30)
            {
                timer.Stop();
                MessageBox.Show("游戏结束 ，你输了");
            }

        }
        //这个函数用来初始化label
        private void label()
        {
            lb.Text = lbstr[random.Next(lbstr.Length)].ToString();
            lb.Size = new Size(30, 30);
            //定义这个文本的初始坐标
            lb.Location = new Point(random.Next(panel1.Width-30) ,0 );
            //设置这个文本的字体
            lb.Font = new Font("微软雅黑",14F,FontStyle.Bold,GraphicsUnit.Point);
            panel1.Controls.Add(lb);
            lbhige = 0;

        }

    }
}
