﻿namespace _003;

internal static class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = 1; i <= number; i += 3) Console.WriteLine(i);
    }
}