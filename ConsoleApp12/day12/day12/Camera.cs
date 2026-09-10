using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace day12
{
    internal class Camera : Device
    {

        public void CaptureImage()
        {
            Console.WriteLine($"{DeviceName}拍照功能");
        }
    }
}


//namespace day12
//{
//    internal class Camera
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

//        public void CaptureImage() {
//            Console.WriteLine("拍照功能");
//        }
//    }
//}
