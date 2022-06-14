namespace _001;

internal static class Program
{
    private static void Main(string[] args)
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50) Console.WriteLine("Excellent!");
    }
}