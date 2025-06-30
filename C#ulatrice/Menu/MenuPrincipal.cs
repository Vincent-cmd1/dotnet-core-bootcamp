using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ulatrice.Menu
{
    internal class MenuPrincipal
    {
        public static void AfficherMenu()
        {
            Console.Clear();
            Console.WriteLine(new string('*', 42));
            Console.WriteLine(""" DISPLAY "*     Choisir l'operation   *". """);
            Console.WriteLine(""" DISPLAY "*---------------------------*". """);
            Console.WriteLine(""" DISPLAY "* 1 - Addition              *". """);
            Console.WriteLine(""" DISPLAY "* 2 - Soustraction          *". """);
            Console.WriteLine(""" DISPLAY "* 3 - Multiplication        *". """);
            Console.WriteLine(""" DISPLAY "* 4 - Division              *". """);
            Console.WriteLine(""" DISPLAY "* 5 - Puissance             *". """);
            Console.WriteLine(""" DISPLAY "* 6 - Réinitialisation      *". """);
            Console.WriteLine(""" DISPLAY "* 0 - Quitter le programme  *". """);
            Console.WriteLine(new string('*', 42));
        }
    }
}




