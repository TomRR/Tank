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

        private bool IstBefuellenMoeglich(int menge)
        {
            return (Volumen >= Fuellmenge + menge) ? true : false;
        }
        public bool IstEntnehmenMoeglich(int menge)
        {
            return (Fuellmenge >= menge) ? true : false;
        }

        public int Befuellen(int menge)
        {
            Fuellmenge += menge;
            Console.WriteLine("Fuellmenge Tank: {0}", Fuellmenge);
            return Fuellmenge;
        }        
        public int Entnehmen(int menge)
        {
            Fuellmenge -= menge;
            Console.WriteLine("Fuellmenge Tank: " + Fuellmenge);
            return Fuellmenge;
        }

        public void TankBefuellen()
        {
            Console.Write("Wieviel Liter moechten Sie einfuellen: ");
            int menge = Convert.ToInt32(Console.ReadLine());

            if (IstBefuellenMoeglich(menge))
                Befuellen(menge);
            else
                Console.WriteLine("Es passen nur noch {0} Liter hinein", Volumen - Fuellmenge);
        }


    }
}
