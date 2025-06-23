Console.WriteLine("Veuillez saisir votre nom, puis appuyer sur entrée");
string name = Console.ReadLine();

Console.WriteLine("Quel âge avez vous ?");
string age =  Console.ReadLine();

int age1 = int.Parse(age);
const string csharpe = "Vous allez maintenant apprendre le C#";


Console.WriteLine($"Hello, World! {name}. Vous avez {age1} ans");
Console.WriteLine(csharpe);

