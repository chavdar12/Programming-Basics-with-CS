namespace Ex6;

internal class Program
{
    private static void Main(string[] args)
    {
        var nylon = int.Parse(Console.ReadLine());
        var paint = int.Parse(Console.ReadLine());
        var thinner = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());

        var materials = (nylon + 2) * 1.50 + paint * 1.10 * 14.50 + thinner * 5.00 + 0.40;
        var workers = materials * 0.30 * hours;

        Console.WriteLine(materials + workers);
    }
}
