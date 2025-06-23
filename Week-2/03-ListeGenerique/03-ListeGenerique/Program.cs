namespace _03_ListeGenerique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> prenoms = new List<string>();

            Console.WriteLine("Entrez un prenom");

            for (int i = 0; i < 5; i++)
            {

                string addprenom = Console.ReadLine();
                prenoms.Add(addprenom);
                Console.WriteLine($"{i + 1} - {addprenom}");

            }

            prenoms.Sort();

            Console.WriteLine(string.Join(" - ", prenoms));

            Console.WriteLine("Quel nom voulez vous selectionner :");
            string choix = Console.ReadLine();

            if (prenoms.Contains(choix))
            {
                Console.WriteLine($"Vous avez bien selection {choix}");
            }
            else
            {
                Console.WriteLine($"Le nom {choix} n'a pas été trouvé");
            }

        }
    }
}
