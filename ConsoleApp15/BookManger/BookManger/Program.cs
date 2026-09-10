using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace BookManger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             不同类型的默认值 
                类型    默认值
                int      0
                bool     false
                引用类型  null  
             */
            //List<Dictionary<string, dynamic>> ls = new()
            //{
            //    new Dictionary<string, dynamic>()
            //    {
            //        ["a"] = 10,
            //        ["b"] = 20,
            //        ["c"] = 30,
            //    },
            //    new Dictionary<string, dynamic>()
            //    {
            //        ["a"] = 100,
            //        ["b"] = 200,
            //        ["c"] = 300,
            //    }
            //};
            //// dic 变量 接收的是 Find返回值 
            //// dic 中存储的只是 ls中某一个字典的引用            
            //var dic = ls.Find(item => item["c"] == 30);
            //dic["c"] = 33333;

            //foreach(var it in ls)
            //{
            //    foreach(var item in it) Console.WriteLine($"{item.Key} --- {item.Value}");
            //}
            //return;

            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });
                       
            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        //double price = double.Parse(Console.ReadLine());
                        // 如果输入的不是 数字那么会报错===> 输入的数据格式不符合要求
                        // 使用正则处理
                        string priceStr = Console.ReadLine();
                        // @"^[1-9]+[0-9]*(\.[0-9]+)?$"
                        if(Regex.IsMatch(priceStr, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                        {
                            // 组装 书籍 字典
                            Dictionary<string, dynamic> bookDic = new()
                            {
                                ["name"] = bookName,
                                ["author"] = author,
                                ["isBorrow"] = false,
                                ["id"] = new Random().NextDouble(),
                                ["mark"] = mark,
                                ["price"] = double.Parse(priceStr)
                            };
                            // 调用实例方法  实现 添加书籍
                            string res = BM.AddBook(bookDic);
                            Console.WriteLine(res);
                        }
                        else Console.WriteLine("输入的价格格式有误");
                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        // 根据输入的书名删除 
                        string removeBN = Console.ReadLine();
                        string resStr = BM.RemoveBook(removeBN);
                        Console.WriteLine(resStr);
                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        // 根据输入的书名 修改图书
                        Console.WriteLine("请输入书名");
                        string editBookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string editAuthor = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string editMark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double editPrice = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典 ===》 用于后续调用方法传参
                        Dictionary<string, dynamic> editBook = new()
                        {
                            ["name"] = editBookName,
                            ["author"]  = editAuthor,
                            ["mark"] = editMark,
                            ["price"] = editPrice
                        };
                        string resEditStr = BM.EditBook(editBook);
                        Console.WriteLine(resEditStr);
                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var resList = BM.SearchBook();
                        // 结果list长度是够为0
                        if (resList.Count==0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else
                        {
                            foreach(var item in resList)
                            {
                                Console.WriteLine($"书名：{item["name"]} - 作者：{item["author"]} - 标签：{item["mark"]} - 价格：{item["price"]}");
                            }
                        }
                            break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入查询的书名");
                        string searchBookName = Console.ReadLine();
                        var resBook = BM.SearchBook(searchBookName);
                        if(resBook.Count ==0) Console.WriteLine("没找到对应的数据，请先添加");
                        else Console.WriteLine($"书名：{resBook["name"]} - 作者：{resBook["author"]} - 标签：{resBook["mark"]} - 价格：{resBook["price"]}");
                        break;
                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }

            }
        }
    }
}
/*
后续同学自行完善 方向
    1. 对所有输入的数据进行校验
        - 可以先取出首尾两端的空白
        - 不为空，长度要求校验
        - 正则校验
    2. 完善一个借阅功能
        - 添加一个借阅功能的编号 比如： 5
            + 输入5 进入借阅功能
                - 将所有可借阅的书籍展示， 并要求用户输入借阅的书籍名称
                - 输入要借阅的书籍，实现借阅
    3. 完善一个还书功能  
*/
