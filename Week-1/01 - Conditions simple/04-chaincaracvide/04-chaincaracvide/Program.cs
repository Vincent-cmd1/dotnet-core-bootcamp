// ------------------------------------------------------------
// Nom du fichier : PhraseUtilisateur.cs
// Description    : Demande une phrase à l'utilisateur et réagit
//                  selon qu'il ait écrit quelque chose ou non.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer une phrase de votre choix :");
string chainecarac = Console.ReadLine();

if (string.IsNullOrWhiteSpace(chainecarac))
{
    Console.WriteLine("Vous n'avez rien écrit !");
}
else
{
    Console.WriteLine($"Super ! {chainecarac}");
}
