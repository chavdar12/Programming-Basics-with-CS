﻿namespace _009;

internal static class Program
{
    private static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());

        for (var i = 1; i <= 9; i++)
        for (var j = 1; j <= 9; j++)
        for (var k = 1; k <= 9; k++)
        for (var l = 1; l <= 9; l++)
            if (i + j == k + l)
                if (number % (i + j) == 0)
                    Console.Write($"{i}{j}{k}{l} ");
    }
}