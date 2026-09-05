using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    //
    internal class Class2
    {

        private delegate void mydelegate(int a,int b);

        //private delegate int mydelegate(int a, int b);
        mydelegate panel; //定义一个变量
        public void main()
        {

            panel = Add;
            panel(2,3);


           //int res = panel(2, 3);
           // Console.WriteLine(res);
                
        }

        private void Add(int b, int c)
        {

            Console.WriteLine(b + c);

        }

        //private int Add(int a,int b)
        //{

        //    return a + b;

        //}



    }
}
