using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    //public class PLC:Device // 报错: 父类的访问权限 要别子类的更广
    internal class PLC: Device
    {
        public void ReadRegister()
        {
            Console.WriteLine($"{DeviceName}读取PLC寄存器");
            GetInfo(); 
        }
        public override void Start()
        {
            Console.WriteLine($"{DeviceName}先检测信号,然后设备启动---->");
        }

    }
}
