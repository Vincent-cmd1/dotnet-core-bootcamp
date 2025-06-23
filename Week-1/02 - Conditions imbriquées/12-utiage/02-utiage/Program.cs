// ------------------------------------------------------------
// Nom du fichier : ClassificationAge.cs
// Description    : Demande l’âge de l’utilisateur et affiche
//                  s’il est enfant, adolescent ou adulte.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer votre âge : ");
int age = int.Parse(Console.ReadLine());

if (age < 12)
{
    Console.WriteLine("Vous êtes un enfant");
}
else if (age >= 12 && age < 18)
{
    Console.WriteLine("Vous êtes un adolescent !");
}
else
{
    Console.WriteLine("Vous êtes un adulte");
}
