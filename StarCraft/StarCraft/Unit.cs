using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarCraft
{
    abstract class Unit
    {
        protected int HP = 60;
        protected int speed = 1;

        public int getHP()
        {
            return HP;
        }
        public void setHP(int hp)
        {
            HP = hp;
        }
        public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int sp)
        {
            speed = sp;
        }

        //================================
        //가상 메서드
        public virtual void GetDamaged(int enemyAttack)
        {
            HP -= (enemyAttack * 1);
        }

        // 스팀팩 사용할 때(use Firebat) 
        public int UseSteamPack(int count)
        {

            for (int i = 0; i < count; i++)
            {
                UseSteamPackCore();
            }

            return HP;
        }


        // 스팀팩 사용 코어(Firebat)
        private void UseSteamPackCore()
        {
            HP = HP - 5;
            speed = speed + 1;
        }

        // Heal
        public void Heal(int hpToAdd)
        {
            HP += hpToAdd;
            return;
        }



    }
}
