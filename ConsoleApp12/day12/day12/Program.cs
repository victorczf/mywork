namespace day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 多态====> 方法重写
            //var p1 = new PLC()
            //{
            //    DeviceName = "PLC"
            //};
            //p1.Connect();          
            //p1.Disconnect();
            //p1.Start();
            // 多态====> 方法重载
            var person1 = new Person("zs",17,10000,true,true);
            person1.Say();
            person1.Say("大魔仙");
            person1.Say("小魔仙","老魔仙");

            #region 继承
            //var c1 = new Camera()
            //{
            //    DeviceName = "相机1"
            //};
            //c1.Connect();
            //c1.CaptureImage();
            //c1.Disconnect();

            //Console.WriteLine("=====================");
            //var m1 = new MotionController()
            //{
            //    DeviceName = "控制器1"
            //};
            //m1.Connect();
            //m1.MoveAxis();
            //m1.Disconnect();

            //Console.WriteLine("=====================");
            //var p1 = new PLC()
            //{
            //    DeviceName = "PLC"
            //};
            //p1.Connect();
            //p1.ReadRegister();
            //p1.Disconnect();
            #endregion


            #region 构造函数
            // 没有Person自定义构造函数===> 在实例化对象时候 也可以设置属性初始值
            //Person p2 = new Person()
            //{
            //    // 可以给属性初始化值
            //    Name = "ww",
            //    //Id = 18,// 在类外部不能给只读属性赋值
            //    //Salary = 10000,// 保护的属性, 在类外部无法访问
            //    IsMan = true,
            //};
            //p2.GetInfo(true);

            //// 有自定义构造函数
            //Person p0 = new Person("ls", 19, 9000, false,true);
            //p0.GetInfo(true);
            //Person p1 = new Person("zs", 18, 10000, true,true);
            //p1.GetInfo(false);

            // 私有构造函数
            //SingleInstance single = new SingleInstance();// 报错
            // 通过 静态方法调用得到 实例对象
            //SingleInstance single1  = SingleInstance.GetInstance();
            ////Console.WriteLine(single1.isTool);

            //SingleInstance single2 = SingleInstance.GetInstance();
            ////Console.WriteLine(single2.isTool);

            //Console.WriteLine(single1 == single2); // True
            #endregion




            #region 访问修饰符
            //Person p1 = new Person();
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.IsMan);
            //Console.WriteLine(p1.Age); // 报错: 外部不能访问 protected属性
            //Console.WriteLine(p1.Salary);//报错: 外部不能访问 private属性
            //p1.GetInfo(true); // 名字: --年龄:0---薪水:0

            //p1.GetInfoStatic(); // 静态方法或属性是给类使用的, 实例对象不能访问
            //Person.GetInfoStatic(p1);

            //string.Join(参数,参数)  // 这个Join就是系统内置给字符串类型的静态方法
            // "abc".Split();    // 这个Split方法就是普通的方法,给实例对象使用的
            #endregion

            #region 实例化对象
            //// 实例化Animal对象
            //Animal Bird = new Animal();
            //// 实例对象 可以访问属性 ====> 对象.属性名
            //Console.WriteLine(Bird.Name);
            //// 通过实例对象 修改对象的属性 ===> 对象.属性名 = 值
            //Bird.Name = "麻雀";
            //Console.WriteLine(Bird.Name);// 麻雀
            ////Bird.Description = "我能飞上青天";
            //// 通过实例对象 调用方法  ====>对象.方法名()
            //Bird.Run(); // 名字:麻雀,跑起来,描述:
            //Console.WriteLine("======================");
            //Animal Dog = new Animal();
            //Dog.Name = "旺财";
            //Dog.Run();
            #endregion
        }
    }

    //// 定义一个类
    //public class Animal {
    //    // 定义类中的属性 {get;set;}  代表这个属性是否可以访问(get)及赋值(set)
    //    public string Name { get; set; }
    //    public string Description { get; }
    //    // 类中定义方法
    //    public void Run()
    //    {
    //        // 可以在类中 直接访问属性
    //        Console.WriteLine($"名字:{Name},跑起来,描述:{Description}");
    //    }
    //}
}


//namespace day12
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //// 回调函数---常见使用: 封装在循环中变化条件判断
//            ////List<int> Filter(List<int> list)
//            ////{
//            ////    List<int> newList = new List<int>();
//            ////    // 变量list
//            ////    foreach (var item in list)
//            ////    {
//            ////        if (item > 10) newList.Add(item);
//            ////    }
//            ////    return newList;
//            ////}
//            //// 使用
//            ////List<int> list = [1, 20, 3, 40, 5, 60, 7];
//            ////var resList = Filter(list);
//            ////foreach (var item in resList) Console.WriteLine(item);

//            //List<int> Filter(List<int> list, Func<int, bool> callBack)
//            //{
//            //    List<int> newList = new List<int>();
//            //    // 变量list
//            //    foreach (var item in list)
//            //    {
//            //        if (callBack(item)) newList.Add(item);
//            //    }
//            //    return newList;
//            //}
//            ////使用
//            ////List<int> list = [1, 20, 3, 40, 5, 60, 7];

//            ////bool ConditionFn(int item)
//            ////{
//            ////    return item > 10;
//            ////}
//            ////var resList = Filter(list);
//            ////foreach (var item in resList) Console.WriteLine(item);

//            ////Func<int, bool> ConditionFn2 = (int item) =>
//            ////{
//            ////    return item < 10;
//            ////};
//            ////var resList1 = Filter(list, ConditionFn2);
//            ////foreach (var item in resList1) Console.WriteLine(item);

//            ////箭头函数简写
//            ////Func<int, bool> ConditionFn2 = item => item < 10;
//            ////var resList1 = Filter(list, ConditionFn2);
//            ////foreach (var item in resList1) Console.WriteLine(item);

//            ////Func<int, bool> ConditionFn2 = item => item < 10;// 省略 条件函数的中间变量

//            //List<int> list = [1, 20, 3, 40, 5, 60, 7];
//            ////var resList1 = Filter(list, item => item < 10);

//            //var resList1 = Filter(list, item => item > 10);
//            //foreach (var item in resList1) Console.WriteLine(item);

//        }
//    }
//}