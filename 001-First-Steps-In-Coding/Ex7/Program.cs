namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var architectName = Console.ReadLine();
        var projectsCount = int.Parse(Console.ReadLine());

        Console.WriteLine($"The architect {architectName} will need {projectsCount * 3} hours to complete {projectsCount} project/s.");
    }
}
