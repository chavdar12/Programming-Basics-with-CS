namespace Programs.Tests;

public class ConditionalStatementsTests
{
    [Theory]
    [InlineData("003-Ex1", "5.50", "Excellent!\n")]
    [InlineData("003-Ex1", "5.49", "")]
    [InlineData("003-Ex2", "5\n3", "5\n")]
    [InlineData("003-Ex2", "3\n5", "5\n")]
    [InlineData("003-Ex3", "2", "even\n")]
    [InlineData("003-Ex3", "-3", "odd\n")]
    [InlineData("003-Ex4", "1", "one\n")]
    [InlineData("003-Ex4", "9", "nine\n")]
    [InlineData("003-Ex4", "10", "number too big\n")]
    [InlineData("003-Ex5", "95", "Less than 100\n")]
    [InlineData("003-Ex5", "200", "Between 100 and 200\n")]
    [InlineData("003-Ex5", "210", "Greater than 200\n")]
    [InlineData("003-Ex6", "s3cr3t!P@ssw0rd", "Welcome\n")]
    [InlineData("003-Ex6", "qwerty", "Wrong password!\n")]
    [InlineData("003-Ex7", "square\n5", "25.000\n")]
    [InlineData("003-Ex7", "rectangle\n7\n2.5", "17.500\n")]
    [InlineData("003-Ex7", "circle\n6", "113.097\n")]
    [InlineData("003-Ex7", "triangle\n4.5\n20", "45.000\n")]
    [InlineData("003-Ex8", "40.8\n20\n25\n30\n50\n10", "Yes! 418.20 lv left.\n")]
    [InlineData("003-Ex8", "320\n8\n2\n5\n5\n1", "Not enough money! 238.73 lv needed.\n")]
    [InlineData("003-Ex8", "18\n0\n0\n0\n0\n10", "Yes! 0.00 lv left.\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
