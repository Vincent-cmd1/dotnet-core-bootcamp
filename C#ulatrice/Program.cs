using C_ulatrice.Menu;

namespace C_ulatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wschoix = 0;
            double resultat = 0;
            string wsstop = string.Empty;

            do
            {
                string input1 = String.Empty;
                string input2 = String.Empty;
                MenuPrincipal.AfficherMenu();

                // Verification
                string? wsinput = Console.ReadLine();
                if (!int.TryParse(wsinput, out wschoix))
                {
                    Console.Clear();
                    Console.WriteLine("Saisie invalide. Veuillez entrer un nombre.");
                    wschoix = -1;
                    continue;
                }

                Console.Clear();

                
                switch (wschoix) // Menu des différents choix
                {
                    case 0: // Menu Quitter
                        bool quitter = false;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("Pour quitter, merci d'approuver le message suivant : ");
                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine("Je reconnais la superiorité du COBOL face au C# \n(OUI/NON)");
                            Console.WriteLine(new string('*', 42));
                            Console.Write("Votre choix : ");
                            wsstop = Console.ReadLine() ?? string.Empty;

                            if (string.IsNullOrEmpty(wsstop) || wsstop.ToLower() != "oui")
                            {
                                Console.Write("Mauvais choix. Vous n'êtes pas encore prêt à partir...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Bonne réponse !");
                                Console.ReadKey();
                                quitter = true;
                            }
                        } while (!quitter);

                        break;

                    case 1: // Menu Addition
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("*                                        *");
                            Console.WriteLine("*              Menu Addition             *");
                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine("*     Tapez 'R' pour revenir au menu     *");
                            Console.WriteLine("*                                        *");
                            Console.WriteLine(new string('*', 42));

                            double nombre1;
                            if (resultat == 0)
                            {
                                Console.Write("Entrez un premier nombre : ");
                                input1 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                                if (input1 == "M")
                                    break;

                                if (!double.TryParse(input1, out nombre1))
                                {
                                    Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                nombre1 = resultat;
                                Console.WriteLine($"Nombre en mémoire : {resultat}");
                            }

                            Console.Write("Entrez un second nombre : ");
                            input2 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (input2 == "M")
                                break;

                            if (double.TryParse(input2, out double nombre2))
                            {
                                resultat = nombre1 + nombre2;
                                Console.WriteLine($"\nRésultat : {nombre1} + {nombre2} = {resultat}");
                            }
                            else
                            {
                                Console.WriteLine("\nEntrée invalide. Veuillez entrer des nombres valides.");
                            }

                            Console.WriteLine("\nAppuyez sur une touche pour continuer l'addition ou taper 'M' pour revenir au menu.");
                            Console.ReadKey();
                        } 
                        while(input1 != "m" || input2 != "m");
                        break;

                    case 2: // Menu Soustraction
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("*                                        *");
                            Console.WriteLine("*           Menu Soustraction            *");
                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine("*     Tapez 'R' pour revenir au menu     *");
                            Console.WriteLine("*                                        *");
                            Console.WriteLine(new string('*', 42));

                            double nombre1;
                            if (resultat == 0)
                            {
                                Console.Write("Entrez un premier nombre : ");
                                input1 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                                if (input1 == "M")
                                    break;

                                if (!double.TryParse(input1, out nombre1))
                                {
                                    Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                nombre1 = resultat;
                                Console.WriteLine($"Nombre en mémoire : {resultat}");
                            }

                            Console.Write("Entrez un second nombre : ");
                            input2 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (input2 == "M")
                                break;

                            if (double.TryParse(input2, out double nombre2))
                            {
                                resultat = nombre1 - nombre2;
                                Console.WriteLine($"\nRésultat : {nombre1} - {nombre2} = {resultat}");
                            }
                            else
                            {
                                Console.WriteLine("\nEntrée invalide. Veuillez entrer des nombres valides.");
                            }

                            Console.WriteLine("\nAppuyez sur une touche pour continuer la soustraction ou taper 'M' pour revenir au menu.");
                            Console.ReadKey();
                        }
                        while (input1 != "m" || input2 != "m");
                        break;

                    case 3: // Menu Multiplication
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("*                                        *");
                            Console.WriteLine("*           Menu Multiplication          *");
                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine("*     Tapez 'R' pour revenir au menu     *");
                            Console.WriteLine("*                                        *");
                            Console.WriteLine(new string('*', 42));

                            double nombre1;
                            if (resultat == 0)
                            {
                                Console.Write("Entrez un premier nombre : ");
                                input1 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                                if (input1 == "M")
                                    break;

                                if (!double.TryParse(input1, out nombre1))
                                {
                                    Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                nombre1 = resultat;
                                Console.WriteLine($"Nombre en mémoire : {resultat}");
                            }

                            Console.Write("Entrez un second nombre : ");
                            input2 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (input2 == "M")
                                break;

                            if (double.TryParse(input2, out double nombre2))
                            {
                                resultat = nombre1 * nombre2;
                                Console.WriteLine($"\nRésultat : {nombre1} x {nombre2} = {resultat}");
                            }
                            else
                            {
                                Console.WriteLine("\nEntrée invalide. Veuillez entrer des nombres valides.");
                            }

                            Console.WriteLine("\nAppuyez sur une touche pour continuer la division ou taper 'M' pour revenir au menu.");
                            Console.ReadKey();
                        }
                        while (input1 != "m" || input2 != "m");
                        break;

                    case 4: // Menu Division
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 50));
                            Console.WriteLine("*                                        *");
                            Console.WriteLine("*            Menu Division               *");
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("*     Tapez 'R' pour revenir au menu     *");
                            Console.WriteLine("*                                        *");
                            Console.WriteLine(new string('*', 50));

                            double nombre1;
                            if (resultat == 0)
                            {
                                Console.Write("Entrez un premier nombre : ");
                                input1 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                                if (input1 == "M")
                                    break;

                                if (!double.TryParse(input1, out nombre1) || nombre1 == 0)
                                {
                                    Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                nombre1 = resultat;
                                Console.WriteLine($"Nombre en mémoire : {resultat}");
                            }

                            Console.Write("Entrez un second nombre : ");
                            input2 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (input2 == "M")
                                break;

                            if (double.TryParse(input2, out double nombre2) && nombre2 != 0)
                            {
                                resultat = nombre1 / nombre2;
                                Console.WriteLine($"\nRésultat : {nombre1} / {nombre2} = {resultat}");
                            }
                            else
                            {
                                Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                            }

                            Console.WriteLine("\nAppuyez sur une touche pour continuer la division ou taper 'M' pour revenir au menu.");
                            Console.ReadKey();
                        }
                        while (input1 != "m" || input2 != "m");
                        break;

                    case 5: // Menu Puissance
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("*                                        *");
                            Console.WriteLine("*            Menu Puissance              *");
                            Console.WriteLine(new string('-', 42));
                            Console.WriteLine("*     Tapez 'R' pour revenir au menu     *");
                            Console.WriteLine("*                                        *");
                            Console.WriteLine(new string('*', 42));

                            double nombre1;
                            if (resultat == 0)
                            {
                                Console.Write("Entrez un premier nombre : ");
                                input1 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                                if (input1 == "M")
                                    break;

                                if (!double.TryParse(input1, out nombre1) || nombre1 == 0)
                                {
                                    Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            else
                            {
                                nombre1 = resultat;
                                Console.WriteLine($"Nombre en mémoire : {resultat}");
                            }

                            Console.Write("Entrez la puissance : ");
                            input2 = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (input2 == "M")
                                break;

                            if (double.TryParse(input2, out double nombre2))
                            {
                                resultat = Math.Pow(nombre1, nombre2);
                                Console.WriteLine($"\nRésultat : {nombre1} puissance {nombre2} = {resultat}");
                            }
                            else
                            {
                                Console.WriteLine("\nEntrée invalide. Veuillez entrer un nombre valide.");
                            }

                            Console.WriteLine("\nAppuyez sur une touche pour continuer la division ou taper 'M' pour revenir au menu.");
                            Console.ReadKey();
                        }
                        while (input1 != "m" || input2 != "m");
                        break;

                    case 6: // Menu nettoyage
                        string wsnettoyage = String.Empty;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine("Nettoyer les données en mémoire");
                            Console.WriteLine(new string('*', 42));
                            Console.WriteLine($"Nombre en mémoire : {resultat}");
                            Console.WriteLine("\nAppuyez sur une touche pour continuer la division... Tapez 'M' pour revenir au menu et annuler.");
                            wsnettoyage = Console.ReadLine()?.Trim().ToUpper() ?? "";

                            if (wsnettoyage == "M")
                            {
                                Console.Write("Retour au menu...");
                                Console.ReadKey();
                                break;
                            }


                            if (string.IsNullOrEmpty(wsnettoyage) || wsnettoyage.ToUpper() != "m")
                            {
                                resultat = 0;
                                Console.Write("Données remises à zéro...");
                                Console.ReadKey();
                                break;
                            }
                        }
                        while (wsnettoyage != "m") ;
                        break;
                }
            }
            while (wschoix != 0) ;
        }
    }
}