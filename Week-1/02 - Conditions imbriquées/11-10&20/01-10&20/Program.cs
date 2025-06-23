// ------------------------------------------------------------
// Nom du fichier : NombreEntre10Et20.cs
// Description    : Demande à l'utilisateur un nombre et indique
//                  s’il est compris entre 10 et 20 inclus.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

// Utilisation de && au lieu de & pour un test logique
if (nombre >= 10 && nombre <= 20)
{
    Console.WriteLine("Bravo ! Votre nombre est compris entre 10 et 20");
}
else
{
    Console.WriteLine("Nul ! Votre nombre n'est pas compris entre 10 et 20");
}
