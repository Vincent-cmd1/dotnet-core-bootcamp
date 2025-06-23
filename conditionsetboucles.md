# Cours 1 : Branches conditionnelles et boucles en C#

## 1. Branches conditionnelles  
Les branches conditionnelles permettent d'exécuter du code en fonction d’une condition.

### `if`  
Exécute un bloc si une condition est vraie :
```csharp
int x = 10;
if (x > 5)
{
    Console.WriteLine("x est supérieur à 5");
}
````

### `else`

Exécute un bloc si la condition du `if` est fausse :

```csharp
if (x > 15)
{
    Console.WriteLine("x est supérieur à 15");
}
else
{
    Console.WriteLine("x est inférieur ou égal à 15");
}
```

### `else if`

Teste une nouvelle condition si la précédente est fausse :

```csharp
if (x > 15)
{
    Console.WriteLine("x est supérieur à 15");
}
else if (x > 5)
{
    Console.WriteLine("x est entre 6 et 15");
}
else
{
    Console.WriteLine("x est inférieur ou égal à 5");
}
```

### `switch`

Sélectionne un bloc en fonction de la valeur d’une variable :

```csharp
int jour = 1;
switch (jour)
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    default:
        Console.WriteLine("Jour inconnu");
        break;
}
```

---

## 2. Boucles

Les boucles répètent un bloc de code.

### `for`

Boucle avec un compteur :

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); // Affiche 0, 1, 2, 3, 4
}
```

### `while`

Répète tant qu’une condition est vraie :

```csharp
int j = 0;
while (j < 5)
{
    Console.WriteLine(j);
    j++;
}
```

### `do-while`

Exécute au moins une fois, puis répète si la condition est vraie :

```csharp
int k = 0;
do
{
    Console.WriteLine(k);
    k++;
} while (k < 5);
```

### `foreach`

Parcourt chaque élément d’une collection :

```csharp
int[] nombres = { 1, 2, 3 };
foreach (int n in nombres)
{
    Console.WriteLine(n);
}
```

### `break` et `continue`

* **`break`** : sort immédiatement de la boucle
* **`continue`** : passe à l’itération suivante

```csharp
for (int i = 0; i < 5; i++)
{
    if (i == 2) continue; // Saute 2
    if (i == 4) break;    // Arrête à 4
    Console.WriteLine(i); // Affiche 0, 1, 3
}
```

