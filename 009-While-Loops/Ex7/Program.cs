namespace Ex7;

internal class Program
{
    private static void Main(string[] args)
    {
        var studentName = Console.ReadLine();
        var gradeCounter = 0;
        var excludeCounter = 0;
        double gradesSum = 0;
        while (gradeCounter < 12)
        {
            var grades = double.Parse(Console.ReadLine());
            // A failed year is repeated, so it doesn't move the student to the next grade.
            if (grades < 4.00)
            {
                excludeCounter++;
                if (excludeCounter > 1) break;
                continue;
            }

            gradesSum += grades;
            gradeCounter++;
        }

        if (gradeCounter == 12)
        {
            var averageGrade = gradesSum / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
        }
        else
        {
            Console.WriteLine($"{studentName} has been excluded at {gradeCounter + 1} grade");
        }
    }
}