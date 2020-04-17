using System;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Wichtige Hinweise:
             * 
             * - Der Fuellstand eines Tanks kann nur ueber die 
             *   entsprechenden Methoden geaendert werden.
             *   
             * - Der Inhalt eines Tanks darf sich nur aendern,
             *   wenn beim Befuellen die Menge noch hineinpasst,
             *   bzw. beim Entnehmen noch verfuegbar ist.
             */

            int menge;
            char auswahl = 'x';

            Tank einTank = new Tank(1000, 200);

            Console.WriteLine("Tankvolumen: {0} Liter", einTank.Volumen);
            Console.WriteLine("Tankinhalt: {0} Liter", einTank.Fuellmenge);

            do
            {
                Console.Write("\nWas moechten Sie tun: \n\tBefuellen (b)\n\tEntnehmen (e) \n\tBeenden (x)\n\t-->");
                auswahl = Convert.ToChar(Console.ReadLine());

                switch (auswahl)
                {
                    case 'b':
                        einTank.Befuellen();
                        break;

                    case 'e':
                        einTank.Entnehmen();
                        break;
                }
            }
            while (auswahl != 'x');
        }
    }
}
