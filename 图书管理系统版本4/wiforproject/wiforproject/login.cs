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
        Mysql mysql = new Mysql("test");
        public bool IsLoginSuccess { get; set; } = false;

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
        private async void mysqlsele()
        {
            string sql = "Select * from user where username=@User AND password=@Userpassword";
           await  mysql.mysqlcaozuo(sql , cmdd =>
            {
                cmdd.Parameters.AddWithValue("@User", User);
                cmdd.Parameters.AddWithValue("@Userpassword", Userpassword);

                MySqlDataReader reader = cmdd.ExecuteReader();
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
                    return false;
                }
                return  true;

            } );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.ShowDialog();

        }
    }
}
