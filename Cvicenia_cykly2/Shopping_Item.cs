using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenia_cykly2
{
    public class Shopping_Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int Pocet {  get; set; }

        public Shopping_Item(string name, double price, int pocet)
        {
            Name = name;
            Price = price;
            Pocet = pocet;
        }
        public void Info()
        {
            

        }



        public void IncreasePrice()
        {
            Price += 1.0;

        }



        public void IncreasePricePlus5()
        {
            Price += 5.0;

        }



        public void PocetKusov()
        {
            
        }

    }
}
