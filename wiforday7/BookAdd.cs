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

namespace WinFormsApp1.Book
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
            // 绑定接收数据方法
            ucBook1.Senddata += AddBook;
        }
        private void AddBook(BookInfo book)
        {
           // List<Dictionary<dynamic ,string>>
            //定义一个变量book
            List<BookInfo> books = new List<BookInfo>();
            string JsonStr = "";
            //判断文件是否存在
            if (File.Exists("./book.json"))
            {   //读取文件，反序列化给books
                JsonStr = File.ReadAllText("./book.json");
                books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);
            }
            books.Add(book);

            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText("./book.json", JsonStr);

            MessageBox.Show("图书新增成功!!");
            this.Close();
        }
    }
}
