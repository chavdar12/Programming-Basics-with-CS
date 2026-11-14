namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var pens = int.Parse(Console.ReadLine());
        var markers = int.Parse(Console.ReadLine());
        var cleanerLiters = int.Parse(Console.ReadLine());
        var discountPercent = int.Parse(Console.ReadLine());

        var totalSum = pens * 5.80 + markers * 7.20 + cleanerLiters * 1.20;

        Console.WriteLine(totalSum - totalSum * discountPercent / 100);
    }
}
