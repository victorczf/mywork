using System;

namespace Carsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义一个信息类 ==》车辆类 
            //定义一个车辆管理类
            //死循环 swith case 语句
            //实例化车辆管理类
            cargl Cg= new cargl();
            //实例化用户类
            Usergl Ug= new Usergl();

            //实例化租车类
            returncargl Rg =new returncargl(); 
            string num = "";
       
            while (num!="0") 

            {
                tishi();//提示输入
                 num = Console.ReadLine();
                switch (num) {

                    //新增车辆
                    case "1":
                        // 输入车辆信息提示（新增车辆）
                        Console.WriteLine("请输入车牌号：");
                        string card   = Console.ReadLine();
                                                                        Console.WriteLine("请输入车类型：");
                        string carType = Console.ReadLine();
                                                                        Console.WriteLine("请输入时租费：");
                        double Price   = double.Parse(Console.ReadLine());
                        //写到这里我的想法是直接把这数据传给构造函数 message shuju = new message(carId, carType,Price);！
                        //这样不行，构造函数存储的数据要处理后的数据，所以要先把数据传到车辆管理类里面的add函数处理，序列化等等
                        var res = Cg.Add(card, carType, Price);

                        break;
        
                    case "2":

                        Cg.SearchAll();

                        break;
                    case "3":
                        Console.WriteLine("请输入id：");
                        int id = int.Parse(Console.ReadLine());
                        Cg.Searchsg(id);
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("请输入客户姓名：");
                        string userName = Console.ReadLine();
                        Console.WriteLine("请输入身份证号：");
                        string userCardId = Console.ReadLine();
                        Console.WriteLine("请输入性别：");
                        string gender = Console.ReadLine();
                        Console.WriteLine("请输入手机号：");
                        string telNum = Console.ReadLine();
                        Console.WriteLine("请输入座右铭：");
                        string motto = Console.ReadLine();
                        //把他传进我写的方法函数
                       string res5= Ug.adduser(userName, userCardId, gender, telNum, motto);
                        Console.WriteLine(res5);

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":
                       string res8=Rg.Recar();
                        Console.WriteLine(res8);
                        break;
                    case "9":

                        break;
                    case "0":

                        break;



                }
            
            }


        }

        internal static void tishi() {
          Console.WriteLine("==欢迎来到神车系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：换车");
            Console.WriteLine("10：查看所有租车记录");
            
        }
    }
}
