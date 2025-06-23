# Introduction au Langage C#

## Le C# (C-Sharp)

Le **C#** (se prononce "C-Sharp") est une évolution des langages **C** et **C++**, un peu comme **Java**. Il est entièrement orienté objet et offre plusieurs avantages :

- Permet l'écriture de programmes plus sûrs et plus stables.
- Gestion automatique de la mémoire via le **Garbage Collector** (ramasse-miettes).
- Gestion des exceptions intégrée pour une meilleure robustesse.

## Nouveautés par rapport au C++

- Libération automatique des objets.
- Remplacement des pointeurs par des références (plus sûres).
- Passage par référence plutôt que par adresse.
- Nouvelles façons de manipuler les tableaux.
- Nouvelle syntaxe pour les boucles (`foreach`).
- Suppression de l'héritage multiple, mais possibilité d'implémenter plusieurs interfaces.

## Visual Studio

**Visual Studio** est l'IDE (environnement de développement intégré) créé par Microsoft pour le développement dans l'environnement **.NET**. Il simplifie grandement le développement en C#.

- Version actuelle : **2022**.
- Plusieurs éditions sont disponibles, la **Community** étant gratuite.
- Ne pas confondre avec **Visual Studio Code**, un éditeur de texte plus généraliste.

Une alternative payante est **Rider** de JetBrains, qui reprend les fonctionnalités de Visual Studio.

### Visual Studio Installer

Pour installer les modules nécessaires au développement en C#, il faut utiliser **Visual Studio Installer**. Il permet de s'assurer que les bons modules sont installés, en fonction des technologies ou frameworks utilisés.

## Interface de Visual Studio (Accueil et Création)

Lors de la création de projets, Visual Studio propose plusieurs templates :

- **Console** : Application en ligne de commande (terminal/shell).
- **Web / API** : Applications utilisant le framework **ASP.NET Core** (MVC, Blazor, etc.).
- **Mobile** : Applications pour **iOS** ou **Android**.
- **Test, Bibliothèque de classes**, etc.

## Structure d'un projet C#

Un projet **C#** génère plusieurs fichiers et dossiers. Les plus importants sont :

- **.sln** : Le fichier solution, qui contient un ou plusieurs projets.
- **.csproj** : Le fichier projet, qui représente un projet spécifique (par exemple, une application).
- Les dossiers **bin** et **obj** sont utilisés pour la compilation et les fichiers intermédiaires.

## Modes de Visual Studio

Il existe deux modes principaux dans Visual Studio :

- **Mode Solution** : Affiche les projets sous forme de solution.
- **Mode Fichiers** : Affiche l'arborescence des fichiers du projet.

Le mode **Solution** est préférable car il permet de mieux gérer les projets complexes.

## Lancement de l'application

- Le bouton **triangle vert plein** lance l'application en mode **debug**.
- Le **triangle vide** lance l'application en mode **release** (sans débogage).
- La liste déroulante à gauche du bouton de lancement permet de choisir le projet à démarrer.

### Mode Debug

Le mode **debug** permet d'arrêter l'exécution du programme lorsqu'une exception se produit et de suivre l'évolution des variables en mémoire.

## La syntaxe du C#

### Point d'entrée d'une application

Un programme C# commence toujours par la fonction **Main**, qui est obligatoire. 

Elle doit être incluse dans une classe.

Depuis **.NET 6**, la fonction **Main** est simplifiée dans le fichier **Program.cs**.

### Appels à des fonctions/méthodes

En C#, il existe deux façons d'appeler une fonction :

- **Nom complet** : `System.Console.WriteLine("Hello World!");`
- **Nom relatif** : Après un `using System;`, vous pouvez utiliser `Console.WriteLine("Hello World!");`.

### Les types de commentaires

C# propose trois types de commentaires :

- **Commentaire de ligne** : `// Commentaire`
- **Commentaire multi-lignes** : `/* Commentaire */`
- **Commentaire de documentation** : `/// Commentaire`

### Les identificateurs

Les identificateurs sont des noms donnés aux éléments de l'algorithme (variables, fonctions, classes, etc.). Ils doivent respecter les règles suivantes :

- Commencer par une lettre ou un underscore (`_`).
- Être sensibles à la casse (maVariable != mavariable).
- Les mots réservés peuvent être utilisés comme identificateurs s'ils sont précédés du caractère `@` (ex. `@int`).

### Normes de nommage

Les conventions de nommage en C# sont les suivantes :

- **camelCase** pour les variables.
- **PascalCase** pour les classes, méthodes et propriétés.

### Les instructions en C#

Une instruction en C# se termine par un point-virgule (`;`). Les instructions peuvent être regroupées dans des blocs délimités par des accolades (`{}`). Les blocs définissent la portée des variables.

### Mots réservés du C#

Les mots réservés (ou **keywords**) sont des termes réservés par le langage pour des fonctionnalités spécifiques. Par exemple, `int`, `class`, `public`, etc.

