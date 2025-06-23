// ------------------------------------------------------------
// Nom du fichier : MultipleDe5.cs
// Description    : Demande un nombre à l'utilisateur et vérifie
//                  s’il est à la fois positif et un multiple de 5.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer un nombre : ");
int nombre = int.Parse(Console.ReadLine());

if (nombre > 0 && nombre % 5 == 0)
{
    Console.WriteLine($"{nombre} est positif et est un multiple de 5");
}
else
{
    Console.WriteLine($"{nombre} ne remplit pas la condition : positif et multiple de 5");
}
