namespace _014;

internal static class Program
{
    private static void Main(string[] args)
    {
        var count = int.Parse(Console.ReadLine());

        var lastSum = 0;
        var diff = 0;

        for (var i = 0; i < count; i++)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var sum = first + second;
            if (i > 0) diff = Math.Abs(lastSum - sum);
            lastSum = sum;
        }

        Console.WriteLine(diff == 0 ? $"Yes, value={lastSum}" : $"No, max diff={diff}");
    }
}