using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class Device
    {
        public string DeviceName { get; set; }
        public bool IsConnected { get; set; }

        public void Connect()
        {
            Console.WriteLine($"{DeviceName}连接设备");
        }
        public void Disconnect()
        {
            Console.WriteLine($"{DeviceName}断开设备");
        }

        public virtual void Start()
        {
            Console.WriteLine($"{DeviceName}设备启动---->");
        }

        //void GetInfo() // 没有书写访问修饰符, 默认就是私有的 private, 而私有的方法,子类不能使用
         protected void GetInfo() // protected 和 public 都可以在子类中访问
        {
            Console.WriteLine("父类的GetInfo方法");
        }
    }
}
