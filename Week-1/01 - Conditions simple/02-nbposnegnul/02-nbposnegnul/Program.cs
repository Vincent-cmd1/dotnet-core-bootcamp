// ------------------------------------------------------------
// Nom du fichier : AnalyseNombre.cs
// Description    : Demande un chiffre et indique s’il est nul,
//                  positif ou négatif.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer un chiffre :");
int nombre = int.Parse(Console.ReadLine());

if (nombre == 0)
{
    Console.WriteLine("Le nombre est nul");
}
else if (nombre > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else
{
    Console.WriteLine("Le nombre est négatif");
}
