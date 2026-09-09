using AntdUI;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace wiforproject.all
{
    public partial class BookAddandEdit : Form
    {
       
        private string _editBookId = null;
        public BookAddandEdit()
        {
            InitializeComponent();
        }
        public BookAddandEdit(string text)
        {
            InitializeComponent();
          
                label1.Text = "图书" + text;
                button1.Text = "新增";

            _editBookId = null;
            button1.Click += xinzengedit;
         


        }
        //点击编辑的话就走下面这个构造函数
        public BookAddandEdit(string text,string Id)
        {
            InitializeComponent();
            label1.Text = "图书" + text;
            button1.Text = "编辑";
            mysqlrebook( Id);
            _editBookId = Id;
            button1.Click += xinzengedit;
        
        }


        //编写一个逻辑:通过id 查询数据库里面的数据 数据回显
        private void mysqlrebook(string Id)
        {
            string ConnStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=root;charset=utf8";
            using (MySqlConnection mysqlconn = new MySqlConnection(ConnStr))
            {
                mysqlconn.Open();
               //string sql = "select * from book where id=Id";
                // 查询语句：按id查询一条记录，使用参数化查询
                string sql = "SELECT * FROM book WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlconn);
                cmd.Parameters.AddWithValue("@id", Id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) //读到这条图书数据
                {
                    // 把数据库读到的值赋值给页面上的TextBox
                    textBox1.Text = reader["name"].ToString();
                    textBox2.Text = reader["author"].ToString();
                    // inputNumber2.Value = reader["price"].ToString();
                    inputNumber2.Value = Convert.ToDecimal(reader["price"]);//上面一行报错了，这个是转数字的意思
                    textBox3.Text = reader["label"].ToString();
                    
                }
                reader.Close();
            }

        }

        //新增和编辑的逻辑都在这里
        private async void xinzengedit(object sender, EventArgs e)
        {
            Book book = new Book();
            book.name = textBox1.Text;
            book.author = textBox2.Text;
            book.price = inputNumber2.Value;
            book.label = textBox3.Text;
            book.is_borrow = "0";

            string ConnSer = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=root;charset=utf8";
            using (MySqlConnection Conn = new MySqlConnection(ConnSer))
            {
                Conn.Open();
                MySqlCommand cmd;
                if (_editBookId == null)
                {
                    // ==========新增模式 INSERT==========
                    string sql = @"INSERT INTO book(name, author, price, label, is_borrow)
                    VALUES(@name, @author, @price, @label, @is_borrow)";
                    cmd = new MySqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@name", book.name);
                    cmd.Parameters.AddWithValue("@author", book.author);
                    cmd.Parameters.AddWithValue("@price", book.price);
                    cmd.Parameters.AddWithValue("@label", book.label);
                    cmd.Parameters.AddWithValue("@is_borrow", book.is_borrow);
                }
                else
                {
                    // ==========编辑模式 UPDATE 更新旧数据==========
                    string sql = @"UPDATE book
                        SET name=@name,author=@author,price=@price,label=@label,is_borrow=@is_borrow
                        WHERE id=@id";
                    cmd = new MySqlCommand(sql, Conn);
                    cmd.Parameters.AddWithValue("@name", book.name);
                    cmd.Parameters.AddWithValue("@author", book.author);
                    cmd.Parameters.AddWithValue("@price", book.price);
                    cmd.Parameters.AddWithValue("@label", book.label);
                    cmd.Parameters.AddWithValue("@is_borrow", book.is_borrow);
                    cmd.Parameters.AddWithValue("@id", _editBookId); //关键：更新哪一条
                }

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "保存成功" : "保存失败");
                this.Close(); //保存完关闭编辑窗口，主窗体再刷新ShowData()


               ;
            }
        }

    }
}
