using MySqlConnector;
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
            //

            string ConnStr = "server=127.0.0.1;port=3306;database=text;uid=root;pwd=root;charset=utf8";

            string sql = @"INSERT INTO book(name,author,price,label,is_borrow)
                   VALUES(@name,@author,@price,@label,@is_borrow)";

            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@name", book.Name);
                    cmd.Parameters.AddWithValue("@author", book.Author);
                    cmd.Parameters.AddWithValue("@price", book.Price);
                    cmd.Parameters.AddWithValue("@label", book.BookLabel);
                    cmd.Parameters.AddWithValue("@is_borrow", book.IsBorrow );

                    cmd.ExecuteNonQuery(); 
                }
            }

            MessageBox.Show("图书新增成功!!");
            this.Close();
        }
    }
}
