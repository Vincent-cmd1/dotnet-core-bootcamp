using System.Diagnostics.CodeAnalysis;

namespace _01_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] notes = { 10, 12, 15, 8 };
            double somme = 0;

            if (!(notes.Length == 0))
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    somme += notes[i];
                    Console.WriteLine($"{somme}");
                }

                double moyenne = somme / notes.Length;

                Console.WriteLine($"{moyenne}");
            }



        }
    }
}
