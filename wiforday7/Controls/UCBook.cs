using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Book;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1.Controls
{
    public partial class UCBook : UserControl
    {//在UCBook类里面加
      //  public Action? OnEditSave { get; set; }

        public UCBook()
        {
            InitializeComponent();
            button1.Text = "新增";
            label1.Text = "图书新增";

        }
        public UCBook(string text)
        {
            InitializeComponent();
            button1.Text = text;
            label1.Text = "图书" + text;
        }
     
        public void SetBookall(string val1, string val2, double val3, string val4)
        {
            nameInp.Text = val1;
            authorInp.Text = val2;
            priceInpNum.Text = val3.ToString();
            input3.Text = val4;
        }
        // 编辑回显


        //event 是自定义事件的意思
        //Action<BookInfo>：约定规则：触发这个事件的时候，必须往外传递 1 个 BookInfo 对象
        internal event Action<BookInfo> Senddata;

        //点击 编辑按钮 或者是 新增按钮
        private void button1_Click(object sender, EventArgs e)
        {

            Senddata.Invoke(new BookInfo()
            {
                Id = Guid.NewGuid().ToString(),
                Name = nameInp.Text,
                Author = authorInp.Text,
                Price = double.Parse(priceInpNum.Text),
                BookLabel = input3.Text,
                IsBorrow = false
            });

        }
        //读取界面，返回修改后的对象，**id由外部传入，UC不要自己生成Guid**

    }
}
