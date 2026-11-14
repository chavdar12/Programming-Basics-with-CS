namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var dogFood = int.Parse(Console.ReadLine());
        var catFood = int.Parse(Console.ReadLine());

        var totalSum = dogFood * 2.50 + catFood * 4;

        Console.WriteLine($"{totalSum} lv.");
    }
}
