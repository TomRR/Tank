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
        private bool IstEntnehmenMoeglich(int menge)
        {
            return (Fuellmenge >= menge) ? true : false;
        }

        private int MitMengeBefuellen(int menge)
        {
            Fuellmenge += menge;
            Console.WriteLine("Fuellmenge Tank: {0}", Fuellmenge);
            return Fuellmenge;
        }        
        private int MengeEntnehmen(int menge)
        {
            Fuellmenge -= menge;
            Console.WriteLine("Fuellmenge Tank: " + Fuellmenge);
            return Fuellmenge;
        }

        public void Befuellen()
        {
            Console.Write("Wieviel Liter moechten Sie einfuellen: ");
            int menge = MengeEingeben();

            if (IstBefuellenMoeglich(menge))
                MitMengeBefuellen(menge);
            else
                Console.WriteLine("Es passen nur noch {0} Liter hinein", Volumen - Fuellmenge);
        }        
        public void Entnehmen()
        {
            Console.Write("Wieviel Liter moechten Sie ennehmen: ");
            int menge = MengeEingeben();

            if (IstEntnehmenMoeglich(menge))
                MengeEntnehmen(menge);
            else
                Console.WriteLine("Es sind nur noch {0} Liter im Tank!", Fuellmenge);
        }

        private int MengeEingeben()
        {
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
