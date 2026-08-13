using System.Collections.Generic;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            /*    List<Dictionary<string, dynamic>> list = new() {
        new Dictionary<string, dynamic>(){
            ["name"] = "zs",
            ["age"] = 29,
            ["isMan"] = true,
            ["isSingle"] = true,
            ["salary"] = 4200
        },
        new Dictionary<string, dynamic>(){
            ["name"] = "ls",
            ["age"] = 20,
            ["isMan"] = false,
            ["isSingle"] = true,
            ["salary"] = 3400
        },
        new Dictionary<string, dynamic>(){
            ["name"] = "ww",
            ["age"] = 19,
            ["isMan"] = true,
            ["isSingle"] = false,
            ["salary"] = 6000
        },
        new Dictionary<string, dynamic>(){
            ["name"] = "zl",
            ["age"] = 14,
            ["isMan"] = false,
            ["isSingle"] = true,
            ["salary"] = 2000
        },
        new Dictionary<string, dynamic>(){
            ["name"] = "sq",
            ["age"] = 35,
            ["isMan"] = true,
            ["isSingle"] = false,
            ["salary"] = 7000
        },
        new Dictionary<string, dynamic>(){
            ["name"] = "zb",
            ["age"] = 27,
            ["isMan"] = false,
            ["isSingle"] = true,
            ["salary"] = 2900
        },
    };*/


            /*var res=list.Find(item =>
              {
                  //Console.WriteLine("find");
                  //return 条件;
                  //return item == 200;
                  //return item > 200;
                  return item["age"] <20;
              });
              Console.WriteLine(res["age"]);
              */

            // 2.
            //    var res = list.FindLast(item =>
            //    {
            //        //Console.WriteLine("find");
            //        //return 条件;
            //        //return item == 200;
            //        //return item > 200;
            //        return item["age"] >25
            //        ;
            //    });
            //Console.WriteLine(res["age"]);

            //  3.FindIndex(第一个满足此条件的下标): 找出薪水大于5000
            //var res = list.FindIndex(item =>
            //    {
            //        //Console.WriteLine("find");
            //        //return 条件;
            //        //return item == 200;
            //        //return item > 200;
            //        return item["salary"] > 5000
            //        ;
            //    });
            //Console.WriteLine(res);

            //4.Exists: 判断是否有薪水大于5000

            //var res = list.Exists(item =>
            //{
            //    return item["salary"] > 5000;

            //});
            //Console.WriteLine(res);

            // ForEach: 输出每个的 名字-年龄-薪水

            //  list.ForEach(item =>
            //{
            //    //Console.WriteLine(item["name"+"age"]);不能这样，会拼接成一个新的字符串

            //    Console.WriteLine($"{item["name"]}-{item["age"]}-{item["salary"]}");
            //});



            //输出了薪水的一半
            //List<int> newList = list.ConvertAll(item =>
            //{
            //    //Console.WriteLine(item);
            //    return (int)item["salary"] / 2;
            //});
            //Console.WriteLine(string.Join(",", newList));



            /*Dictionary<string, string> hansu (string s) 
            {

                foreach (var item in s)
                {
                    return 
                }


                return 0;
            };


            hansu ("dfsdfdsga");*/

            //键是字符char转string，值是出现次数int
           /* Dictionary<string, int> hanshu(string s)
            {
                //1.创建空字典
                Dictionary<string, int> dic = new Dictionary<string, int>();

                //2.遍历字符串每一个字符
                foreach (char c in s)
                {
                    string key = c.ToString();
                    //3.判断字典里是否已有该字符
                    if (dic.ContainsKey(key))
                    {
                        //存在，次数+1
                        dic[key]++;
                    }
                    else
                    {
                        //不存在，新增，次数初始1
                        dic[key] = 1;
                    }
                }
                //4.全部遍历完成，返回完整字典
                return dic;
            }


            Dictionary<string, int> zidian = hanshu("dfagabfadss");

            foreach (var item in zidian)
            {
                // item.Key → 字符
                // item.Value → 出现次数
                Console.WriteLine($"字符：{item.Key}，次数：{item.Value}");
            }
            */


        }
    }
}
