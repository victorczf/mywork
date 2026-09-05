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
            //跳转到 编辑 和新增的界面，至于编辑还是新增要看情况
            //
           Bookshow bookshow=  new Bookshow();
            bookshow.Show();
            this.Hide();
            bookshow.FormClosed += close;


        }
       private void close(object sender,EventArgs e) 
        {
            this.Show();
        }


    }
}
