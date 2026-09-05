using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    
    internal class Class6
    {
       // private Action panel;
        private delegate void mydelegate();
        mydelegate panel; 
        public void main()
        {
            panel += sayhello;
            panel += saygoodbuy;

            panel();

            //panel -= sayhello;
            //panel -= saygoodbuy;
            //panel();

            //if (panel != null)
            //{
            //    panel();
            //}

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
