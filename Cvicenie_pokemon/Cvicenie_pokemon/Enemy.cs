using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie_pokemon
{
    public class Enemy
    {
        public int Health { get; set; } 
        public int Demage { get; set; } 
        public int MaxHP { get; set; }

        public Enemy(int hP, int dMG, int maxHp)
        {
            Health = hP;
            Demage = dMG;
            MaxHP = maxHp;
        }
    }

}