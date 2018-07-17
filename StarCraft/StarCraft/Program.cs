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
            int hp1 = UseSteamPack(m1, 2); 

            Marine m2 = new Marine();

            //m2 스팀팩 사용
            int hp2 = UseSteamPack(m2, 1);

            //m1의 HP를 30만큼 회복
            Heal(m1, 30);

            GetDamaged(m2, 3);

            Console.WriteLine("m1의 현재 HP는 "+ m1.HP+ "이고, speed는 "+ m1.speed+ "입니다.");
            Console.WriteLine("m2의 현재 HP는 " + m2.HP + "이고, speed는 "+m2.speed+ "입니다." );

        }// end of method

        // 공격을 당할때
        private static void GetDamaged(Marine m, int enemyAttack)
        {
            m.HP -= (enemyAttack * 2);
        }

        // 스팀팩 사용할 때
        static int UseSteamPack(Marine m, int count)
        {

            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore(m);
            }

            return m.HP;
        }

        // 스팀팩 사용 코어
        static void UseSteamPackCore(Marine m)
        {
            m.HP = m.HP - 5;
            m.speed = m.speed + 1;
        }

        // Heal
        static void Heal(Marine m, int hpToAdd)
        {
            m.HP += hpToAdd;
            return;
        }


        //static int UseSteamPack(Marine m, int count)
        //{

        //    for(int i=0; i<count; i++)
        //    {
        //        m.HP = m.HP - 5;
        //        m.speed = m.speed + 1;
        //    }

        //    return m.HP;
        //} 

    }// end of class
}
