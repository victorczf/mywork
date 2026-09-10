using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class Animal
    {
        // 定义类中的属性 {get;set;}  代表这个属性是否可以访问(get)及赋值(set)
        public string Name { get; set; }
        //public string LegCount { set; } //报错:  属性的不能只设置set而不添加访问get
        public string Description { get; }
        // 类中定义方法
        public void Run()
        {
            // 可以在类中 直接访问属性
            Console.WriteLine($"名字:{Name},跑起来,描述:{Description}");
        }
    }
}
