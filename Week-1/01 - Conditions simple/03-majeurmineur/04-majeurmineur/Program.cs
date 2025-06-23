// ------------------------------------------------------------
// Nom du fichier : ControleMajorite.cs
// Description    : Demande le prénom et l’âge de l’utilisateur,
//                  puis indique s’il est majeur ou mineur.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

const int majorite = 18;

Console.WriteLine("Veuillez saisir votre prénom : ");
string prenom = Console.ReadLine();

Console.WriteLine("Veuillez entrer votre âge : ");
string age = Console.ReadLine();

int ageverifie = int.Parse(age);

if (ageverifie < majorite)
{
    Console.WriteLine($"{prenom} Vous êtes mineur. Vous n'avez pas le droit d'entrer au casino");
}
else
{
    Console.WriteLine($"Vous êtes majeur {prenom}. Bienvenue au Crazyno");
}
