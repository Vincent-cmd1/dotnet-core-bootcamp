using System.Reflection.Metadata.Ecma335;

namespace _05_Dictionnaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var capitales = new Dictionary<string, string>();
            string uinput = "";
            string recherche = "";
            int choix = 0;
            string stop = "";


            Console.WriteLine("0 - Fermeture de l'application");
            Console.WriteLine("1 - Ajouter un pays et sa capitale");
            Console.WriteLine("2 - Recherche une capitale");
            

            choix = int.Parse(Console.ReadLine());
            Console.Clear();



                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Fermeture de l'application");
                        break;

                    case 1:
                    if (uinput.ToLower() != "fin");
                    {
                        do
                        {
                            Console.WriteLine("Donner un pays. Tapez 'fin' pour returner au menu");
                            uinput = Console.ReadLine();

                            if (uinput.ToLower() != "fin")
                            {
                                Console.WriteLine("Donner sa capitale");
                                capitales.Add(uinput, Console.ReadLine());
                            }
                        }
                        while (uinput.ToLower() != "fin");
                        {
                            break;
                        }
                    }


                case 2:
                        Console.WriteLine("Entrez le nom du pays à rechercher :");
                        recherche = Console.ReadLine();

                        if (capitales.ContainsKey(recherche))
                        {
                            Console.WriteLine($"La capitale de {recherche} est : {capitales[recherche]}");
                        }
                        else
                        {
                            Console.WriteLine("Ce pays n'est pas dans le dictionnaire.");
                        }
                        break;

                    default:
                        Console.WriteLine("Erreur dans la saisie");
                        break;

                }
        }
    }
}
