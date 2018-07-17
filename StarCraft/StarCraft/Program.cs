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
            int hp1 = Marine_UseSteamPack(m1, 2); 

            Marine m2 = new Marine();

            //m2 스팀팩 사용
            int hp2 = Marine_UseSteamPack(m2, 1);

            //m1의 HP를 30만큼 회복
            Heal(m1, 30);

            Marine_GetDamaged(m2, 3);
            

            //============================= Firebat Here>
            Firebat f1 = new Firebat();
            Firebat_UseSteamPack(f1, 1);
            Firebat_GetDamaged(f1, 3);

            //============================= HP 출력
            showHP(m1);
            

            Console.WriteLine("m1의 현재 HP는 "+ m1.HP+ "이고, speed는 "+ m1.speed+ "입니다.");
            Console.WriteLine("m2의 현재 HP는 " + m2.HP + "이고, speed는 "+m2.speed+ "입니다." );
            Console.WriteLine("f1의 현재 HP는 " + f1.HP + "이고, speed는 "+f1.speed+ "입니다." );

        }// end of method

        // HP출력 method
        private static void showHP(Marine m1)
        {
            //Console.WriteLine("m1의 현재 HP는 " + m1.HP + "이고, speed는 " + m1.speed + "입니다.");
            //Console.WriteLine("m1의 현재 HP는 {}이고, speed는 {}입니다.",m1.HP, m1.speed);
            Console.WriteLine($"m1의 현재 HP는 {m1.HP} 이고, speed는 {m1.speed} 입니다.");
        }

        // 공격을 당할때 (Marine)
        private static void Marine_GetDamaged(Marine m, int enemyAttack)
        {
            m.HP -= (enemyAttack * 2);
        }

        // 공격을 당할때 (Firebat)
        private static void Firebat_GetDamaged(Firebat f, int enemyAttack)
        {
            f.HP -= (enemyAttack * 3);
        }

        // 스팀팩 사용할 때(use Marine)
        static int Marine_UseSteamPack(Marine m, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Marine_UseSteamPackCore(m);
            }

            return m.HP;
        }
        // 스팀팩 사용할 때(use Firebat) 
        static int Firebat_UseSteamPack(Firebat f, int count)
        {

            for (int i = 0; i < count; i++)
            {
                Firebat_UseSteamPackCore(f);
            }

            return f.HP;
        }

        // 스팀팩 사용 코어(Marine)
        static void Marine_UseSteamPackCore(Marine m)
        {
            m.HP = m.HP - 5;
            m.speed = m.speed + 1;
        }
        // 스팀팩 사용 코어(Firebat)
        static void Firebat_UseSteamPackCore(Firebat f)
        {
            f.HP = f.HP - 5;
            f.speed = f.speed + 1;
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
