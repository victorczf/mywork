using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //正则 8.19
            /*
             1.按照规则从字符串提取内容
                Regex.Match（字符串，正则规则）


             2.判断字符串是否符合规则（重点） 
                 @"[0-9]"  表示任意一个数字
                 @"[A-Z]"  表示任意一个大写字母
                 @"[A-Za-z]"  表示任意一个字母

                        # 正则量词符号
            | 符号   | 含义                 |
            | ------ | -------------------- |
                        // 照旧写回文件
                        string newJson = JsonSerializer.Serializ
            | *      | 任意个（0个及以上）  |
            | +      | 至少1个（1个及以上） |
            | ?      | 至多1个（0个或1个）  |
            | {m}    | 必须是 m 个          |
            | {m,}   | 至少 m 个            |
            | {m,n}  | 至少 m 个，至多 n 个 |


                        # 正则元字符
            | 符号       | 含义                                   |
            | ---------- | -------------------------------------- |
            | .          | 任意一个字符                           |
            | \d         | 任意一个数字                           |
            | \w         | 任意一个字母、数字、下划线             |
            | \s         | 一个空格                               |
            | \D         | 任意一个非数字字符                     |
            | \W         | 任意一个非字母、数字、下划线字符       |
            | \S         | 任意一个非空格字符                     |
            | [字符]     | 中括号中的任意一个字符                 |
            | [^字符]    | 非中括号中的任意一个字符               |

            ！！注意 a-b 这种这种范围语法只在[]中括号中生效
        
             */

            // 1.字符串提取
            //string reg=@"a"; //正则的规则
            //string str = "bac";

            //Match res=Regex.Match(str, reg);

            //Console.WriteLine(res.Value);


            //分组提取：
            //string reg = @"(\d{4})-(\d{2})-(\d{2})";
            // Match res = Regex.Match("2026-07-22", reg);
            // 正则中的() 是一个个单独的整体,除了整个正则表达式会匹配之外, 每个小括号也会单独匹配
            // 这些小括号单独匹配的内容 在整体匹配结果的分组中
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22 第0个组是全部的数据
            //Console.WriteLine(res.Groups[1]); // 2026  //

            //2.验证方法
            //只能输入一个50个长度以内的并且只能有中文或者字母或者数字的书名
            //string reg = "^ [\u4e00 - \u9fa5a - zA - Z0 - 9] +$";

            //3.替换方法
            / // Regex.Replace(字符串,正则,替换上的内容) // 按照正则规则 将字符串中的内容替换上指定字符串
              // 返回替换完成的字符串
              //string reg = @"a";
              //string res = Regex.Replace("bac", reg, "e");
              //Console.WriteLine(res); // bec

            // 4.多次提取:Regex.Matches(要提取的字符串);
            //string reg = @"a|b";
            //MatchCollection res = Regex.Matches("abc", reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);



            // 整串全部只能是中文、大小写字母、数字，不能为空
            string reg = @"^[\u4e00-\u9fa5a-zA-Z0-9]+$";


            //@"^(\u4e00-\u9fa5|a|b|c|…|z|A|B|…|Z|0|1|…|9){1,50}$"

            // 整串全部只能是中文、大小写字母、数字，不能为空（50长度以内）
            // string reg = @"^[\u4e00-\u9fa5a-zA‑Z0‑9]{1,50}$";
            // 大括号（长度）只管控紧挨着它左边那一个单元ab{2}(匹配的是abb)
            // 匹配：1 个汉字，后面跟 2‑4 个数字："^[\u4e00-\u9fa5][0-9]{2,4}$"

            string zongreg=@"^[a-zA-Z][\u4e00-\u9fa5][\u4e00-\u9fa5a-zA-Z0-9]{1,6}$";
            //必须以字母开头（第 1 位：大小写英文字母）
            //第 2 位必须是汉字
            //从第 3 位开始：可以是汉字、字母、数字
            //整体总长度：最少 3 位，最多 8 位
            //不允许任何特殊符号，不能有空格
            //整串严格匹配，不能前后夹带别的字符

            Console.WriteLine("请验证:");
            string str = Console.ReadLine();
            bool res=Regex.IsMatch(str, reg);
            Console.WriteLine(res);



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
            //Console.WriteLine("请输入密码(可以有字母，数字，特殊符号)");
            //string mima=Console.ReadLine();

            ///* var reg = @"\d"; // 表示任意一个数字
            // var zimu = @"[A-Za-z]";//任意一个字母
            // var teshu = @"[^A‑Za‑z\d]";//特殊*/

            //bool shuzi= Regex.IsMatch(mima, @"\d"); // True
            //bool zimu =Regex.IsMatch(mima, @"[A-Za-z]"); // True
            //bool teshu =Regex.IsMatch(mima, @"[^A-Za-z\d]"); // True

            //if (mima.Length < 8 || mima.Length > 15)
            //{ Console.WriteLine("长度要求8-15,请重新输入"); }    
            //else 
            //{
            //    if (shuzi == true && zimu == false && teshu == false)
            //    {
            //        Console.WriteLine("密码为弱");
            //    }
            //    else if (shuzi == false && zimu == true && teshu == false)
            //    {
            //        Console.WriteLine("密码为弱");
            //    }
            //    else if (shuzi == false && zimu == false && teshu == true)
            //    {
            //        Console.WriteLine("密码为弱");
            //    }
            //    else if (shuzi == true && zimu == true && teshu == false)
            //    {
            //        Console.WriteLine("密码为中");
            //    }
            //    else if (shuzi == true && zimu == false && teshu == true)
            //    {
            //        Console.WriteLine("密码为中");
            //    }
            //    else if (shuzi == false && zimu == true && teshu == true)
            //    {
            //        Console.WriteLine("密码为中");
            //    }
            //    else if (shuzi == true && zimu == true && teshu == true)
            //    {
            //        Console.WriteLine("密码为强");
            //    }
            //}

        }
    }

}