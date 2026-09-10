using QQ.WW;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using XX;
using YY;
using xa = XX.AA; // 给引入的命名空间下的类起别名
using ya = YY.AA;
namespace day14
{

    // 枚举类型不能再内部定义
    enum Gender
    {
        MAN = 2,
        WOMAN,
        UNKONW
    }
    class Res1
    {
        public string text { get; set; }
    }

    internal class Program
    {
        //static async Task Main(string[] args)
        //{
        //    //// 创建请求对象
        //    //HttpClient hc = new HttpClient();
        //    //// 发送请求
        //    //var response = await hc.GetAsync("https://uapis.cn/api/v1/saying");
        //    ////Console.WriteLine(response.Content);
        //    //// 解析请求 返回的数据
        //    //string resStr = await response.Content.ReadAsStringAsync();
        //    //////Console.WriteLine(resStr);
        //    ////// 返回的数据是json格式字符串 ===> 反序列化
        //    //////var resDic = JsonSerializer.Deserialize<Dictionary<string,dynamic>>(resStr);
        //    //////Console.WriteLine(resDic["text"]);
        //    //// Res1 是定义的类型 （类）  ===> 对于对象 就是一种类型
        //    //Res1 resObj = JsonSerializer.Deserialize<Res1>(resStr);
        //    //Console.WriteLine(resObj.text);
        //    //// new Res1()  ====> {text:"sdsfsfsf"}

        //    //// 请求网络图片
        //    //HttpClient hc = new HttpClient();
        //    //// 发送请求 返回的是一个字节数组
        //    //byte[] response = await hc.GetByteArrayAsync("https://assets.699pic.com/public/img95/photo/50059/8720.jpg_wh860.jpg");

        //    //// 将请求字节数组数据方法 写入文件
        //    //File.WriteAllBytes("./fj.png", response);
        //}





        // async修饰函数 中 才可以使用await
        //static async Task Main(string[] args)
        //{
        //    //// 同步读取3个文件内容
        //    //// 开始计时
        //    //Stopwatch stopwatch1 = Stopwatch.StartNew();
        //    //string aContent = File.ReadAllText("./a.txt");
        //    //string bContent = File.ReadAllText("./b.txt");
        //    //string cContent = File.ReadAllText("./c.txt");
        //    //stopwatch1.Stop();
        //    //Console.WriteLine($"同步读取耗时：{stopwatch1.ElapsedMilliseconds} ms");
        //    //// 异步同时读取
        //    //// 开始计时
        //    //Stopwatch stopwatch2 = Stopwatch.StartNew();
        //    //Task<string> aTask = File.ReadAllTextAsync("a.txt");
        //    //Task<string> bTask = File.ReadAllTextAsync("b.txt");
        //    //Task<string> cTask = File.ReadAllTextAsync("c.txt");
        //    //// 结束计时
        //    //string[] res = await Task.WhenAll(aTask, bTask, cTask);
        //    //stopwatch2.Stop();
        //    //Console.WriteLine($"异步同时读取耗时：{stopwatch2.ElapsedMilliseconds} ms");

        //    // await 修饰 执行的异步代码
        //    string aContent = await File.ReadAllTextAsync("a.txt");
        //    string bContent = await File.ReadAllTextAsync("b.txt");
        //}



        // 定义一个 查看 列表数据的方法
        static void ShowList<T>(List<T> ls)
        {
            foreach (T item in ls)
            {
                Console.WriteLine(item);
            }

        }


        static void Main(string[] args)
        {

            // 泛型
            //List<int> ls1 = [10, 20, 30];
            //ShowList<int>(ls1);

            //List<string> ls2 = ["10aa", "20bb", "30cc"];
            //ShowList<string>(ls2);

            Person<string, bool> p = new Person<string, bool>()
            {
                x = "哈哈",
                y = true
            };

            string resS = p.info<double, long>(10.1, 33333333333);
            Console.WriteLine(resS);





            // 枚举
            //int man = 1; // 男
            //int woman = 2; // 女
            //int unknow = 0; // 未知

            ////man = 3;

            //Gender man = Gender.MAN;
            //Console.WriteLine(man);
            //Console.WriteLine((int)man == 2); // True
            //Gender un = Gender.UNKONW;
            //Console.WriteLine((int)un == 4);



            //Console.WriteLine("start");
            //for (int i = 0; i < 20000; i++)
            //{
            //    Console.Write("6");
            //}
            //Console.WriteLine("end");

            //// 结构体
            //A zs1 = new A("zs", 17);
            //Console.WriteLine(zs1.name);
            //A zs2 = zs1;
            //zs2.name = "ls";
            //Console.WriteLine(zs1.name);
            //Console.WriteLine(zs2.name);

            // 命名空间
            ////new ABC();
            ////new AA();
            ////new XX.AA();
            ////new XX.AA();
            ////new XX.AA();
            ////new XX.AA();
            ////new AA();
            ////new QQ.WW.CC();
            ////new CC();
            //new xa().say();
            //new ya().say();
        }
    }
}
