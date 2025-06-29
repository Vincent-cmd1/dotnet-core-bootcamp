# Conditions imbriquées

11. Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.
12. Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).
13. Créer un programme qui vérifie si une année est bissextile ou non.
14. Vérifier si un nombre est positif et multiple de 5.
15. Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.
16. Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.
17. Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.
18. Écrire un programme qui affiche "Excellent" si la note est supérieure à 85, "Bien" si elle est entre 70 et 85, sinon afficher "Peut mieux faire".
19. Créer un programme qui vérifie si une chaîne de caractères est un palindrome.
20. Écrire un programme qui vérifie si un nombre est à la fois positif, pair et supérieur à 100.
20b. Jeu codingame

## 11. Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.

```C#
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

```
## 12. Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).
```C#
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
```

## 13. Créer un programme qui vérifie si une année est bissextile ou non.
```C#
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
```

## 14. Vérifier si un nombre est positif et multiple de 5.
```C#
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
```

## 15. Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un mot : ");
            string mot = Console.ReadLine();

            if (!string.IsNullOrEmpty(mot))
            {
                char lettre = 'a';
                if (mot.Contains(lettre))
                {
                    Console.WriteLine($"Le mot '{mot}' contient la lettre '{lettre}'");
                }
                else
                {
                    Console.WriteLine($"Le mot '{mot}' ne contient pas la lettre '{lettre}'");
                }
            }
            else
            {
                Console.WriteLine("Aucune saisie.");
            }
        }
    }
}
```

## 16. Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre : ");
            string saisie = Console.ReadLine();

            // On vérifie si l'utilisateur a bien saisi quelque chose
            if (!string.IsNullOrEmpty(saisie))
            {
                // On tente de convertir la saisie en entier
                if (int.TryParse(saisie, out int nombre))
                {
                    if (nombre % 2 == 0 && nombre % 3 == 0 && nombre % 9 > 0)
                    {
                        Console.WriteLine($"Le nombre '{nombre}' est divisible à la fois par 2 et par 3, mais pas par 9");
                    }
                    else
                    {
                        Console.WriteLine($"Le nombre '{nombre}' n'est pas divisible à la fois par 2 et par 3, mais pas par 9");
                    }
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas un nombre valide.");
                }
            }
            else
            {
                Console.WriteLine("Aucune saisie.");
            }
        }
    }
}
```

## 17. Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un pseudo : ");
            string pseudo = Console.ReadLine();

            Console.Write("Entrez un mot de passe : ");
            string mdp = Console.ReadLine();

            if (!string.IsNullOrEmpty(pseudo) || !string.IsNullOrEmpty(mdp))
            {
                Console.WriteLine($"Pseudonyme : {pseudo} || Mot de Passe : {mdp}");
            }
            else
            {
                Console.WriteLine("Problème dans la saisie.");
            }
        }
    }
}
```

## 18. Écrire un programme qui affiche "Excellent" si la note est supérieure à 85, "Bien" si elle est entre 70 et 85, sinon afficher "Peut mieux faire".
```C#
```

## 19. Créer un programme qui vérifie si une chaîne de caractères est un palindrome.
```C#
namespace exos_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mot = "kayak";
            string motinverse = new string(mot.Reverse().ToArray());

            if (mot == motinverse)
                Console.WriteLine($"Ce mot {mot} est un palindrome");
            else
                Console.WriteLine($"Ce mot {mot} n'est pas un palindrome");
        }
    }
}
```

## 20. Écrire un programme qui vérifie si un nombre est à la fois positif, pair et supérieur à 100.
```C#
```
