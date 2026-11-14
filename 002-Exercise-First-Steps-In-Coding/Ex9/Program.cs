namespace Ex9;

internal class Program
{
    private static void Main(string[] args)
    {
        var length = int.Parse(Console.ReadLine());
        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());
        var percent = double.Parse(Console.ReadLine());

        var liters = length * width * height * 0.001;

        Console.WriteLine(liters * (1 - percent / 100));
    }
}
