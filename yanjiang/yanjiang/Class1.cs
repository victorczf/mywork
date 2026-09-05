using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    
    internal class Class1
    {
        private delegate void mydelegate();//定义一个方法模板=>委托类型
                                           //也就是说你要放进来的函数是怎么样的
                                           //(是无参数，有参数，还是有参数又有返回值)
        mydelegate panel; //根据这个模板我定义一个变量 ，在这个变量里面只能存符合我上面这个模板的函数
        public void main()
        {
            panel = sayhello;
            panel();
        }

        private void sayhello()
        {
            Console.WriteLine("hello");
        }

        private void saygoodbuy()
        {
            Console.WriteLine("goodbuy");
        }

    }
}
