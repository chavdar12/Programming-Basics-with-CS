using System.Reflection;

[assembly: CollectionBehavior(DisableTestParallelization = true)] // tests swap the global Console streams

namespace Programs.Tests;

public static class ProgramRunner
{
    /// <summary>Runs an exercise's Main (e.g. "003-Ex1") with <paramref name="input"/> as stdin and returns stdout.</summary>
    public static string Run(string program, string input = "")
    {
        var output = new StringWriter();
        Run(program, input, output);
        return output.ToString().ReplaceLineEndings("\n");
    }

    public static void Run(string program, string input, TextWriter output)
    {
        var (stdin, stdout) = (Console.In, Console.Out);
        Console.SetIn(new StringReader(input));
        Console.SetOut(output);
        try
        {
            Assembly.Load(program).EntryPoint!.Invoke(null, [Array.Empty<string>()]);
        }
        catch (TargetInvocationException e)
        {
            throw e.InnerException!;
        }
        finally
        {
            Console.SetIn(stdin);
            Console.SetOut(stdout);
        }
    }
}
