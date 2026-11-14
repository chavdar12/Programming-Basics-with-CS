namespace Ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        var radians = double.Parse(Console.ReadLine());

        Console.WriteLine(radians * 180 / Math.PI);
    }
}
