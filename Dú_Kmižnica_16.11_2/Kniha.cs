using System;
using System.Collections.Generic;
using System.Text;

namespace Dú_knižnica_16._11
{
    public class Kniha
    {
        public string Nazov { get; set; }
        public string Zaner { get; set; }
        public int VekovaKategoria { get; set; }

        public Kniha(string nazov, string zaner, int vekovaKategoria)
        {
            Nazov = nazov;
            Zaner = zaner;
            VekovaKategoria = vekovaKategoria;
        }
    }
}
