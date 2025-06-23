namespace _02_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notes = { 12, 13, 14, 14 };
            Console.WriteLine($"Valeur minimal : {notes.Max()}\n" +
                              $"Valeur maximale : {notes.Min()}\n" +
                              $"Moyenne : {notes.Average()}\n"
                );

        }
    }
}
