using System;
using System.Collections.Generic;
using System.Text;

namespace CviceniaBattleSimulator
{
    public class Hero
    {
        public int Health { get; set; }
        public int Demage { get; set; }

        public Hero(int health, int demage)
        {
            Health = health;
            Demage = demage;
        }
    }
}