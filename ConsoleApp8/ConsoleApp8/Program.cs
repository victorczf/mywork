
using System;
using System.Collections.Generic;
namespace ConsoleApp8
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //定义函数的三种类型

            //第一种定义(不带返回值和类型)
            //var add = () =>
            //{
            //    Console.WriteLine("王明宇");
            //};

            //带参数+带返回值时：
            //var add = (int a, int b) =>
            //{   
            //    return a + b;
            //};
            //int c =add(1,2);
            //Console.WriteLine(c);

            //第二种类型：
            //int add(int a,int b)
            //{
            //    return a + b;
            //};
            //int c =add(1,2);
            //Console.WriteLine(c);

            //第三种类型,没有返回值,跟第一种类型一样，不同的就是action修饰后没有返回值
            //Action add = () => 
            //{
            //};

            //// 要有返回值
            //Func<int, string> fun1 = (int num) =>
            //{
            //    return num.ToString();
            //};


            //圆的面积计算   r

            /*double mondy = 0;

            double jisuan(double r) { 

            double s = r * r * Math.PI;
            double zong = s * 200 / 2;
            return zong;

            }
            Console.WriteLine("请输入圆的半径");
            double r =double.Parse(Console.ReadLine());
            double res = jisuan(r);
            Console.WriteLine(res);*/


            /*   string str = "qwerysssssqqqqwwweee";
               int count = 0;
               int fn (string a,char b)
               {
                   for (int i = 0; i < str.Length; i++)
                   {

                       if ( b == str[i])
                         {

                           count++;

                           }

                    }
                   return count;

               }
               int res=fn(str,'s');
               Console.WriteLine( "出现的次数是："+res );*/



            /*  int[] arr = [10, 20, 5, 30, 50, 6, 7];
              //            0   1  2   3   4  5  6
              int count = 0;
              foreach (int shuzi in arr)
              {
                  for (int i = 0; i < arr.Length;i++)
                  {
                      if (arr[i] < shuzi)
                      {
                           count++;
                      }

                  }


              }*/


            //int[] arr = [10, 20, 5, 30, 50, 6, 7];
            //int min = 0;

            ////外层for，可以拿到当前下标j
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    int shuzi = arr[j];
            //    int count = 0; //每一轮重新置0
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < shuzi)
            //        {
            //            count++;
            //        }
            //    }
            //    //count等于0，代表没有数字比它更小，就是最小值
            //    if (count == 0)
            //    {
            //        min = j;
            //        break; //第一次找到，直接跳出，保证第一次出现
            //    }
            //}
            //Console.WriteLine(min);



            /*
                        //简洁
                        int[] arr = [10, 20, 5, 30, 50, 6, 7];
                        int min = arr[0];
                        int minIdx = 0;
                        for (int i = 1; i < arr.Length; i++)
                        {
                            if (arr[i] < min)
                            {
                                min = arr[i];
                                minIdx = i;
                            }
                        }
                        Console.WriteLine(minIdx);

                        /*
                         * 
                        //思路
                        //先拿出每一个数
                        //跟全部数对比一遍，如果出现有比他更小的数，跳过本次循环，然后没有比他更小的数，则结束并输出此下标




                            先对比出来最小值
                            下标1和下标2比，最小的就拿出来

                            先拿出第一个下标的值
                            int min=arr[0];
                            if(arr[i]<min)
                                {
                                     min = arr[i];
                                }
                             //else{    min=  }

                         }
                         */




            //string s = "abcdcba";
            //// 1.字符串转字符数组
            //bool hanshu (string s) { 
            //char[] chs = s.ToCharArray();

            //    Console.WriteLine( chs);

            //// 2.反转数组
            //Array.Reverse(chs);

            ////3.数组转回字符串
            //string res = new string(chs);

            //    if (res == s)
            //    {
            //        return true;
            //    }
            //    else
            //    return false;

            //                        }

            //bool res =hanshu(s);
            //Console.WriteLine(res);

            //新建一个词典，并且遍历他
            //Dictionary<string, dynamic> list = new()
            //{
            //    ["name"] = "陈志锋",
            //    ["age"] = 21,
            //    ["gender"] = "nan"
            //};
            ////用foreash遍历他
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine( item);

            ////}

            ////用for循环遍历
            //for (int i = 0; i < list.Count; i++)
            //    {
            //    Console.WriteLine(list["i"]);    

            //    }

            //   Dictionary 不支持下标数字索引，不能像数组那样 list[i]。

            Dictionary<string, dynamic> dic = new()
            {
                ["name"] = "陈志锋",
                ["age"] = 21,
                ["gender"] = "nan"
            };
             
            //①先把所有key提取出来转List，才能用i拿第i个键
            var keyList = dic.Keys.ToList();

            //②for循环遍历序号i
            for (int i = 0; i < dic.Count; i++)
            {
                string key = keyList[i];    //先拿第i个键
                var value = dic[key];       //再用键去字典拿值
                Console.WriteLine($"键：{key}，值：{value}");
            }




        }
    }
}
