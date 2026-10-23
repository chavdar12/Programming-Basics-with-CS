namespace Ex1;

internal class Program
{
    private static void Main(string[] args)
    {
        var word = Console.ReadLine();
        while (word != "Stop")
        {
            Console.WriteLine(word);
            word = Console.ReadLine();
        }
    }
}