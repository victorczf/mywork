using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Carsystem
{
    internal class Usergl
    {
        //客户管理类
        //管理客户消息


        private string path { get; } ="user.text";
        //抛出疑问：下面这个序列化是不是不定义也行，因为其他车辆类已经有了
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        public string adduser(string userName, string userCardId, string gender, string telNum, string motto)
        {
            //如果不存在 ==》先添加用户信息

            //创建一个空集合list，拿来存放读取文件后的信息。
            List<User> list = new();

            // 
            if (File.Exists(this.path))
          { 

                string jsonstr = File.ReadAllText(this.path);
            //把反序列化数据给予这个空集合list
            list = JsonSerializer.Deserialize<List<User>>(jsonstr, JsonOpt);
        }
            else { 
                int id = list.Count == 0 ? 1 : list[list.Count - 1].Id + 1;
            string regTime = DateTime.Now.ToString();
            User user = new User(id, userName, userCardId, regTime, gender, telNum, motto);
            list.Add(user);
            //序列化
            string resStr = JsonSerializer.Serialize(list, this.JsonOpt);
            File.WriteAllText(this.path, resStr);

            }
            return "ok";      
            
        }



    }
}
