namespace Ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        var depositSum = double.Parse(Console.ReadLine());
        var months = int.Parse(Console.ReadLine());
        var yearlyInterest = double.Parse(Console.ReadLine());

        var monthlyInterest = depositSum * yearlyInterest / 100 / 12;

        Console.WriteLine(depositSum + months * monthlyInterest);
    }
}
