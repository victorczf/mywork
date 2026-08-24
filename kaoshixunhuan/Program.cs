namespace kaoshixunhuan
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 51); 
            }
  
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            double avg = sum / 10.0;

            Console.WriteLine("数组元素：");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"总和：{sum}");
            Console.WriteLine($"平均值：{avg}");
        }

    }
 }

