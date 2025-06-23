#  Listes et dictionnaires en C\#

## 1. Listes

Une `List<T>` est une collection dynamique d’un type spécifique.

### Création et ajout :

```csharp
List<int> nombres = new List<int>();
nombres.Add(1); // Ajoute 1
nombres.AddRange(new int[] { 2, 3 }); // Ajoute 2, 3
```

### Accès et modification :

```csharp
int premier = nombres[0]; // Accède à 1
nombres[1] = 5; // Remplace 2 par 5
```

### Suppression :

```csharp
nombres.Remove(5); // Supprime 5
nombres.RemoveAt(0); // Supprime l’élément à l’index 0
```

### Parcours :

```csharp
foreach (int n in nombres)
{
    Console.WriteLine(n);
}
```

### Méthodes utiles :

* `Count` : nombre d’éléments
* `Clear()` : vide la liste
* `Contains(valeur)` : vérifie si un élément existe

```csharp
Console.WriteLine(nombres.Count); // Affiche le nombre d’éléments
```

---

## 2. Dictionnaires

Un `Dictionary<TKey, TValue>` stocke des paires clé-valeur, avec des clés uniques.

### Création et ajout :

```csharp
Dictionary<string, int> scores = new Dictionary<string, int>();
scores.Add("Alice", 90);     // Ajoute Alice:90
scores["Bob"] = 85;          // Autre syntaxe
```

### Accès et modification :

```csharp
int scoreAlice = scores["Alice"]; // Accède à 90
scores["Alice"] = 95;             // Modifie à 95
```

### Suppression :

```csharp
scores.Remove("Bob");             // Supprime la paire Bob:85
```

### Parcours :

```csharp
foreach (var paire in scores)
{
    Console.WriteLine($"{paire.Key}: {paire.Value}");
}
```

### Méthodes utiles :

* `ContainsKey(clé)` : vérifie si une clé existe
* `Count` : nombre de paires
* `Clear()` : vide le dictionnaire

```csharp
if (scores.ContainsKey("Alice"))
{
    Console.WriteLine("Alice est dans le dictionnaire");
}
```

### Différences clés

* **Listes** : indexées par des entiers (0, 1, 2…), parfaites pour des collections ordonnées.
* **Dictionnaires** : indexés par des clés uniques (chaînes, nombres…), parfaits pour des recherches rapides par clé.
