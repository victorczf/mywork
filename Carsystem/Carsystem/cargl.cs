using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Carsystem
{
    internal class cargl
    {
        //车辆管理类 定义两个属性并附上初始值，一个是序列化的
        //一个是path ，文件路径
        //自动属性（新用法） 访问修饰符 类型 属性名 { get; } = 默认值;
        private string path { get; } = "cargl.txt";//管理车辆数据放的位置
        private JsonSerializerOptions jsonopt { get; } = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            WriteIndented = true,  
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };

        public string Add(string card, string carType,double Price)
        {
            //新增车辆方法
            //如果存在==> 读取文件==> 反序列化==》用车辆类来接受
            //判断文件是否存在 如果不存在==>返回没有车辆  
            List<message> casr = new();

            if (File.Exists(path))
            {   //定义一个空的car型的list集合
                 
                string jsonstr=File.ReadAllText(path);
                casr = JsonSerializer.Deserialize <List<message>>(jsonstr);
                //接受传进来的数据
                if (casr.Exists(item => item.Card == card)) return "新增失败，车牌已存在";

            }
            message list = new message(casr.Count + 1, card, carType, true, Price);
            casr.Add(list);
            string resStr = JsonSerializer.Serialize(casr, this.jsonopt);
            File.WriteAllText(this.path, resStr);

            return "新增车辆成功！！！";
            //反序列化
             return "ok";
            
        }

        //查看全部车辆信息
        public void SearchAll() 
        {
           // List<message> casr = new();
            if (!File.Exists(path)) Console.WriteLine("没有车辆信息");
            //读文件并且反序列化
            string jsonstr = File.ReadAllText(path);
            List<message>  casr = JsonSerializer.Deserialize<List<message>>(jsonstr);

            foreach (message item in casr)
            {
                string statusStr = item.Status ? "空闲" : "已出租";
                Console.WriteLine($"id : {item.Id} -- 车牌 : {item.Card} -- 类型 : {item.Type} -- 状态 : {statusStr} -- 时租费 : {item.Price} ");

            }
           
        }


        public void Searchsg(int id)
        {
            //判断文件是否存在 如果不存在 就返回没有车辆请你先添加
            if (!File.Exists(path)) return;
            //定义一个空的list 集合的massage类型
            //List<message> json =  new List<message>();

            string jsonstr= File.ReadAllText(path);

            List<message> json = JsonSerializer.Deserialize<List<message>>(jsonstr);

            message carObj = json.Find(item => item.Id == id);
            if (carObj == null)
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            string statusStr = carObj.Status ? "空闲" : "已出租";
            Console.WriteLine($"id : {carObj.Id} -- 车牌 : {carObj.Card} -- 类型 : {carObj.Type} -- 状态 : {statusStr} -- 时租费 : {carObj.Price} ");


        }



        }

}





