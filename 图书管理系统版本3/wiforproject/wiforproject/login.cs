using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace wiforproject
{

    public partial class login : Form
    {
        public bool IsLoginSuccess { get; set; } = false;
        public static string ConnStr = "server=127.0.0.1;port=3306;database=test;uid=root;pwd=root;charset=utf8";

        private string User { get; set; }
        private string Userpassword { get; set; }
        public login()
        {
            InitializeComponent();
            button1.Click += lgclick;
        }
        //获取输入框文本，校验输入的 数据 1
        private void lgclick(object sender, EventArgs e)
        {
            User = textBox1.Text;
            Userpassword = textBox2.Text;
            mysqlsele();

        }
        private void mysqlsele()
        {

            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                Conn.Open();
                string sql = "Select * from user where username=@User AND password=@Userpassword";
                MySqlCommand cmd = new MySqlCommand(sql, Conn);
                cmd.Parameters.AddWithValue("@User", User);
                cmd.Parameters.AddWithValue("@Userpassword", Userpassword);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //读到一行，账号密码匹配
                    MessageBox.Show("登录成功");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    //给label赋值为已登录
                    IsLoginSuccess = true;


                }
                else
                {
                    IsLoginSuccess = false;
                    MessageBox.Show("账号或者密码错误");
                }

            }



        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.ShowDialog();
            // reg.Show();


        }
    }
}
