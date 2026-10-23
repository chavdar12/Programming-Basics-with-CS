namespace Ex8;

internal class Program
{
    private static void Main(string[] args)
    {
        var income = double.Parse(Console.ReadLine());
        var averageSuccess = double.Parse(Console.ReadLine());
        var minimalSalary = double.Parse(Console.ReadLine());

        var scholarship = income < minimalSalary && averageSuccess > 4.50 ? Math.Floor(minimalSalary * 0.35) : 0;
        var scholarshipExcellent = averageSuccess >= 5.50 ? Math.Floor(averageSuccess * 25) : 0;

        // Eligible for both: the bigger one wins, a tie goes to the excellent-results scholarship.
        if (scholarship > scholarshipExcellent)
            Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
        else if (scholarshipExcellent > 0)
            Console.WriteLine($"You get a scholarship for excellent results {scholarshipExcellent} BGN");
        else
            Console.WriteLine("You cannot get a scholarship!");
    }
}