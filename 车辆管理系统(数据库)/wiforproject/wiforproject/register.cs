using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiforproject
{
    public partial class register : Form
    {
        Mysql mysql = new Mysql("test");
        public register()
        {
            InitializeComponent();
        }
        //点击注册
        private async void button1_Click(object sender, EventArgs e)
        {
            //把这个数据存入到数据库中
            //连接数据库吧，先定义一个连接字符串
            string sql = "SELECT COUNT(*) FROM user WHERE username = @username";
            await mysql.mysqlcaozuo(sql, cmdd =>
            {

                cmdd.Parameters.AddWithValue("@username", textBox1.Text);
                //ExecuteScalar拿查询出来的数量
                int count = Convert.ToInt32(cmdd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("该用户名已经被注册，请换一个！");
                    return false; //直接退出，不会执行下面插入
                }

                return true;
            }
             );
            sql = @"INSERT INTO user(username,password,age,gender,banji)
                         VALUES(@username,@password,@age,@gender,@banji)";
            await mysql.mysqlcaozuo(sql, cmdd =>
            {

                string gender = "";
                if (radioButton1.Checked)
                    gender = "男";
                else if (radioButton2.Checked)
                    gender = "女";

                cmdd.Parameters.AddWithValue("@username", textBox1.Text);
                cmdd.Parameters.AddWithValue("@password", textBox2.Text);
                cmdd.Parameters.AddWithValue("@age", inputNumber1.Value);
                cmdd.Parameters.AddWithValue("@gender", gender);
                cmdd.Parameters.AddWithValue("@banji", comboBox1.Text);

                int rows = cmdd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("注册成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
                return true;
            }
          );


        }

      
    }
}

