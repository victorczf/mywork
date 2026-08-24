using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //json序列化  using System.Text.Json;(使用的库)
            //定义一个list的字典，里面放书本，，书本有书名，作者，编号，一共三本书
            //定义了之后，将着三本书序列化，序列化后放入一个文件，如然后再把他反序列化读取出来
            List<Dictionary<string, dynamic>> list = new()
            {
                new Dictionary<string, dynamic>{

                 ["name"]="西游记",
                 ["author"]="吴承恩",
                 ["num"]="1"
                },

                new Dictionary<string, dynamic>
                {

                 ["name"]="云边的小卖部",
                 ["author"]="陈三岁",
                 ["num"]="2"

                },
                new Dictionary<string, dynamic>
                {

                 ["name"]="红楼梦",
                 ["author"]="曹雪芹",
                 ["num"]="3"

                }


            };
            //序列化前配置序列化
            var opt = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping

            };

            //将这个list 字典序列化

            var json=JsonSerializer.Serialize(list, opt);//参数一，要序列化的内容：参数二：配置

            //定义文件的路径
            string path = "./.text";
            //文件写入 （如果没有就创建后写入）
            //File.AppendAllText(路径,内容);
            File.AppendAllText(path, json);
            //序列化形式读取文件
            Console.WriteLine(File.ReadAllText(path));

            //往list添加一本书:

            //先读取文件
            List<Dictionary<string, dynamic>> list1 = new();
             var jsonstr= File.ReadAllText(path);
            //将他反序列化

             //list1 = JsonSerializer.Deserialize(jsonstr, opt);
          
            //✅正确，告诉它反序列化出来是什么类型
            list1 = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonstr, opt);
            //再把他存到一个list里面，然后把新的书本添加进来
            //我直接新建一个字典就不传进来了
            //
            Dictionary<string, dynamic> list2 = new()
            {
                ["name"] = "云边的小卖部",
                ["author"] = "陈三岁",
                ["num"] = "4"

            };


            list1.Add(list2);

            foreach (var item in list1)
            {
                foreach (var item2 in list2)
                {
                    Console.WriteLine(" "+item2.Key+" "+item2.Value);
                }
            }




            /* string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，喝水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报";
             string salt = "7-16-30-38-49-52-63-70";
             string [ ] num = salt.Split("-");
             foreach (string i in num) 
             {
                 int net = int.Parse(i);
                 Console.Write(text[net]);
              };*/


            //通过情报内容获取下标
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";



        }
    }
}
