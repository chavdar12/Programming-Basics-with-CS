﻿namespace _011;

internal static class Program
{
    private static void Main(string[] args)
    {
        var day = Console.ReadLine();
        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                Console.WriteLine("Working day");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}