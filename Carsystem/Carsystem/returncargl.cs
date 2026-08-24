using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Carsystem
{
    internal class returncargl
    {
        private string path { get; } = "cargl.txt";//管理车辆数据放的位置
        private JsonSerializerOptions jsonopt { get; } = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        public string Recar() 
        {
            //输入车辆id 和客户ai：要租的车和你是谁
            Console.WriteLine("输出客户id");
            int userid = int.Parse(Console.ReadLine());
            Console.WriteLine("输出车辆id");
            int srcarid = int.Parse(Console.ReadLine());



        }


    }
}
