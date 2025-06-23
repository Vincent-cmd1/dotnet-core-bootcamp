// ------------------------------------------------------------
// Nom du fichier : ComparateurDeNombre.cs
// Description    : Demande un nombre à l'utilisateur et indique
//                  s'il est supérieur à 10 ou non.
// Auteur         : Vincent Faivre
// Date           : 21/06/2025
// Version        : 1.0
// ------------------------------------------------------------

Console.WriteLine("Veuillez entrer un nombre");
string nombre = Console.ReadLine();

int nombresup = int.Parse(nombre);

if (nombresup > 10)
{
    Console.WriteLine("Votre nombre est supérieur à 10");
}
else
{
    Console.WriteLine("Votre nombre est inférieur ou égal à 10");
}
