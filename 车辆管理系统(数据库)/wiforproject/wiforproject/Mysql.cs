using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace wiforproject
{
    internal class Mysql
    {
        // 连接数据 属性
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";
        // 连接数据库字符串
        private string ConnStr { get; set; }

        public Mysql(string database)
        {
            this.Database = database;
        }   

        //创建数据库操作函数
        public async Task<bool> mysqlcaozuo(string sql,Func< MySqlCommand,bool> hanshu)
        {
            ConnStr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            using (MySqlConnection conn = new(ConnStr))
            {
               await conn.OpenAsync();
                MySqlCommand Cmd = new MySqlCommand(sql, conn);
               return hanshu(Cmd);

            }
            
        }



    }
}
