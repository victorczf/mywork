using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class MotionController : Device
    {

        public void MoveAxis()
        {
            Console.WriteLine($"{DeviceName}控制轴运动");
        }
    }
}







//namespace day12
//{
//    internal class MotionController
//    {
//        public string DeviceName { get; set; }
//        public bool IsConnected { get; set; }

//        public void Connect()
//        {
//            Console.WriteLine("连接设备");
//        }
//        public void Disconnect()
//        {
//            Console.WriteLine("断开设备");
//        }

//        public void MoveAxis()
//        {
//            Console.WriteLine("控制轴运动");
//        }
//    }
//}
