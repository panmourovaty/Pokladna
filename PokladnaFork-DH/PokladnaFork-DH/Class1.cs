using System;
using System.Collections.Generic;
using System.Text;

namespace PokladnaFork_DH
{
    class PoklZaznam
    {
        public int IdPokladniZaznam { get; set; }
        public int Cislo { get; set; }
        public DateTime Datum { get; set; }
        public string Popis { get; set; }
    }
}
