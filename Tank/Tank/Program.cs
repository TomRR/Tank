using System;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiter;
            Tank einTank = new Tank(1000, 200);

            einTank.Print();

            do
            {      
                   weiter = Menu(einTank);
            }
            while (weiter);
            PrintUmlDarstellung(einTank);
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
        private static void PrintUmlDarstellung(Tank tank)
        {
            Console.Write("\n\t __________________________________" +
                          "\n\t|          einTank: Tank           |" +
                          "\n\t|__________________________________|" +
                          "\n\t|+ Volumen: {0}                   |" +
                          "\n\t|+ Fuellmenge: {1}                 |"  +
                          "\n\t|__________________________________|" +
                          "\n\t|- IstBefuellenMoeglich(menge: int)|" +
                          "\n\t|- IstEntnehmenMoeglich(menge: int)|" +
                          "\n\t|- MitMengeBefuellen(menge: int)   |" +
                          "\n\t|- MengeEntnehmen(menge: int)      |" +
                          "\n\t|- MengeEingeben()                 |" +
                          "\n\t|- FuellstandAnzeigen()            |" +
                          "\n\t|+ Befuellen()                     |" +
                          "\n\t|+ Entnehmen()                     |" +
                          "\n\t|+ Print()                         |" +
                          "\n\t ----------------------------------", tank.Volumen, tank.Fuellmenge
                          );
        }

    }
}
