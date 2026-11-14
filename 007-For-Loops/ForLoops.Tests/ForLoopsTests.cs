namespace Programs.Tests;

public class ForLoopsTests
{
    [Fact]
    public void Ex1_prints_1_to_100() =>
        Assert.Equal(string.Concat(Enumerable.Range(1, 100).Select(i => $"{i}\n")), ProgramRunner.Run("007-Ex1"));

    [Theory]
    [InlineData("007-Ex2", "3", "3\n2\n1\n")]
    [InlineData("007-Ex3", "10", "1\n4\n7\n10\n")]
    [InlineData("007-Ex4", "3", "1\n4\n")]
    [InlineData("007-Ex4", "4", "1\n4\n16\n")]
    [InlineData("007-Ex5", "abc", "a\nb\nc\n")]
    [InlineData("007-Ex6", "hello", "6\n")]
    [InlineData("007-Ex6", "bamboo", "9\n")]
    [InlineData("007-Ex7", "2\n10\n20", "30\n")]
    [InlineData("007-Ex7", "3\n-10\n-20\n-30", "-60\n")]
    [InlineData("007-Ex8", "5\n10\n20\n304\n0\n50", "Max number: 304\nMin number: 0\n")]
    [InlineData("007-Ex9", "2\n10\n90\n60\n40", "Yes, sum = 100\n")]
    [InlineData("007-Ex9", "2\n90\n9\n50\n50", "No, diff = 1\n")]
    [InlineData("007-Ex10", "4\n10\n50\n60\n20", "Yes\nSum = 70\n")]
    [InlineData("007-Ex10", "4\n3\n5\n1\n-2", "No\nDiff = 1\n")]
    [InlineData("007-Ex11", "10\n170.00\n6", "Yes! 5.00\n")]
    [InlineData("007-Ex11", "21\n1570.98\n3", "No! 997.98\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
