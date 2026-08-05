namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insert 指定下标插入数据
            List<string> list = new List<string>()
            {"A","c","d" };
            list.Insert(1, "g");
            Console.WriteLine(list[1]);//打印的是g

            //Remove将list中指定的数据删除(比如说这里指定A)
            list.Remove("A");
            Console.WriteLine(list[0]);//这个时候打印的还是g，因为a已经被删了

            //RemoveAt 将list中指定的下标索引的数据删除
            list.RemoveAt(0);
            Console.WriteLine(list[0]);//这个时候是打印出来c

            //RemoveRange 删除数组中指定的多个数据，RemoveRange(下标, 个数) // 从下标开始删除指定个数
            list.RemoveRange(0, 1);


            //clear:清空所有数据  
            //这个时候console.WriteLine(list.count);//这个count的数值为0

            //Contains:判断List中是否包含某个数据,返回值为布尔值

            bool a = list.Contains("d");
            Console.WriteLine(a);//a为ture

            //IndexOf：查找某个数据在List中第一次出现的下标，结果找到就是下标，找不到就是-1



            //字典   



        }
    }
}
