/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("输入两个数字:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a + b;
            Console.WriteLine(c);

        }
    }
}*/


//第二题
/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("输入需要转换的华氏度:");
            double a = double.Parse(Console.ReadLine());
            double b = 5 / 9.0 * (a - 32);

            Console.WriteLine("转换后输出的摄氏度为："+b.ToString("0.000"));

        }
    }
}*/

//第三题
/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数字赋给第一个整型a");
           int a= int.Parse(Console.ReadLine());
            Console.WriteLine("输入数字赋给第二个整型b");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a=b;
            b = c;

            Console.WriteLine($"交换后a={a},交换后b={b}");


        }
    }
}*/

//第四题
/*namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入战士抗洪的小时数");
            int a = int.Parse(Console.ReadLine());

            //天数
            int b = a / 24;
            int c =a%24;
            Console.WriteLine($"战士一共抗洪了{b}天{c}小时");
        }
    }
}*/


//练习手感
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入两个整数(第一个为被除数):");
            int a=int.Parse( Console.ReadLine());
            int b=int.Parse( Console.ReadLine());
            if(b==0)
            {
                Console.WriteLine("除数不能为0,请重新输入");
                 a = int.Parse(Console.ReadLine());
                 b = int.Parse(Console.ReadLine());
            }

            int c = a + b;
            int d = a - b;
            int f = a * b;
            int g = a / b;
            int h = a % b;
            Console.WriteLine($"他两的和是{c},差是{d},乘积是{f},商是{g},余数是{h}");

            
        }
    }
}