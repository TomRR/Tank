using System;
using System.Collections.Generic;
using System.Text;

namespace Tank
{
    class Tank
    {
        public Tank(int volumen, int fuellMenge)
        {
            Volumen = volumen;
            Fuellmenge = fuellMenge;
        }

        public int Volumen { get; set; }
        public int Fuellmenge { get; set; }

        public bool istBefuellenMoeglich(int menge)
        {
            return (Volumen >= Fuellmenge + menge) ? true : false;
        }
        public bool istEntnehmenMoeglich(int menge)
        {
            return (Fuellmenge >= menge) ? true : false;
        }

        public int Befuellen(int menge)
        {
            return Fuellmenge + menge;
        }


    }
}
