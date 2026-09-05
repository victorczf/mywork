using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace wiforproject.all
{
    public partial class Bookshow : Form
    {
        string ConnStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=root;charset=utf8";
        public Bookshow()
        {
            InitializeComponent();

            mysqlff();
            SetColumn();
            table1_click();
        }

        //读取数据库内容显示在table上
        private void mysqlff()
        {
            
            //先定义字符串嘛
            using (MySqlConnection MysqlConn = new MySqlConnection(ConnStr))
            {

                MysqlConn.Open();
                string sql = "select * from book";

                using (MySqlCommand cmd = new MySqlCommand(sql, MysqlConn))
                {

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);//适配器，执行查询📌适配器拿上cmd（SQL+连接）

                    //1.先建内存中的DataTable
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);  //把查询出来全部数据填充进dt
                                       //3.再把内存dt赋值给界面控件table1的DataSource
                    table1.DataSource = dt;

                }//定义命令行对象
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //在这里先拿到这个控件的文本，看看是编辑还是新增
            AntdUI.Button bt = sender as AntdUI.Button;  
            string text = bt.Text;
            this.Hide();
            BookAddandEdit add = new BookAddandEdit(text);//由于编辑和新增的页面是一样的，我的想法是，从这里传入个参数给BookAddandEdit的这个类的构造函数初始化，这个参数可以控制页面显示新增还是编辑
            add.Show();

            add.FormClosed += close;

        }
        private void close(object sender,  EventArgs e)
        {
                this.Show();
        }


        /// <summary>
        /// 设置表格表头列定义
        /// </summary>
        public void SetColumn()
        {
            // 清空旧列，防止重复添加列，多次调用此方法不会生成重复表头
            table1.Columns.Clear();

            table1.Bordered = true;      // 开启表格边框
            table1.Radius = 4;           // 设置表格圆角大小，单位像素

            // 基础数据列集合
            table1.Columns = new AntdUI.ColumnCollection()
    {
        // Column(绑定的数据源字段名, 界面显示的表头文字)
        new AntdUI.Column("id", "编号")
        {
            /*
             Render：单元格自定义渲染委托
             val：当前单元格原始值
             cel：单元格对象
             rowIndex：当前行下标，从0开始
             */
            Render = (object val, object cel, int rowIndex) => rowIndex + 1
        },
        new AntdUI.Column("name", "书名"),        // 直接绑定数据源name字段，原样展示
        new AntdUI.Column("author", "作者"),      // 直接绑定数据源author字段
        new AntdUI.Column("price", "价格"),       // 直接绑定数据源price字段
        new AntdUI.Column("label", "标签"),       // 直接绑定数据源label字段

        new AntdUI.Column("is_borrow", "借阅状态")
        {
            Render = (object val, object cel, int index) =>
            {
                // val?.ToString()：val不为null才转字符串，防止空报错
                // 三目运算符：等于"1"输出已借阅，其他全部输出在书架
                return val?.ToString() == "1" ? "已借阅" : "在书架";
            }
        }
    };

            // ---------------------- 操作列：编辑、删除按钮（UI虚拟列，数据库不需要这个字段） ----------------------
            // Column第一个参数operate：虚拟列标识名字，数据库不用存在该字段，仅组件内部识别
            var colOperate = new AntdUI.Column("operate", "操作");
            colOperate.SetAlign(); // 设置单元格内容居中对齐
            colOperate.Render = (object val, object cel, int index) =>
            {
                /*
                 返回CellButton按钮数组，一个单元格放多个按钮
                 CellButton(按钮key标识,按钮显示文字,按钮样式)
                 key：点击事件的时候用来区分点了哪个按钮，自己定义字符串
                 */
                return new AntdUI.CellLink[]
                {
            new AntdUI.CellButton("edit", "编辑", AntdUI.TTypeMini.Default),
            new AntdUI.CellButton("delete", "删除", AntdUI.TTypeMini.Default)
                };
            };
            table1.Columns.Add(colOperate); // 将这一列追加到表格末尾


            // ---------------------- 借还书列：借书、还书按钮（UI虚拟列，数据库不需要） ----------------------
            var colBorrow = new AntdUI.Column("borrowOpt", "借还书");
            colBorrow.SetAlign(); // 单元格内容居中
            colBorrow.Render = (object val, object cel, int index) =>
            {
                return new AntdUI.CellLink[]
                {
            new AntdUI.CellButton("borrow", "借书", AntdUI.TTypeMini.Default),
            new AntdUI.CellButton("return", "还书", AntdUI.TTypeMini.Default)
                };
            };
            table1.Columns.Add(colBorrow); // 追加到表格最后
        }


       /* =======*/

        //tabl 里面的点击事件
        private void table1_click() 
        {
           //专门给CellButton按钮用的点击事件！！！
            table1.CellButtonClick += (sender, e) =>
            {
                /*//
                e.Btn.Text      ：按钮上面显示的文字 编辑/删除/借书/还书
                e.Record        ：这一行的数据源对象(DataRow)
                e.RowIndex      ：行下标，从0开始
                */
                // 和老师一样，强转为DataRow，适配DataTable数据源
                System.Data.DataRow Book = e.Record as System.Data.DataRow;
                if (Book == null)
                {
                    return;
                }

                if (e.Btn.Text == "编辑")
                {
                    MessageBox.Show($"准备编辑图书，ID：{Book["id"]}");
                    BookAddandEdit add = new BookAddandEdit(e.Btn.Text, Book["id"].ToString());//由于编辑和新增的页面是一样的，我的想法是，从这里传入个参数给BookAddandEdit的这个类的构造函数初始化，这个参数可以控制页面显示新增还是编辑
                    add.ShowDialog();
                    mysqlff();
                    SetColumn();

                }
                else if (e.Btn.Text == "删除")
                {
                    MessageBox.Show($"准备删除图书，ID：{Book["id"]}");

                    //直接在这写一个根据id删除的逻辑，当练习加深印象了，后续要优化整个代码
                    using (MySqlConnection Conn = new MySqlConnection(ConnStr))
                    { 
                        Conn.Open();
                        string sql= "DELETE FROM book WHERE id=@id";
                        using (MySqlCommand Cmd = new MySqlCommand(sql, Conn))
                        {
                            Cmd.Parameters.AddWithValue("@id", Book["id"]);
                            int rows = Cmd.ExecuteNonQuery();//多少行被影响
                            MessageBox.Show(rows > 0 ? "删除成功" : "删除失败");

                        }
                        mysqlff();
                        SetColumn();
                    }

                }
                else if (e.Btn.Text == "借书")
                {

                    MessageBox.Show($"执行借书，图书ID：{Book["id"]}");
                }
                else if (e.Btn.Text == "还书")
                {

                    MessageBox.Show($"执行还书，图书ID：{Book["id"]}");
                }
            };



        }





    }
}
