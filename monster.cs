using System;
using System.Collections.Generic;
using System.Text;

namespace CviceniaBattleSimulator
{
    public class Monster
    {
        public int Health { get; set; }
        public int Demage { get; set; }

        public Monster(int health, int demage)
        {
            Health = health;
            Demage = demage;
        }
    }
}