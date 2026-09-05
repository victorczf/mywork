using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    internal class Class8
    {
        private Action panel;
        public void main()
        {
            panel = delegate () 
            {
             Console.WriteLine("哈哈哈");
            };
            panel();
        }
        //private void number() 
        //{
        //    Console.WriteLine("哈哈哈");
        //}

    }
}
