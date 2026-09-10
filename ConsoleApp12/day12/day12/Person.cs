using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day12
{
    public class Person
    {
        // 访问修饰符
        // public : 公开的,哪里都可以访问到
        // protected: 受保护的, 只有类内部可以访问,外部无法访问
        // private: 私有的,只有类内部可以访问,外部无法访问 (不给修饰符默认就是私有的)
        // internal: 内部的,只有当前项目可以访问, 其他项目不能访问(在当前项目中和public一样的)
        // static: 静态的,修饰的属性或方法是 属于类本身, 实例对象不能访问,只有类本身才行
        public string Name { get; set; }
        public int Id { get; }
        protected int Age { get; } // 此出的Age是只有get(只读属性); 但是在构造函数中可以设置初始值
        private double Salary { get; set; }
        internal bool IsMan { get; set; }
        static bool IsLive { get; set; } // 静态属性  bool 默认值false
        static public void GetInfoStatic(Person p)
        {
            //IsLive = true; // 静态方法中直接访问静态属性
            Console.WriteLine(IsLive);

            //Console.WriteLine(IsMan);// 不能直接访问非静态属性
            //因为非静态属性是 属于实例对象的,要访问必须 使用 实例对象.属性
            Console.WriteLine(p.IsMan);

        }
        // 类内的方法中 访问属性
        public void GetInfo(bool IsLive)
        {

            //Age = 28;//  Age 是只读属性,不能赋值(除非是构造函数)
            //Console.WriteLine($"名字: {Name}--年龄:{Age}---薪水:{Salary}--男人: {IsMan}--活着:{IsLive}");
            Console.WriteLine($"名字: {Name}--年龄:{Age}---薪水:{Salary}--男人: {IsMan}--活着:{Person.IsLive}");
            //Console.WriteLine(IsLive);// 普通方法中可以直接访问静态属性
            //Console.WriteLine(Person.IsLive); // false
            // 如果 属性和方法中的参数同名了,那么可以使用类名.静态属性 的方式访问

        }

        // 自定义构造函数: 不能有返回值(不能写返回值类型) public 修改构造函数 (实例构造函数)
        public Person(string name, int age, double salary, bool isman, bool islive)
        {
            Console.WriteLine("实例构造函数---");
            // 在类内部-->构造函数中初始化 属性值
            Name = name;
            Age = age;
            Salary = salary;
            IsMan = isman;
            Person.IsLive = islive;
        }

        // 静态构造函数: 不能有参数
        static Person()
        {
            Console.WriteLine("静态构造函数====");
            //p.Name = "lssss"; // 静态方法中不能直接访问 非静态属性
            IsLive = false;
        }


        // 多态: 方法重载
        public void Say()
        {
            Console.WriteLine("巴拉巴拉巴拉巴拉巴拉.....小魔仙");
        }
        public void Say(string content)
        {
            Console.WriteLine($"嘚吧嘚吧嘚吧嘚吧嘚吧嘚吧.....{content}");
        }

        public void Say(string start,string end)
        {
            Console.WriteLine($"{start}**********************.....{end}");
        }

    }
}
