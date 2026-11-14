namespace Ex4;

internal class Program
{
    private static void Main(string[] args)
    {
        var pages = int.Parse(Console.ReadLine());
        var pagesPerHour = int.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());

        var totalHours = pages / pagesPerHour;

        Console.WriteLine(totalHours / days);
    }
}
