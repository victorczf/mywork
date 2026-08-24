using Microsoft.VisualBasic;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //上节回顾
            //一：委托

            //Action wrirelog = () =>
            //{
            //    var wenjian = "./content.log";
            //    File.AppendAllText(wenjian, "hello   " + DateTime.Now + "\r\n");

            //};
            //wrirelog();

            //File.WriteAllText();写这个会覆盖
            //File.AppendAllText();


            // 案例2 获取目录下所有目录和文件（一级）
            // 封装一个函数 一个参数(接收路径), 返回值 List<string>
            //Func<string, List<string>> getFileAndDir = path =>
            //{
            //    List<string> resList = [];
            //    // 判断路径是否是 目录 ===> 使用刚刚书写的函数
            //    // 如果不是目录则 手动抛出一个异常
            //    //if (isFileOrDir(path) != 2) throw new Exception("传递的参数有误,必须要是目录路");
            //    // 获取目录下的所有文件
            //    string[] files = Directory.GetFiles(path);
            //    // 将得到 files数组添加到 list中
            //    resList.AddRange(files);

            //    // 获取所有的目录
            //    string[] dirs = Directory.GetDirectories(path);
            //    resList.AddRange(dirs);
            //    return resList;
            //};

            //var res = getFileAndDir("./");

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //案例优化返回值
            //Func<string, Dictionary<string, string[]>> getFileAndDir = path =>
            //{
            //    var resDic = new Dictionary<string, string[]>();

            //    // 获取目录下的所有文件
            //    string[] files = Directory.GetFiles(path);
            //    resDic["files"] = files;

            //    // 获取所有的目录
            //    string[] dirs = Directory.GetDirectories(path);
            //    resDic["dirs"] = dirs;
            //    return resDic;
            //};

            //var res = getFileAndDir("D:\\pd");
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item.Value) Console.WriteLine(item2);
            //    Console.WriteLine("------------------------");
            //}

            //先请求用户输入账号和密码


            //把账号和密码储存到变量 
            //while (true)
            //{
            //    Console.WriteLine("输入账号和密码");
            //    string user = Console.ReadLine();
            //    string mima = Console.ReadLine();
            //    if (user != null && mima != null)
            //    {
            //        string[] arr = new string[] { "账号："+user, "   密码："+mima, "\n===\n" };
            //        //创建文件路径并写入
            //        var path1 = "./user.txt";
            //        for (int i = 0; i < 2; i++)
            //        {
            //            File.AppendAllText(path1, arr[i]);  
            //            if (i == 1) { File.AppendAllText(path1, arr[2]); }

            //        }


            //    }
            //    else { Console.WriteLine("账号或者密码为空，请从新输入"); }

            //}
            while (true)
            {

                //账号正则 字母数字下划线，3‑16 位，不能空格特殊符号
                string regUser = @"^[a-zA-Z0-9_]{3,16}$";
                //密码正则  字母 + 数字，6‑12 位
                string regPwd = @"^[a-zA-Z0-9]{6,12}$";
                string jsonPath = "./user.json";
                string logPath = "user.log";

                Console.WriteLine("菜单栏：1注册，2登录，0退出");

                int fangshi = int.Parse(Console.ReadLine());

                if (fangshi == 1)
                {
                    Console.WriteLine("请输入注册用的用户名:");
                    string user = Console.ReadLine();
                    File.AppendAllText(logPath, "接收到用户注册时已输入账号" + user + "  时间：" + DateAndTime.Now+"\n");
                    Console.WriteLine("请输入密码:");
                    string mima = Console.ReadLine();
                    File.AppendAllText(logPath, "接收到用户注册时已输入密码" + user + "  时间：" + DateAndTime.Now + "\n");
                    bool userOk = Regex.IsMatch(user, regUser);
                    bool pwdOk = Regex.IsMatch(mima, regPwd);
                    if (userOk && pwdOk)
                    {

                        Console.WriteLine("注册成功");
                        
                        //json
                       string json = $@"{{
                      ""Username"": ""{user}"",
                      ""Password"": ""{mima}"",
                      ""RegisterTime"": ""{DateTime.Now:yyyy‑MM‑dd HH:mm:ss}""
                    }}";
                        //把信息json序列化并写进文件
                        File.WriteAllText(jsonPath, json);
                        //同时也把信息写进日记
                        File.AppendAllText(logPath, "接收到新注册用户账号："+user+"  密码："+mima+"  时间：" + DateAndTime.Now + "\n");
                        continue;
                    }
                    else if (!userOk && pwdOk)
                    { File.AppendAllText(logPath, "用户注册时用户名格式输入错误"+"  时间："+DateAndTime.Now + "\n");
                        Console.WriteLine("用户名格式输入错误");
                        continue;
                    }
                    else if (userOk && !pwdOk) { File.AppendAllText(logPath, "用户注册时密码格式输入错误" + "  时间：" + DateAndTime.Now + "\n");
                        Console.WriteLine("密码格式输入错误");
                        continue;
                    }


                }
                else if (fangshi == 2)
                {
                    Console.WriteLine("请输入登录的用户名:");
                    string user = Console.ReadLine();
                    File.AppendAllText(logPath, "接收到用户登录时已输入账号" + user  + "  时间：" + DateAndTime.Now + "\n");
                    Console.WriteLine("请输入密码:");
                    string mima = Console.ReadLine();
                    File.AppendAllText(logPath, "接收到用户登录时已输入密码" + user + "  时间：" + DateAndTime.Now + "\n");

                    bool userOk = Regex.IsMatch(user, regUser);
                    bool pwdOk = Regex.IsMatch(mima, regPwd);
                    if (userOk && pwdOk)
                    {

                        Console.WriteLine("登录成功");
          
                        //同时也把信息写进日记
                        File.AppendAllText(logPath, "接收到用户登录成功：" + user + "  密码：" + mima + "  时间：" + DateAndTime.Now + "\n");
                        continue;
                    }
                    else if (!userOk && pwdOk)
                    { File.AppendAllText(logPath, "用户登录时用户名格式输入错误" + "  时间：" + DateAndTime.Now + "\n");
                        Console.WriteLine("用户名输入错误");
                        continue;
                    }
                    else if (userOk && !pwdOk) { File.AppendAllText(logPath, "用户登录时密码格式输入错误" + "  时间：" + DateAndTime.Now + "\n");
                        Console.WriteLine("密码输入错误");
                        continue;
                    }
                }

                else if (fangshi == 0)
                {   File.AppendAllText(logPath, "用户选择了退出程序" + "  时间：" + DateAndTime.Now + "\n"); }
                    Console.WriteLine("程序已退出");
                    break;
                    
                }

            



        










            //遍历字符串（1）for  
            //string s="abcdefg";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
            



        }
    }
}
