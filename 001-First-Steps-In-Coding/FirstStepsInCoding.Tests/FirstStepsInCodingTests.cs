namespace Programs.Tests;

public class FirstStepsInCodingTests
{
    [Theory]
    [InlineData("001-Ex1", "", "Hello SoftUni\n")]
    [InlineData("001-Ex2", "", "1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n")]
    [InlineData("001-Ex3", "5\n7", "35\n")]
    [InlineData("001-Ex3", "6\n8", "48\n")]
    [InlineData("001-Ex4", "5", "12.7\n")]
    [InlineData("001-Ex4", "7", "17.78\n")]
    [InlineData("001-Ex5", "Nakov", "Hello, Nakov!\n")]
    [InlineData("001-Ex6", "Maria\nIvanova\n20\nSofia", "You are Maria Ivanova, a 20-years old person from Sofia.\n")]
    [InlineData("001-Ex7", "George\n4", "The architect George will need 12 hours to complete 4 project/s.\n")]
    [InlineData("001-Ex7", "Sanya\n9", "The architect Sanya will need 27 hours to complete 9 project/s.\n")]
    [InlineData("001-Ex8", "5\n4", "28.5 lv.\n")]
    [InlineData("001-Ex8", "13\n9", "68.5 lv.\n")]
    [InlineData("001-Ex9", "550", "The final price is: 3432.11 lv.\nThe discount is: 753.39 lv.\n")]
    [InlineData("001-Ex9", "150", "The final price is: 936.03 lv.\nThe discount is: 205.47 lv.\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
