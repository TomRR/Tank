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
            FuellstandAnzeigen();
            return Fuellmenge;
        }        
        private int MengeEntnehmen(int menge)
        {
            Fuellmenge -= menge;
            FuellstandAnzeigen();
            return Fuellmenge;
        }
        private int MengeEingeben()
        {
                return Convert.ToInt32(Console.ReadLine());         
        }
        private void FuellstandAnzeigen()
        {
            Console.WriteLine("Fuellmenge Tank: " + Fuellmenge);
        }
        public void Befuellen()
        {
            Console.Write("Wieviel Liter moechten Sie einfuellen: ");
            try
            {
                int menge = MengeEingeben();

                if (IstBefuellenMoeglich(menge))
                    MitMengeBefuellen(menge);
                else
                    Console.WriteLine("Es passen nur noch {0} Liter hinein", Volumen - Fuellmenge);
            }
            catch (FormatException)
            {
                Console.WriteLine("Bitte gebe eine Zahl ein");
            }

        }
        public void Entnehmen()
        {
            Console.Write("Wieviel Liter moechten Sie ennehmen: ");
            try
            {
                int menge = MengeEingeben();

                if (IstEntnehmenMoeglich(menge))
                    MengeEntnehmen(menge);
                else
                    Console.WriteLine("Es sind nur noch {0} Liter im Tank!", Fuellmenge);
            }
            catch (FormatException)
            {
                Console.WriteLine("Bitte gebe eine Zahl ein");
            }
        }
        public void Print()
        {
            Console.WriteLine("Tankvolumen: {0} Liter", Volumen);
            Console.WriteLine("Tankinhalt: {0} Liter", Fuellmenge);
        }


    }
}
