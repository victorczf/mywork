using System.Numerics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            int sum = 0;
            while (i <= 10) 
            {
                sum = sum + i;
                i++;
            
            }
            Console.WriteLine($"总和={sum},i={i}");*/


            /*double sum = 0;
            double mondy = 10;
            int year = 1;
            while (year<=50)
            {
                mondy *= 1.05;
                year++;
                sum += mondy;
            }
            sum *= 12;
            Console.WriteLine(mondy+"总额是"+sum);*/

            /*List<string> list = new List<string>()
            {
                "aa",
                "bb",
                "cc",
                "dd",
                "ee"
            };
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine(list[i]);
            }*/


            /*List<int> list = new List<int>() 
            {
                1,2,3,4,5,6,7,8
            };

            int sum = 0;
            for (int i= 0; i < list.Count; i++)
            {

                sum=sum+list[i];

            }

            Console.WriteLine("元素之和为"+sum);
            */





            //  作业一
            /*int i = 2;
           int  sum = 0;
            while (i <= 100)
            { 
                sum=sum+i;
                i = i + 2;
                Console.WriteLine($"此时i={i}，sum={sum}");
            }
            Console.WriteLine($"一百以内的偶数和{sum}");*/


            //作业二
            /*第一行是9个*  第二行一共是8个*/

            /*for (int i = 9; i>=1; i--)
             {
                 for(int j = 1; j < i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine(" ");

             }*/

            //作业四
            /*double num = 0;
             double sum = 0;

             for (int fenmu = 1; fenmu <= 100; fenmu++)
             {

                 if (fenmu % 2 != 0)
                 {
                     num = 1.0 / fenmu;

                     sum = num + sum;
                     Console.WriteLine("此时sum="+sum);
                 }
                 else 
                 {
                     num = 1.0 / fenmu;

                     sum = sum - num;
                 }

             }
             Console.WriteLine(sum);
            */

            //第五题
            double sum = 0;
            double fact = 1;
            for (int i = 1; i <= 10; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }

            /* fact = 1*1=1
               sum= 0+1=1

                fact =1*2=2
                sum= 1+2

            fact =2*3=6
            sum=1+2+6

            */
            Console.WriteLine(sum);


            //1.5  0.45  0.135
            //第六题
            /*int n = 0;
             for(double heighe = 5;heighe>=0.1;)
             {
                 heighe *= 0.3;
                 n++;
             }

             Console.WriteLine(n);
            */

            //第七题：

             double weight =0.00001;
             double sum1 =0;
             double shuliang =0;

             for (double geshu = 0; geshu < 64; geshu++)
             {
                 shuliang += Math.Pow(2, geshu);
             }
             sum1 = weight * shuliang;
             Console.WriteLine("全部格子的重量为："+sum1);


            //第八题


            // double mondy = 50000;

            /* int n = 0;
             for (double mondy = 50000; mondy > 5000;)
             {
                 mondy *= 0.95;
                 n++;
                 Console.WriteLine("第"+n+"次扣取所剩的钱:" + mondy);

             }
             Console.WriteLine("这个人的手续费一共扣了"+n+"次");
            */

            //第九题

            /*int t = 1; //第7天吃之前的桃子
            for (int i = 0; i < 6; i++)
            {
                t = (t + 1) * 2;
            }
            Console.WriteLine("猴子一共摘的桃子数"+t); 
            */

            //第十题
            /* double height = 10;
             double s = 0;
             //第一落地弹起经过的距离

             for (int i = 1; i <= 10; i++)
             {

                 //  s = (height + height / 2);
                 //第二次落地弹起经过的距离
                 //目前高度 height=height / 2；

                 s = s + (height + height / 2);
                 height = height / 2;
                 Console.WriteLine("第" + i + "次弹起所经过的距离是" + s + "目前的高度是" + height);

             }
             Console.WriteLine("皮球总共经过的距离为：" + s );*/

        }
    }
}
