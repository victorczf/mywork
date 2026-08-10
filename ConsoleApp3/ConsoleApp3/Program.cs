namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            Console.WriteLine("请输入追求者的资产");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入追求者的颜值");
            double b = double.Parse(Console.ReadLine());
            bool c = a > 300 && b > 8;
            Console.WriteLine(c);*/

            //小红是一个要求很奇葩的女孩子，他要么喜欢渣男，要么喜欢没钱的，要么喜欢丑的
            //定义：忠诚度低于五分的算渣男，资产1w一下算穷人，颜值低于六分算丑的

            /* Console.WriteLine("请输入忠诚度:");
             double z = double.Parse(Console.ReadLine());
             Console.WriteLine("请输入资产：");
             int m = int.Parse(Console.ReadLine());
             Console.WriteLine("请输入颜值分：");
             double y = double.Parse(Console.ReadLine());
             bool res = z < 5 || m < 10000 || y < 6;
             Console.WriteLine(res);*/

            //小红做车模，车模年龄要求是16-22
            /* Console.WriteLine("请输入年龄：");
             int age =int.Parse(Console.ReadLine());
             bool res = !(age < 16 && age > 20);
             Console.WriteLine(res);*/

            //早餐安排
            //如果今天是星期一，那就吃鸡蛋，如果是星期二，那就吃燕麦，如果星期三，那就是吃馒头


            /* Console.WriteLine("请输入今天是星期几");
             string a=Console.ReadLine();
             if (a == "星期一")
             {
                 Console.WriteLine("吃鸡蛋");
             }
             else if (a == "星期二")
             {

                 Console.WriteLine("吃燕麦");
             }
             else if(a=="星期三") {
                 Console.WriteLine("吃馒头");
             }*/

            /*
             * Console.WriteLine("请输入开始成绩(1-100): ");
            double score=double.Parse(Console.ReadLine());
            if (score < 60&& score>0)
                Console.WriteLine("不及格");
            else if (score < 80 && score > 0)
            {
                Console.WriteLine("及格");

            }

            else if (score < 90 && score > 0)
            {
                Console.WriteLine("良好");
            }
            else if (score <= 100 && score > 0)
            {
                Console.WriteLine("优秀");
            }
            else
            {
                Console.WriteLine("请重新输入分数");

            }*/


            /*int a = 5;
            int b = 6;
            int c = 9;
            if (a > b)
            {
                if (a > c) Console.WriteLine("a最大");
                else Console.WriteLine("c最大");
            }
            else { 
                if(b>c) Console.WriteLine("b最大");
                else Console.WriteLine("c最大");
            }*/


            /*    Console.WriteLine("请输入1-7");
                int n=int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("今天是星期一");
                        break;
                    case 2:
                        Console.WriteLine("今天是星期二");
                        break;
                    case 3:
                        Console.WriteLine("今天是星期三");
                        break;
                    case 4:
                        Console.WriteLine("今天是星期四");
                        break;
                    case 5:
                        Console.WriteLine("今天是星期五");
                        break;
                    case 6:
                        Console.WriteLine("今天是星期六");
                        break;
                    case 7:
                        Console.WriteLine("今天是星期日");
                        break;
                    default: Console.WriteLine("输入错误");
                        break;
                }*/

            /*Console.WriteLine("请输入分数");
            int score = int.Parse(Console.ReadLine());

         int n = score / 10;
            switch (n)
            {
                case 1: Console.WriteLine($"{score}分数是F等级"); break;
                case 2: Console.WriteLine($"{score}分数是F等级"); break;
                case 3: Console.WriteLine($"{score}分数是F等级"); break;
                case 4: Console.WriteLine($"{score}分数是F等级"); break;
                case 5: Console.WriteLine($"{score}分数是F等级"); break;
                case 6: Console.WriteLine($"{score}分数是F等级"); break;
                case 7: Console.WriteLine($"{score}分数是C等级"); break;
                case 8: Console.WriteLine($"{score}分数是B等级"); break;
                case 9: Console.WriteLine($"{score}分数是A等级"); break;
                case 10: Console.WriteLine($"{score}分数是A等级"); break;
                default: Console.WriteLine("输入错误");break;
            }*/



            //1,3,5,7,8,10,12:31天
            //2==>28天
            /* Console.WriteLine("请输入月份");
              int month  =int .Parse(Console.ReadLine());

              switch (month) {
                  case 1: Console.WriteLine("31天");break;
                  case 3: Console.WriteLine("31天");break;
                  case 5: Console.WriteLine("31天");break;
                  case 7: Console.WriteLine("31天");break;
                  case 8: Console.WriteLine("31天");break;
                  case 12: Console.WriteLine("31天");break;
                  case 10: Console.WriteLine("31天");break;
                  case 4: Console.WriteLine("30天");break;
                  case 6: Console.WriteLine("30天");break;
                  case 9: Console.WriteLine("30天");break;
                  case 11: Console.WriteLine("30天");break;
                  case 2: Console.WriteLine("28天");break;


              }*/
            //穿透写法

            /*  Console.WriteLine("请输入月份");
              int month = int.Parse(Console.ReadLine());

              switch (month)
              {
                  case 1:
                  case 3:
                  case 5:
                  case 7:
                  case 8:
                  case 12:
                  case 10: Console.WriteLine("31天"); break;
                  case 4:
                  case 6:
                  case 9:
                  case 11: Console.WriteLine("30天"); break;
                  case 2: Console.WriteLine("28天"); break;
                  default: Console.WriteLine("输入错误"); break;

              }*/

            //swith简写
            /* if(score>0&&score<=100)
             {
                 string res = score switch
                 {
                     >= 90 => "A",
                     >= 80 => "B",
                     >= 70 => "C",
                     >= 60 => "D",
                     _ => "F"
                 };
                 Console.WriteLine(res);

             }
             else Console.WriteLine("输入错误");*/




            //三元表达式
            /* Console.WriteLine("请输入年龄：");
             int age = int.Parse(Console.ReadLine());

             string res = age > 18 ? "成年了" : "未成年";
             Console.WriteLine(res);*/



            /*Console.WriteLine("请输入年份");
            int year =int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("该年是闰年");

            }
            else
            {
                Console.WriteLine("该年是不是闰年");
            }*/

            /* Console.WriteLine("请输入年份");
             int year = int.Parse(Console.ReadLine());
             string res = (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) ? "该年是闰年" : "该年是平年";
             Console.WriteLine(res);
             */





            //作业
            /***************************************************************/
            /* string user = "admin";
             string mima = "123456";
             Console.WriteLine("请输入账号");
             string sruser=Console.ReadLine();

             //第一题
             if (sruser != user )
             {
                 Console.WriteLine("账号不存在，请重新输入");

             }
             else 
             {

                 Console.WriteLine("请输入密码");
                 string srmima = Console.ReadLine();
                 if (sruser == user && srmima == mima)
                 {
                     Console.WriteLine("登入成功");
                 }
                 else
                 {
                     Console.WriteLine("密码错误");
                 }
             }*/

            //第二题：

            /* Console.WriteLine("请选择菜单(add/edit/del)");
             string a= Console.ReadLine();
             switch (a)
             {

                 case "add": Console.WriteLine("新增成功");break;
                 case "edit": Console.WriteLine("编辑成功");break;
                 case "del": Console.WriteLine("删除成功");break;
                 default: Console.WriteLine("输入错误");break;
             }*/


            //第三题：
            /* Console.WriteLine("输入自己的类型VIP(输入1)/USER(输入2)");

             string lei = Console.ReadLine();
             Console.WriteLine("请输入你的消费金额:");
             double money = double.Parse(Console.ReadLine());
             double res;
             if (lei == "1")
             {
                 if (money >= 1000 )
                 {
                     res = money * 0.9;

                 }
                 else res = money;
                 Console.WriteLine($"您要支付的金额为{res}");
             }
             else if (lei == "2")
                 { 

                 if (money >= 2000)
                     {
                          res = money * 9.5;
                     }
                 else res = money;
                 Console.WriteLine($"您要支付的金额为{res}");
             }


             else { Console.WriteLine("输入错误"); }
            */

            //第四题:
            /* Console.WriteLine("请输入月份：");
             int month =int .Parse(Console.ReadLine());
             switch (month) {
                 case 3:  
                 case 4:  
                 case 5: Console.WriteLine("这是春季");break;
                 case 6:
                 case 7:
                 case 8: Console.WriteLine("这是夏季");break;
                 case 9:
                 case 10:
                 case 11: Console.WriteLine("这是秋季");break;
                 case 12:
                 case 1:
                 case 2: Console.WriteLine("这是冬季");break;   
             }*/

            //第五题
            /* Console.WriteLine("请输入快递重量(单位是KG)");
             double weight=double.Parse(Console.ReadLine());
             if(weight>0&&weight<1)
             {
                 Console.WriteLine("快递费为10元");
             }
             else if(weight>1&&weight<=5)
             {
                 Console.WriteLine("快递费为20元");
             }
             if(weight>5)
             {
                 Console.WriteLine("快递费为50元");
             }*/


            //第六题
            /*Console.WriteLine("输入会员等级");
            int grade=int.Parse(Console.ReadLine());
            string res = grade switch
            {
                5=> "终身免运费",
                4=> "每月可领优惠券",
                3=> "购物打九折",
                _=>"没有福利"
            };
            Console.WriteLine(res);*/

            //第七题
            /*Console.WriteLine("输入商品编号整数");
           int number= int.Parse(Console.ReadLine());
            switch (number) {
                case 1: Console.WriteLine("已购买可乐");break;
                case 2: Console.WriteLine("已购买雪碧");break;
                case 3: Console.WriteLine("已购买矿泉水");break;
                default: Console.WriteLine("没有此商品");break;
            }*/

           /* Console.WriteLine("请输入当前速度");
            double speed =double.Parse(Console.ReadLine());
            string res = speed switch
            {
                <= 30 => "低速通过",
                <= 60 => "中速通过",
                <= 100 => "高速通过",
                <= 120 => "超速通过",
                _ => "输入错误"
            };
            Console.WriteLine(res);
            */

        }
    }
}
