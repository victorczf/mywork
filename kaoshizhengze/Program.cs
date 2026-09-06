using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] strarr = new string[] { " 015616466 ", " 你是谁", "18070623303", " 12565131661", " 加油啊" };
        List<string> list = new List<string>();

        for (int i = 0; i < strarr.Length; i++)
        {      
            string a = strarr[i].Trim().ToLower();
            list.Add(a);
        }

        string sumtest = "";
        string sumphone = "";
        string sumfalsephone = "";

        foreach (string str in list)
        {
            bool isRightPhone = Regex.IsMatch(str, @"^1[34578]\d{9}$");
          
            bool isAllNum = Regex.IsMatch(str, @"^\d+$");

            if (isRightPhone)
            {
                sumphone += str + " ";
            }
            else if (isAllNum)
            {
       
                sumfalsephone += str + " ";
            }
            else
            {
     
                sumtest += str + " ";
            }
        }

        Console.WriteLine("普通文本为：" + sumtest);
        Console.WriteLine("=======");
        Console.WriteLine("正确手机号为：" + sumphone);
        Console.WriteLine("=======");
        Console.WriteLine("非法手机号为：" + sumfalsephone); 
    }
}
