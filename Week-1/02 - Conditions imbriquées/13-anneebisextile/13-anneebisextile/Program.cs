// ------------------------------------------------------------
// Nom du fichier : AnneeBissextile.cs
// Description    : Demande une année et indique si elle est
//                  bissextile selon les règles du calendrier grégorien.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer une année : ");
int annee = int.Parse(Console.ReadLine());

if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
{
    Console.WriteLine($"L'année {annee} est bissextile.");
}
else
{
    Console.WriteLine($"L'année {annee} n'est pas bissextile.");
}
