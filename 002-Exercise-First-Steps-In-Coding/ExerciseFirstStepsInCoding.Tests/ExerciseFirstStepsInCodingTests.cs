namespace Programs.Tests;

public class ExerciseFirstStepsInCodingTests
{
    // These print unrounded doubles, so compare numerically like Judge does instead of char by char.
    [Theory]
    [InlineData("002-Ex1", "22", 39.50078)]
    [InlineData("002-Ex1", "100", 179.549)]
    [InlineData("002-Ex1", "12.5", 22.443625)]
    [InlineData("002-Ex2", "3.1416", 180.0004209182994)]
    [InlineData("002-Ex2", "6.2832", 360.0008418365988)]
    [InlineData("002-Ex2", "0.7854", 45.00010522957485)]
    [InlineData("002-Ex3", "200\n3\n5.7", 202.85)]
    [InlineData("002-Ex3", "2350\n6\n7", 2432.25)]
    [InlineData("002-Ex4", "212\n20\n2", 5)]
    [InlineData("002-Ex4", "432\n15\n4", 7)]
    [InlineData("002-Ex5", "2\n3\n4\n25", 28.5)]
    [InlineData("002-Ex5", "4\n2\n5\n13", 37.932)]
    [InlineData("002-Ex6", "10\n11\n4\n8", 727.09)]
    [InlineData("002-Ex6", "5\n10\n10\n1", 286.52)]
    [InlineData("002-Ex7", "2\n4\n3", 116.2)]
    [InlineData("002-Ex7", "9\n2\n6", 202.72)]
    [InlineData("002-Ex8", "365", 811.76)]
    [InlineData("002-Ex8", "550", 1223.2)]
    [InlineData("002-Ex9", "85\n75\n47\n17", 248.68875)]
    [InlineData("002-Ex9", "105\n77\n89\n18.5", 586.445475)]
    public void Prints_expected_number(string program, string input, double expected) =>
        Assert.Equal(expected, double.Parse(ProgramRunner.Run(program, input)), 6);
}
