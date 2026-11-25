using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

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

        public void Revive()
        {
            MaxHP *= 2;
            Health = MaxHP;
            Demage *= 2;
            
        }


    }

}