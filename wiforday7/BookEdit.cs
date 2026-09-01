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
    public partial class    BookEdit : Form
    {

        private string editId;
        public BookEdit()
        {
            InitializeComponent();
        }

        public BookEdit(string id)
        {
            InitializeComponent();
            // 根据id查找数据
            //MessageBox.Show(id); 
            // 回显  ====> 根据id 查找到 对应的书籍数据 ==> 显示在界面中(界面使用UCBook)
            //  编辑按钮, 修改
            editId = id;
            ucBook1.Senddata += OnUCBookSave;
            this.Load += BookEdit_Load;//当加载窗体的时候发生，把数据回显上去
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("没有图书数据");
                this.Close();
                return;
            }
            string jsonStr = File.ReadAllText("./book.json");
            List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);
            BookInfo oldBook = books.Find(item => item.Id == editId);
            if (oldBook == null)
            {
                MessageBox.Show("找不到该图书");
                this.Close();
                return;
            }
            ucBook1.SetBookall(oldBook.Name, oldBook.Author, oldBook.Price, oldBook.BookLabel);
        }

        private void OnUCBookSave(BookInfo newBook)
        {
            //
            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("没有图书数据");
                this.Close();
                return;
            }
            string jsonStr = File.ReadAllText("./book.json");
            List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(jsonStr);

            int index = books.FindIndex(item => item.Id == editId);
            if (index == -1)
            {
                MessageBox.Show("找不到要修改的图书");
                return;
            }
            newBook.Id = editId;// 在事件那边生成了一个随机id，要把原来的id赋值回去
            books[index] = newBook;//把这本新书放回这个字典里

            jsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", jsonStr);

            MessageBox.Show("编辑保存成功");


            this.Close();

        }



    }
}