### Les expressions en C#

Les expressions en C# sont des combinaisons de valeurs et d'opérateurs. Elles sont évaluées pour donner un résultat, comme en mathématiques. Par exemple :

- `1 + 2` => `3`
- `"Bonjour"` => chaîne de caractères

## La Console en C#

### Affichage en mode console

- **Console.Write()** : Affiche une chaîne sans retour à la ligne.
- **Console.WriteLine()** : Affiche une chaîne avec un retour à la ligne.

### Saisie en mode console

La saisie se fait avec **Console.ReadLine()**, qui lit une chaîne jusqu'à l'appui sur la touche Entrée. Le retour est une chaîne, donc une conversion est nécessaire pour d'autres types.

### Les caractères spéciaux dans les chaînes

Les caractères spéciaux peuvent être inclus avec l'échappement (backslash `\`) ou les chaînes verbatim (avec `@`).

Exemples :

- `Console.WriteLine("Je m'appelle \"teuse\"");`
- `Console.WriteLine(@"C:\repertoire\fichier.cs");`

### Séquences d'échappement

Les séquences d'échappement dans les chaînes de caractères permettent d'insérer des caractères spéciaux :

- `\n` : Nouvelle ligne
- `\t` : Tabulation
- `\u` : Séquence Unicode

## Variables et Types

### Types de Variables

Les variables en C# peuvent être de différents types :

- **Types numériques** : `int`, `float`, `double`, etc.
- **Chaînes de caractères** : `string`.
- **Booléens** : `bool` (true ou false).
- **Caractères** : `char`.
- **Null** : `null`, représente l'absence de valeur.

### Types spécifiques

C# propose aussi des types plus avancés :

- **enum** : Énumération de valeurs possibles.
- **delegate** : Représente des méthodes.
- **struct** : Structure de données.
- **class** : Classes pour instancier des objets.
- **interface** : Définition de contrats pour les classes.

### Déclaration et Initialisation

Les variables sont déclarées avec leur type suivi de leur nom :

```csharp
int age;
int age = 20; // Initialisation

Voici la correction avec le format Markdown appliqué correctement à partir de la phrase que tu as mentionnée :

```markdown
### Déclaration et Initialisation

Les variables en C# doivent être déclarées avant leur utilisation. Si elles ne sont pas explicitement initialisées, elles sont automatiquement initialisées avec des valeurs par défaut :

- **Types numériques** : `0`
- **Booléens** : `false`
- **Références (objets)** : `null`

Exemple :

```csharp
int age; // Valeur par défaut : 0
bool isActive; // Valeur par défaut : false
string name; // Valeur par défaut : null
```

### Nullable

Il est possible de déclarer une variable nullable, en ajoutant `?` après le type. Cela permet de lui assigner la valeur `null` comme valeur possible.

```csharp
int? age = null; // La variable peut être nulle
```

### Constantes

Les constantes sont des valeurs fixes qui ne changent pas pendant l'exécution du programme. Elles sont déclarées avec le mot-clé `const`. Par exemple :

```csharp
const double Pi = 3.1415926535897932;
```

Les constantes doivent être initialisées au moment de leur déclaration et leur valeur ne peut pas être modifiée ensuite.

### Variables de type valeur vs. référence

- **Type valeur** : La variable contient directement la valeur. Exemples : `int`, `char`, `float`.
- **Type référence** : La variable contient une référence à un objet. Exemples : `string`, `class`, `array`.

Les types valeur sont stockés directement en mémoire, tandis que les types référence stockent un pointeur vers un emplacement mémoire où se trouve l'objet.

### Types de données en C#

Les variables en C# peuvent être de plusieurs types. Les types de base sont :

- **Types numériques** : 
  - `int` : Entier
  - `float` : Nombre à virgule flottante (simple précision)
  - `double` : Nombre à virgule flottante (double précision)
  - `decimal` : Nombre à virgule fixe, souvent utilisé pour les valeurs monétaires

- **Chaînes de caractères** : 
  - `string` : Séquence de caractères

- **Booléens** :
  - `bool` : Valeur `true` ou `false`

- **Caractères** :
  - `char` : Un seul caractère

### Le type `object`

Le type `object` est le type de base de tous les types en C#. Tout type peut être affecté à une variable de type `object`, mais cela nécessite un **boxing** et un **unboxing** si la variable `object` doit être utilisée comme son type d'origine.

```csharp
object obj = 123;  // Boxing
int num = (int)obj; // Unboxing
```

### Types personnalisés : Classes et Structures

- **Classes** : Les classes sont des types de référence. Elles sont utilisées pour définir des objets avec des propriétés, des méthodes et des événements.
  
  Exemple de classe :

  ```csharp
  class Person
  {
      public string Name;
      public int Age;

      public void Greet()
      {
          Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
      }
  }
  ```

