namespace kaoshixunhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
             int []arr = new int[10];
            int sum = 0;
            Random  ran=new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i]=ran.Next(1,50);
                 sum = arr[i] + sum;
              
            }
            double pj = sum / 10;

            foreach (int i in arr)
            {
                s = s+i.ToString() + " ";
            }
            Console.WriteLine($"改数组中的所有元素为{s}");
            Console.WriteLine($"改数组中的所有元素的平均值为："+pj);
            Console.WriteLine($"改数组中的所有元素的总和为："+sum);

        }

    }
 }

