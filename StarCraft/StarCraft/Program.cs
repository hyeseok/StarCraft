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
            //Marine m1 = new Marine();

            ////m1 스팀팩 사용
            //int hp1 = m1.UseSteamPack(2); 

            //Marine m2 = new Marine();

            ////m2 스팀팩 사용
            //int hp2 = m2.UseSteamPack(1);

            ////m1의 HP를 30만큼 회복
            //m1.Heal(30);

            //m2.GetDamaged(3);
            

            ////============================= Firebat Here>
            //Firebat f1 = new Firebat();
            //f1.UseSteamPack(1);
            //f1.GetDamaged(3);

            //Console.WriteLine("m1의 현재 HP는 "+ m1.getHP()+ "이고, speed는 " + m1.getSpeed() + "입니다.");
            //Console.WriteLine("m2의 현재 HP는 " + m2.getHP() + "이고, speed는 "+ m2.getSpeed() + "입니다." );
            //Console.WriteLine("f1의 현재 HP는 " + f1.getHP() + "이고, speed는 "+ f1.getSpeed() + "입니다." );

            //ShowHP(m1);
            //ShowHP(m2);
            //ShowHP(f1);
            //=====================================================

            Unit m3 = new Marine();
            Unit f3 = new Firebat();

            Unit[] units = new Unit[2];
            units[0] = m3;
            units[1] = f3;

            for (int i = 0; i < units.Length; i++)
            {
                units[i].GetDamaged(2);
            }

            for (int i = 0; i < units.Length; i++)
            {
                ShowHP(units[i]);
            }

            
        }// end of method

        static void ShowHP(Unit u)
        {
            Console.WriteLine($"HP는 {u.getHP()} 입니다.");
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
