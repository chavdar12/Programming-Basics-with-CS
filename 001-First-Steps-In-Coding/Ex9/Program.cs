namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var squareMeters = double.Parse(Console.ReadLine());

        var price = squareMeters * 7.61;
        var discount = price * 0.18;

        Console.WriteLine($"The final price is: {price - discount:f2} lv.");
        Console.WriteLine($"The discount is: {discount:f2} lv.");
    }
}
