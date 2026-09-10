using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookManager
{
    internal class BookManager
    {
        // 属性：
        // 数据文件路径
        public string path { get; }
        // JSON序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        // 新增数据：强制要求 ==> 将list写入文件中
        public string AddBook(Dictionary<string, dynamic> bookDic)
        {
            //把传进来的字典用booList来接收
            List<Dictionary<string, dynamic>> bookList = new();
            //判断文件是否存在
            if (File.Exists(path)) {
                //读取文件，（这里出现bug，如果文件存在但是里面没有数据则会报错）
                //更改逻辑： 如果文件存在了后判断文件是否为空 ==> 如果是空就不需要再反序列化，直接将字典存进去
                //如果不是空，先反序列化拉出来，再添加
                
                var json = File.ReadAllText(path);
                // 反序列化
                if(!string.IsNullOrWhiteSpace(json))
                { 

                bookList =  JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);

                

                bookDic.TryGetValue("name", out dynamic newbookName);
                    //通过foreach遍历原本存在的书
                    foreach (var item in bookList)
                    {
                        item.TryGetValue("name", out dynamic oldbookName);
                        if (oldbookName.ToString() == newbookName)
                        {
                            return "书名已存在";
                        }
                    }

                }

            }

            bookList.Add(bookDic);
            //序列化
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            // 写入文件
            File.WriteAllText(path, jsonStr);

            return "新增数据成功!!!";
        }
        // 编辑数据
        public string EditBook(string bookDic)
        {
            //接收到要修改的书名
            //先判断文件是否存在，如果不存在则返回不存在书本
            //如果文件存在==> 判断文件是否为空==> 如果文件不为空  反序列化 ==>遍历图库里面看看是否有该书名
            //如果书名存在 ==>则要求用户输入作者姓名标签价格，输入之后 ，将新的值复制给该字典
            // 编辑的逻辑处理
            //item.TryGetValue("name", out dynamic inbookName);
            if (File.Exists(path))
            {
                if (!string.IsNullOrWhiteSpace(bookDic))
                {

                    var json = File.ReadAllText(path);
                    // 反序列化
                    var oldbook = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                    foreach(var item in oldbook)
                    {
                        item.TryGetValue("name", out var n);
                       if (n.ToString() == bookDic)
                        {
                            Console.WriteLine("找到这个书本");
                            Console.WriteLine("请输入作者");
                            string author = Console.ReadLine();
                            Console.WriteLine("请输入标签");
                            string mark = Console.ReadLine();
                            Console.WriteLine("请输入价格");
                            double price = double.Parse(Console.ReadLine());

                            item["author"] = author;
                            item["mark"] = mark;
                            item["price"] = price;

                            break;


                            // 如果还有isBorrow也在这里改
                            // item["isBorrow"] = false;
                            // 修改完成跳出循环
                            //Dictionary<string, dynamic> nowbookDic = new()
                            //{
                            //    ["name"] = bookDic,
                            //    ["author"] = author,
                            //    ["isBorrow"] = false,
                            //    ["id"] = new Random().NextDouble(),
                            //    ["mark"] = mark,
                            //    ["price"] = price
                            //};

                        }

                    }
                    string newJson = JsonSerializer.Serialize(oldbook);
                    File.WriteAllText(path, newJson);

                }
                else
                {
                    return "没有这个书";
                }

            }
            else
            {


            }

                return "ok";
        }
        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 删除的逻辑处理
            //如果文件存在，则开始以下逻辑
            if (File.Exists(path))
            {

                var json = File.ReadAllText(path);
                
                if (!string.IsNullOrWhiteSpace(json))
                {
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var oldbook = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);

                        // 就这一段，直接删除匹配书名的那一条字典
                        oldbook.RemoveAll(dic =>
                        {
                            if (dic.TryGetValue("name", out var val))
                            {
                                return val.ToString() == bookName;
                            }
                            return false;
                        });

                        // 照旧写回文件
                        string newJson = JsonSerializer.Serialize(oldbook);
                        File.WriteAllText(path, newJson);
                        return "删除成功";
                    }
                    // 反序列化
                    //var oldbook = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                    //     foreach (var item in oldbook)
                    //     {
                    //         item.TryGetValue("name", out var n);
                    //         if (n.ToString() == bookName)
                    //         {
                    //             //  item.Clear();  item.Clear()：清空这一个字典里面所有键值对，不是从 List 删掉这条记录！
                    //            // JSON 里面还会保留一个空对象 { }，列表的元素还在，只是字典内部全部清空，并没有把这一本图书从 List 集合移除 ❌，这不是删除图书

                    //             break;


                    //             // 如果还有isBorrow也在这里改
                    //             // item["isBorrow"] = false;
                    //             // 修改完成跳出循环
                    //             //Dictionary<string, dynamic> nowbookDic = new()
                    //             //{
                    //             //    ["name"] = bookDic,
                    //             //    ["author"] = author,
                    //             //    ["isBorrow"] = false,
                    //             //    ["id"] = new Random().NextDouble(),
                    //             //    ["mark"] = mark,
                    //             //    ["price"] = price
                    //             //};

                    //         }

                    //     }
                    //     string newJson = JsonSerializer.Serialize(oldbook);
                    //     File.WriteAllText(path, newJson);

                }

            }
            else
            {
                return "无法删除，目前无书籍";
            }

            return "书名不存在";
            //遍历原来的数据（读取文件，反序列化，foreach foreach）
            //看看是否能找到要删除的书名，如果找到则将这个书名的字典删除
            //如果没有找到则返回改书不存在


           
        }
        // 查询所有数据
        public string SearchallBook() // 返回值根据情况修改
        {


            if (!File.Exists(path))
            {

                return "暂无图书";

            }

            else { 
                var json = File.ReadAllText(path);
            // 反序列化
            var oldbook = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);

            foreach (var item in oldbook)
            {
                Console.WriteLine("----------------------");

                    Console.WriteLine($"{"书名："+item["name"]},{" 作者：" + item["author"]},{" 是否借出："+item["isBorrow"]},{ " 标签"+item["mark"]},{ " 金额："+item["price"]+"元"}");

            }

                return "这是全部图书";
           
            }

            

        }
        // 根据图书名称查询当前图书数据：强制要求
        public string SearchBook(string bookName) // 返回值根据情况修改
        {   //如果文件不存在 --》目前图书馆还没有书
            //如果文件存在--》 执行以下逻辑
            //反序列化得到这个字典组合，遍历这个字典组合，判断要查询的书名bookname和键名的值是否一值，如果一致则输出这个书名的字典，否则这个没有这本书
            if (File.Exists(path)) {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                var oldbook = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);  
                foreach (Dictionary<string,dynamic> item in oldbook) 
                {
                    item.TryGetValue("name", out dynamic inbookName);

                    if (inbookName.ToString() == bookName)
                    {
                        //遍历当前这一个字典item，打印每一组键值对
                        foreach (var kv in item)
                        {
                            Console.WriteLine($"{kv.Key}：{kv.Value}");
                        }
                        return "找到书本";
                    }



                }

            }


            //读取里面的文件
            //反序列化
            //判断
            //如果书库中存在该书名，则把该想字典的所有的键值信息都展示出来
            //如果没有这个书名，则返回没有该图书
            // 删除的逻辑处理
            return "不存在该书本";
        }

        // 自定义实例构造函数
        public BookManager(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}
