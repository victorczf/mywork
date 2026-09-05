using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiang
{
    internal class Class4
    {
        public void main()
        {
            Skill1();
            Skill2();
            Skill3();
            
        }

        private void Skill1()
        {
            //如果说这是一个攻击的技能
            xiaohaoMP();  // 模拟消耗MP
            shengyin(); // 模拟播放特效

            shanghai();   // 计算伤害
        }
        private void Skill2()
        {
            //如果说这是一个回血的技能
            xiaohaoMP();  // 模拟消耗MP
            shengyin(); // 模拟播放特效

            huixue();// 回血
        }
        private void Skill3()
        {
            //如果说这是一个攻击的技能
            xiaohaoMP();  // 模拟消耗MP
            shengyin(); // 模拟播放特效

            chuansong();   // 传送
        }
        private void xiaohaoMP() => Console.WriteLine("消耗MP");

        private void shengyin() => Console.WriteLine("播放特效");

        private void shanghai() => Console.WriteLine("计算伤害");

        private void huixue() => Console.WriteLine("回血");
        private void chuansong() => Console.WriteLine("传送");




    }
}
