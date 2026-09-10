using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class SingleInstance
    {
        public bool isTool; 

        // 私有构造函数===> 外部无法实例化
        private SingleInstance() { }

        // 静态属性 Instance ===> 存储的是这个类的实例
        static private SingleInstance Instance { get; set; }

        // 静态公开方法: 外部可以访问的方法
        static public SingleInstance GetInstance()
        {
            // 在此方法中实例化此类
            
            if(Instance == null)
            {
                Instance = new SingleInstance();
            }
            return Instance;


        }
    }
}
