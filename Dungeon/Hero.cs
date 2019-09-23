using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    class Hero
    {
        public int Level;
        public int Attack;
        public int HP;
        public int XP;

        public void GainXP(int expGiven)
        {
            this.XP += expGiven;
            if (this.XP > this.Level * 10)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            this.Level++;
            //randomly increase attack and hp
            this.XP = 0;
        }

        public bool IsAlive()
        {
            if (this.HP > 0)
            {
                return true;
            }
            return false;
        }
    }
}
