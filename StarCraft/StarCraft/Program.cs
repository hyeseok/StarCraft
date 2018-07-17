using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine m1 = new Marine();

            //m1 스팀팩 사용
            m1.HP = m1.HP - 5;
            m1.speed = m1.speed + 1;

            Marine m2 = new Marine();

            //m2 스팀팩 사용
            m2.HP = m2.HP - 5;
            m2.speed = m2.speed + 1;

            //m1 스팀팩 사용
            m1.HP = m1.HP - 5;
            m1.speed = m1.speed + 1;

        }// end of method
    }// end of class
}
