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
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把这个数据存入到数据库中
            //连接数据库吧，先定义一个连接字符串
            string Constr= "server=127.0.0.1;port=3306;database=test;uid=root;pwd=root;charset=utf8";
            using (MySqlConnection conn = new MySqlConnection(Constr))
            {
                conn.Open();
                string checkSql = "SELECT COUNT(*) FROM user WHERE username = @username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", textBox1.Text);
                    //ExecuteScalar拿查询出来的数量
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("该用户名已经被注册，请换一个！");
                        return; //直接退出，不会执行下面插入
                    }
                }

                string sql = @"INSERT INTO user(username,password,age,gender,banji)
               VALUES(@username,@password,@age,@gender,@banji)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    string gender = "";
                    if (radioButton1.Checked)
                        gender = "男";
                    else if (radioButton2.Checked)
                        gender = "女";

                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    cmd.Parameters.AddWithValue("@age", inputNumber1.Value);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@banji", comboBox1.Text);

                    int rows = cmd.ExecuteNonQuery();

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

                }

            }

        }
    }
}
