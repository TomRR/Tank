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


            char auswahl = 'x';
            Tank einTank = new Tank(1000, 200);

            einTank.Print();

            do
            {      
                while(true)
                try
                {
                    Menu(einTank);

                }
                catch (FormatException) { if (true) { Console.WriteLine("Bitte ebe einen der angegebenen Buchstaben ein, um eine Vorgang durchzufuehren"); } else throw; }

            }
            while (auswahl != 'x');
        }
        private static void Menu(Tank tank)
        {
            Console.Write("\nWas moechten Sie tun: \n\tTanker Eigenschaften (p)\n\tBefuellen (b)\n\tEntnehmen (e) \n\tBeenden (x)\n\t-->");
            char auswahl = Convert.ToChar(Console.ReadLine());

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
        }

    }
}
