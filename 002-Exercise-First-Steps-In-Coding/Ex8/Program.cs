namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var yearlyFee = int.Parse(Console.ReadLine());

        var shoes = yearlyFee * 0.60;
        var outfit = shoes * 0.80;
        var ball = outfit / 4;
        var accessories = ball / 5;

        Console.WriteLine(yearlyFee + shoes + outfit + ball + accessories);
    }
}
