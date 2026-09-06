using AntdUI;
using System.Reflection.Emit;
using wiforproject.all;

namespace wiforproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "未登录")
            {
                login lg = new login();
                //模态弹出，代码在这里暂停，直到login窗口关闭
                lg.ShowDialog();

                //login关闭之后，读取login的属性，拿到登录结果
                if (lg.IsLoginSuccess)
                {
                    //登录成功，修改Form1自己的标签
                    label2.Text = "已登录";

                    //打开图书界面
                    Bookshow bookshow = new Bookshow();
                    bookshow.Show();
                    this.Hide();
                    bookshow.FormClosed += close;
                }
                else
                {
                    //登录失败，什么都不做，停留在Form1
                }
            }
            else
            {
                Bookshow bookshow = new Bookshow();
                bookshow.Show();
                this.Hide();
                bookshow.FormClosed += close;
            }
        }
        private void close(object sender,EventArgs e) 
        {
            this.Show();
        }


    }
}
