using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie_pokemon
{
    internal class Enemy
    {
        public int HP { get; set; } 
        public int DMG { get; set; } 
        public int MaxHp { get; set; }

        public Enemy(int hP, int dMG, int maxHp)
        {
            HP = hP;
            DMG = dMG;
            MaxHp = maxHp;
        }
    }

}