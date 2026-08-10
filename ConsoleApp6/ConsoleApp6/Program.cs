using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello, World!");
            //敏感词替换
            /*
            string str = "生活总会有大麻烦，黑夜总会过去";
            List<string> mgc = ["大麻", "夜总会"];

            foreach (string str1 in mgc) 
            {
                string newStr = "";
                for (int i = 0; i < str1.Length; i++) newStr += "*";
                str = str.Replace(str1, newStr);
            }
            Console.WriteLine(str);
            */

          /*  string oldStr = "you love i";

            string[] strArr = oldStr.Split();

            List<string> strList = new();
            foreach (string str in strArr) strList.Add(str);
            strList.Reverse();

            string resStr = "";
            foreach (string item in strList)
            {
                string fisrtLetter = item.Substring(0, 1).ToUpper();
                string otherLetters = item.Substring(1).ToLower();
                resStr += fisrtLetter + otherLetters + " ";

            }
            Console.WriteLine(resStr.Substring(0, resStr.Length - 1));

            */


            //思路一


            /* string reg = @"刘德华|黎明";
             string str = "hello, I am 刘德华, your name is 黎明?";

             MatchCollection all = Regex.Matches(str, reg);

             Console.WriteLine(all[0].Value); //第0个：刘德华
             Console.WriteLine(all[1].Value); //第1个：黎明*/

            //思路二

            /*string reg = @"刘德华|黎明";
            string str = "hello, I am 刘德华, your name is 黎明?";

            // Matches拿到全部匹配结果
            MatchCollection all = Regex.Matches(str, reg);

            foreach (Match item in all)
            {
                Console.WriteLine(item.Value);
            }*/

            //第二题
            /* string str = "abc  dd  ee  ff  gg  HH  h j k";
             //var reg = @"\s"; // 表示任意一个空白符(空格)
             string result = Regex.Replace(str, @"\s+", "*");
             Console.WriteLine(result);*/

            //第三题
            // string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //string reg = @"(\d{6})(\d{4})(\d{2})(\d{2})";
            // Console.WriteLine(reg.Groups[1]); // 2026  // 第一个小括号匹配的结果
            // Console.WriteLine(reg.Groups[2]); // 07
            // Console.WriteLine(reg.Groups[3]); // 22



            /* string reg = @"(\d{6})(\d{4})(\d{2})(\d{2})\d{3}[\dX]";

             string str = "我的身份证号是：360731200111052112,你的身份证是：42108320041119211X";

             MatchCollection all = Regex.Matches(str, reg);

             foreach (Match m in all)
             {
                 Console.WriteLine("身份证：" + m.Value);
               // Console.WriteLine("地区码：" + m.Groups[1]);
                 Console.WriteLine("出生年：" + m.Groups[2]);
                 Console.WriteLine("出生月：" + m.Groups[3]);
                 Console.WriteLine("出生日：" + m.Groups[4]);
                 Console.WriteLine("-----");
             }

             */
            Console.WriteLine("请输入密码(可以有字母，数字，特殊符号)");
            string mima=Console.ReadLine();

            /* var reg = @"\d"; // 表示任意一个数字
             var zimu = @"[A-Za-z]";//任意一个字母
             var teshu = @"[^A‑Za‑z\d]";//特殊*/

            bool shuzi= Regex.IsMatch(mima, @"\d"); // True
            bool zimu =Regex.IsMatch(mima, @"[A-Za-z]"); // True
            bool teshu =Regex.IsMatch(mima, @"[^A-Za-z\d]"); // True

            if (mima.Length < 8 || mima.Length > 15)
            { Console.WriteLine("长度要求8-15,请重新输入"); }    
            else 
            {
                if (shuzi == true && zimu == false && teshu == false)
                {
                    Console.WriteLine("密码为弱");
                }
                else if (shuzi == false && zimu == true && teshu == false)
                {
                    Console.WriteLine("密码为弱");
                }
                else if (shuzi == false && zimu == false && teshu == true)
                {
                    Console.WriteLine("密码为弱");
                }
                else if (shuzi == true && zimu == true && teshu == false)
                {
                    Console.WriteLine("密码为中");
                }
                else if (shuzi == true && zimu == false && teshu == true)
                {
                    Console.WriteLine("密码为中");
                }
                else if (shuzi == false && zimu == true && teshu == true)
                {
                    Console.WriteLine("密码为中");
                }
                else if (shuzi == true && zimu == true && teshu == true)
                {
                    Console.WriteLine("密码为强");
                }
            }

        }
    }

}