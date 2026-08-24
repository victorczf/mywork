using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //遍历篇
            //字符串遍历(只读，不能修改字符串)
            //string s = "abcdefg";
            //for (int i = 0; i < s.Length; i++) 
            //{
            //    Console.WriteLine(s[i]);
            //}

            ////foreach遍历
            //foreach (char c in s)
            //{
            //    Console.WriteLine(c);
            //}

            //数组
            //int[] arr = {1,2,3,4,5};
            // ///for 循环时 可以修改元素
            // //forrach循环时不可修改元素
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     arr[i]= arr[i]+1;
            //     Console.WriteLine(arr[i]);
            // }

            //Action WriteLine = () =>
            //{
            //    Console.WriteLine("请输入用户名");
            //    var usename = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    var password = Console.ReadLine();
            //    var str = usename + "===" + password + "\n";
            //    File.AppendAllText("./rencai.text", str);
            //};

            //WriteLine();
            //string num="";
            //while (num != "0")

            //{
            //    Console.WriteLine("欢迎来到系统");
            //    Console.WriteLine("1");
            //    Console.WriteLine("2");
            //    Console.WriteLine("3");
            //     num = Console.ReadLine();
            //    switch (num)
            //    {
            //        case "1":
            //            Console.WriteLine("用户注册");
            //            break;
            //        case "2":
            //            Console.WriteLine("用户注册");
            //            break;
            //        case "3":
            //            Console.WriteLine("用户注册");
            //            break;
            //        case "0":
            //            Console.WriteLine("退出");
            //            break;
            //        default: Console.WriteLine("输入有误");
            //            break;



            //    }


            //多态，多态表示多种形式，弗雷在定义方式时，使用virtual修饰，这个方法可以呗子类使用的override进行重写，当我们定义子类实例对象的时候，使用父类类型存储，这时候当我们使用这个对象调用重写方法的时候，系统会自动识别当前场景应该执行哪个子类的方法，


            //方法分为重写和重载
            //在device里面写一个

     



        }

        public class Animal
        {
            public virtual void speak()
            {
                Console.WriteLine("动物叫");
            }

            public class dog : Animal
            {
                public override void speak()
                {
                    Console.WriteLine("旺旺");
                }
            }
            public class cat : Animal
            {
                public override void speak()
                {
                    Console.WriteLine("喵喵喵");
                }
            }


        }

    }
}
