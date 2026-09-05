using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{

    internal class Class7
    {
        private Action<int> panel;
        private Func<int, int> panel2;
        public void main()
        {
            panel = number;
            panel(5);
        
        }

        private void number(int a)
        {
            Console.WriteLine(a);
        }

        private int number2(int b)
        {
            return (b+1);
        }

    }
}
