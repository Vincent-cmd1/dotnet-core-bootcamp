Console.WriteLine("Maintenant nous allons faire quelques opérations. \nEntrez un premier chiffre : ");
int var1 = int.Parse(Console.ReadLine());
Console.WriteLine("Puis un second : ");
int var2 = int.Parse(Console.ReadLine());

int somme = var1 + var2;
Console.WriteLine($"Addition : La somme de {var1} et {var2} égal {somme}");

int soustraction = var1 - var2;
Console.WriteLine($"Soustratcion : La soustraction de {var1} et {var2} égal {soustraction}");

int multiple = var1 * var2;
Console.WriteLine($"Multiplication : La multiplication de {var1} et {var2} égal {multiple}");

int division = var1 / var2; int modulo = var1 % var2;
Console.WriteLine($"Division : La division de {var1} et {var2} égal {division} et son reste {modulo}");

if (var1 == var2)
    Console.WriteLine("Les deux chiffres sont égaux");
else
    Console.WriteLine("Les deux chiffres ne sont pas égaux");