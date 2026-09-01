using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controls;

namespace WinFormsApp1.Book
{
    public partial class BookShow : Form
    {
        public BookShow()
        {
            InitializeComponent();
            showBook();
        }
        private void showBook()
        {
            string JsonStr = File.ReadAllText("./book.json");
            List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>index.ToString()

                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookLabel", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    // val 单元的值, cel: 行数据, index 行号
                    Render = (object val,object cel,int index) =>
                    {
                        return (bool)val?"已借阅":"书架中";
                    }
                },
            };

            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            // 绑定事件
            table1.CellClick += Table1_CellClick;

        }

        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            BookInfo book = (e.Record as BookInfo);            
            //MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex.ToString() == "6")
            {
                // 删除
                //  MessageBox.Show(book.Id);
                if (!File.Exists("./book.json"))
                {
                    MessageBox.Show("没有图书数据");
                    this.Close();
                    return;
                }
                string jsonStr = File.ReadAllText("./book.json");
                List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);
                BookInfo oldBook = books.Find(item => item.Id == book.Id);
                if (oldBook == null)
                {
                    MessageBox.Show("找不到该图书");
                    this.Close();
                    return;
                }
                books.Remove(oldBook);


                jsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText("./book.json", jsonStr);

                MessageBox.Show("删除成功");
                showBook();
                //  this.Close();

                //先得到这本书的id 
                return;
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                //  new BookEdit(book.Id).Show();
               new BookEdit(book.Id).ShowDialog();//让代码停着原地等待
               showBook();
               
                 /*
               1.执行ShowDialog() → 弹出编辑窗口，主窗体这一段代码暂停卡住，不再向下跑
               2.你在编辑窗口操作：修改内容 → 点保存 → 把新数据写入硬盘的 book.json 文件 → this.Close()关闭编辑窗口
               3. 编辑窗口关闭，ShowDialog()这一行才算执行完毕，代码解除阻塞，继续往下走
               4.才执行到 showBook();
               5. showBook()去读取硬盘上已经改好的最新 json 文件，重新给表格数据源赋值 → UI 表格刷新出修改后的数据
                 
                 
               1. 打开编辑窗口，代码不会停，直接立刻执行 showBook ()
               2.此时你还没点保存，json 还是旧内容
               3. showBook 读旧数据刷表格
               4. 之后你才在弹窗保存修改 json，但是showBook()早就跑完了，再也不会执行第二次，界面不会自己变。
                 */

            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            new BookEdit().Show();
        }
    }
}
