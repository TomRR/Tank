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



            bool weiter;
            Tank einTank = new Tank(1000, 200);

            einTank.Print();

            do
            {      

                   weiter = Menu(einTank);


            }
            while (weiter);
        }
        private static bool Menu(Tank tank)
        {
            Console.Write("\nWas moechten Sie tun: \n\tTanker Eigenschaften (p)\n\tBefuellen (b)\n\tEntnehmen (e) \n\tBeenden (x)\n\t-->");
            try { char auswahl = Convert.ToChar(Console.ReadLine());
                if (auswahl == 'p' || auswahl == 'b' || auswahl == 'e')
                {
                    switch (auswahl)
                    {
                        case 'p':
                            tank.Print();
                            break;
                        case 'b':
                            tank.Befuellen();
                            break;

                        case 'e':
                            tank.Entnehmen();
                            break;
                    }
                    return true;
                }
                if (auswahl == 'x')
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Gebe einen Richtigen Wert ein");
                    return true;
                }
            } catch (FormatException) { Console.WriteLine("Gebe einen Richtigen Wert ein");  return true; };
          
        }

    }
}
