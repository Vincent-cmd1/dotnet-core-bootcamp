# CONDITIONS SIMPLES

### 1. Conditions simples

1. Écrire un programme qui vérifie si un nombre donné est supérieur à 10.
1b. Jeu codingame
2. Vérifier si un nombre donné est positif, négatif ou nul.
3. Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.
4. Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.
5. Vérifier si un nombre est pair ou impair.
6. Écrire un programme qui compare deux nombres et affiche le plus grand.
7. Vérifier si un nombre est divisible par 3 ou par 5.
8. Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".
9. Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.
10. Calculer le nombre de caractères dans une chaîne de caractères, si le nombre de caractères est supérieur à 5, ne garder que les 5 premiers caractères.

## 1. Écrire un programme qui vérifie si un nombre donné est supérieur à 10.

```C#
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
```
## 2. Vérifier si un nombre donné est positif, négatif ou nul.
```C#
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

```

## 3. Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.
```C#
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

```

## 4. Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.
```C#
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

```

## 5. Vérifier si un nombre est pair ou impair.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre");
            int nombre = int.Parse(Console.ReadLine());

            if (nombre % 2 == 0)
            {
                Console.WriteLine($"Le nombre {nombre} est pair");
            }
            else
            {
                Console.WriteLine($"Le nombre {nombre} est impair");
            }
        }
    }
}
```

## 6. Écrire un programme qui compare deux nombres et affiche le plus grand.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un premier nombre : ");
            int nombre1 = int.Parse(Console.ReadLine());

            Console.Write("Entrez un second nombre : ");
            int nombre2 = int.Parse(Console.ReadLine());

            if (nombre1 < nombre2)
            {
                Console.WriteLine($"Le nombre {nombre2} est le plus grand des deux");
            }
            else
            {
                Console.WriteLine($"Le nombre {nombre1} est le plus grand  des deux");
            }
        }
    }
}
```

## 7. Vérifier si un nombre est divisible par 3 ou par 5.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre : ");
            int nombre1 = int.Parse(Console.ReadLine());

            if (nombre1 % 3 == 0 && nombre1 % 5 == 0)
            {
                Console.WriteLine($"Le nombre {nombre1} est divisible par 3 et 5");
            }
            else
            {
                Console.WriteLine($"Le nombre {nombre1} n'est pas divisible par 3 et 5");
            }
        }
    }
}
```

## 8. Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un mot de passe : ");
            string mdpsave = "admin";
            string mdp = Console.ReadLine();

            if (mdp == mdpsave)
            {
                Console.WriteLine($"Bienvenue {mdp} !");
            }
            else
            {
                Console.WriteLine($"Le mot de passe '{mdp}' est erroné");
            }
        }
    }
}
```

## 9. Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez une lettre : ");
            string saisie = Console.ReadLine();

            if (!string.IsNullOrEmpty(saisie))
            {
                char lettre = char.ToLower(saisie[0]); // On prend le premier caractère saisi
                string voyelles = "aeiouy";

                if (voyelles.Contains(lettre))
                {
                    Console.WriteLine($"La lettre '{lettre}' est une voyelle.");
                }
                else
                {
                    Console.WriteLine($"La lettre '{lettre}' est une consonne.");
                }
            }
            else
            {
                Console.WriteLine("Aucune lettre saisie.");
            }
        }
    }
}
```

## 10. Calculer le nombre de caractères dans une chaîne de caractères, si le nombre de caractères est supérieur à 5, ne garder que les 5 premiers caractères.
```C#
namespace _10_Fonctionseparateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez une chaine de caractères de moins de 5 caractères : ");
            string saisie = Console.ReadLine();

            if (!string.IsNullOrEmpty(saisie))
            {
                if (saisie.Length <= 5 )
                {
                    Console.WriteLine($"Ici '{saisie}' suis la consigne.");
                }
                else
                {
                    //saisie.Remove(6);
                    Console.WriteLine($"Voici '{saisie.Remove(5)}', une correction avec 5 caractères.");
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



