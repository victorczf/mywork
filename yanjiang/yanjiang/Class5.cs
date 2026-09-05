using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    
    internal class Class5
    {
        private delegate void mydelegate();
        //mydelegate panel;

        public void main()
        {
            Skill(shanghai);
                                                            // Console.WriteLine("======");
            Skill(huixue);
                                                            // Console.WriteLine("======");
            Skill(chuansong);
        }
        private void Skill(mydelegate panel)
        {
            //如果说这是一个攻击的技能
            xiaohaoMP();  // 模拟消耗MP
            shengyin(); // 模拟播放特效

            panel();   // 计算伤害
        }


        private void xiaohaoMP() => Console.WriteLine("消耗MP");

        private void shengyin() => Console.WriteLine("播放特效");

        private void shanghai() => Console.WriteLine("计算伤害");

        private void huixue() => Console.WriteLine("回血");
        private void chuansong() => Console.WriteLine("传送");

    }
}
