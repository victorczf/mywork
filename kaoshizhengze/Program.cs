using System.Text.RegularExpressions;

namespace kaoshizhengze
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] strArr = { " 13812345678 ", "HelloABC", " 15987654321 ", "123456", " 17600001111 " };

           
            string phoneReg = @"^1[34578]\d{10}$";

            foreach (string item in strArr)
            {
                //去除前后空格，字母转小写
                string s = item.Trim().ToLower();

                //3.正则手机号
                if (Regex.IsMatch(s, phoneReg))
                {
                    Console.WriteLine($"合法手机号：{s}");
                }
                else if (Regex.IsMatch(s, @"^\d+$"))
                {
                    Console.WriteLine($"非法手机号：{s}");
                }
                else
                {
                    Console.WriteLine($"普通文本：{s}");
                }
            }
        }
    }
}
   

