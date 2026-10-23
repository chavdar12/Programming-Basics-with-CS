namespace Ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        var coins = double.Parse(Console.ReadLine());
        // Work in whole stotinki to avoid floating point drift.
        var monets = (int)Math.Round(coins * 100);
        var counter = 0;

        while (monets > 0)
        {
            if (monets >= 200)
                monets -= 200;
            else if (monets >= 100)
                monets -= 100;
            else if (monets >= 50)
                monets -= 50;
            else if (monets >= 20)
                monets -= 20;
            else if (monets >= 10)
                monets -= 10;
            else if (monets >= 5)
                monets -= 5;
            else if (monets >= 2)
                monets -= 2;
            else
                monets -= 1;
            counter++;
        }

        Console.WriteLine(counter);
    }
}