- **Structures** : Les structures sont des types valeur. Elles sont similaires aux classes, mais elles sont plus légères et ne nécessitent pas d'allocation sur le tas.

  Exemple de structure :

  ```csharp
  struct Point
  {
      public int X;
      public int Y;

      public void Display()
      {
          Console.WriteLine($"Point coordinates: ({X}, {Y})");
      }
  }
  ```

Les classes sont généralement utilisées pour les objets complexes, tandis que les structures sont utilisées pour les types légers où la performance est essentielle.

### En résumé :

- **Types valeur** : Contiennent directement la valeur (par exemple, `int`, `char`).
- **Types référence** : Contiennent une référence à un objet en mémoire (par exemple, `string`, `class`).
- Les **constantes** sont des valeurs qui ne peuvent pas changer après leur initialisation.
- Les **types nullable** permettent à une variable de type valeur de prendre la valeur `null`.






Voici un tableau récapitulatif des principaux types existants en C# :


| **Catégorie**             | **Type**                   | **Description**                                                                  |
| ------------------------- | -------------------------- | -------------------------------------------------------------------------------- |
| **Types numériques**      | `byte`                     | Entier non signé de 8 bits (0 à 255)                                             |
|                           | `sbyte`                    | Entier signé de 8 bits (-128 à 127)                                              |
|                           | `short`                    | Entier signé de 16 bits (-32 768 à 32 767)                                       |
|                           | `ushort`                   | Entier non signé de 16 bits (0 à 65 535)                                         |
|                           | `int`                      | Entier signé de 32 bits (-2 147 483 648 à 2 147 483 647)                         |
|                           | `uint`                     | Entier non signé de 32 bits (0 à 4 294 967 295)                                  |
|                           | `long`                     | Entier signé de 64 bits (-9 223 372 036 854 775 808 à 9 223 372 036 854 775 807) |
|                           | `ulong`                    | Entier non signé de 64 bits (0 à 18 446 744 073 709 551 615)                     |
|                           | `float`                    | Nombre à virgule flottante 32 bits (précision simple)                            |
|                           | `double`                   | Nombre à virgule flottante 64 bits (précision double)                            |
|                           | `decimal`                  | Nombre décimal 128 bits, utilisé pour les calculs financiers                     |
| **Types booléens**        | `bool`                     | Valeur binaire `true` ou `false`                                                 |
| **Types caractères**      | `char`                     | Un seul caractère Unicode (16 bits)                                              |
| **Chaînes de caractères** | `string`                   | Séquence de caractères Unicode (référence)                                       |
| **Types spéciaux**        | `object`                   | Type de base de tous les types (peut contenir n'importe quel type de données)    |
| **Types nullables**       | `int?`, `bool?`, etc.      | Types valeur qui peuvent être `null`                                             |
| **Types personnalisés**   | `class`                    | Type référence définissant une classe (ex : `Person`)                            |
|                           | `struct`                   | Type valeur définissant une structure (ex : `Point`)                             |
| **Types de tableau**      | `T[]`                      | Tableau d'éléments de type `T` (ex : `int[]`, `string[]`)                        |
| **Types génériques**      | `List<T>`                  | Liste générique d'éléments de type `T`                                           |
|                           | `Dictionary<TKey, TValue>` | Dictionnaire générique avec clé `TKey` et valeur `TValue`                        |
| **Types énumérés**        | `enum`                     | Type pour définir un ensemble de valeurs symboliques (ex : `Days`)               |
| **Types d'interface**     | `interface`                | Type qui définit un contrat sans implémentation (ex : `IDriveable`)              |


### Explication des catégories :
1. **Types numériques** : Ce sont les types pour les entiers et les nombres à virgule flottante, utilisés pour représenter des données numériques.
2. **Types booléens** : Le type `bool` est utilisé pour des valeurs logiques (`true` ou `false`).
3. **Types caractères** : Le type `char` est utilisé pour représenter un seul caractère Unicode.
4. **Chaînes de caractères** : `string` est une séquence de caractères, utilisée pour manipuler du texte.
5. **Types spéciaux** : Le type `object` est la base de tous les types en C#. Tout type dérive implicitement de `object`.
6. **Types nullables** : Les types comme `int?` permettent de représenter des valeurs nulles pour des types valeur.
7. **Types personnalisés** : Ce sont des types définis par l'utilisateur, tels que des classes (`class`) et des structures (`struct`).
8. **Types de tableau** : Permettent de stocker une collection d'éléments d'un même type.
9. **Types génériques** : Permettent de définir des collections ou des types pouvant contenir des éléments de n'importe quel type de manière sécurisée.
10. **Types énumérés** : Permettent de définir un ensemble d'éléments nommés et associés à des valeurs sous forme d'entiers.
11. **Types d'interface** : Ce sont des types qui définissent des contrats à suivre par les classes qui les implémentent.

N'hésite pas à me dire si tu veux plus de détails sur un type spécifique !
