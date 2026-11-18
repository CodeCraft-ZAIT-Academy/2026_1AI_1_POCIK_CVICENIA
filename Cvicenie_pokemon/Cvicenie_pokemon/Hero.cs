using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie_pokemon
{
    public class Hero
    {
        public int HP { get; set; } = 200;
         public int DMG { get; set; } = 15;
        public int MaxHp { get; set; } = 200;
        public int Mana { get; set; } = 100;
        public int XP { get; set; } = 0;



        public void ReviveHero()
        {
            MaxHp *= 2;
            HP = MaxHp;
            DMG *= 2;
            Mana = 100;
            XP = 0;
        }

         
    }
     
}
