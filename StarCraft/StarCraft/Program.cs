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
        
        // 유닛의 HP를 보여주는 method
        static void ShowHP(Unit u)
        {
            Console.WriteLine($"HP는 {u.getHP()} 입니다.");
        }
    }// end of class
}
