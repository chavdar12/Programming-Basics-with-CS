namespace Programs.Tests;

public class WhileLoopsTests
{
    [Theory]
    [InlineData("009-Ex1", "Nakov\nSoftUni\nStop", "Nakov\nSoftUni\n")]
    [InlineData("009-Ex1", "Stop", "")]
    [InlineData("009-Ex2", "Nakov\n1234\npass\n1324\n1234", "Welcome Nakov!\n")]
    [InlineData("009-Ex3", "100\n10\n20\n30\n40", "100\n")]
    [InlineData("009-Ex3", "20\n1\n2\n3\n4\n5\n6", "21\n")]
    [InlineData("009-Ex4", "3", "1\n3\n")]
    [InlineData("009-Ex4", "31", "1\n3\n7\n15\n31\n")]
    [InlineData("009-Ex5", "5.51\n69.42\n100\nNoMoreMoney",
        "Increase: 5.51\nIncrease: 69.42\nIncrease: 100.00\nTotal: 174.93\n")]
    [InlineData("009-Ex5", "120\n45.55\n-150", "Increase: 120.00\nIncrease: 45.55\nInvalid operation!\nTotal: 165.55\n")]
    [InlineData("009-Ex6", "100\n99\n80\n70\nStop", "100\n")]
    [InlineData("009-Ex6", "-10\n20\n-30\nStop", "20\n")]
    [InlineData("009-Ex7", "Gosho\n5\n5.5\n6\n5.43\n5.5\n6\n5.55\n5\n6\n6\n5.43\n5", "Gosho graduated. Average grade: 5.53\n")]
    [InlineData("009-Ex7", "Mimi\n5\n6\n5\n6\n5\n6\n6\n2\n3", "Mimi has been excluded at 8 grade\n")]
    [InlineData("009-Ex7", "Ani\n5\n2\n5\n5\n5\n5\n5\n5\n5\n5\n5\n5\n5", "Ani graduated. Average grade: 5.00\n")]
    [InlineData("009-Ex8", "10\n10\n2\n20\n20\n20\n20\n122", "No more free space! You need 2 Cubic meters more.\n")]
    [InlineData("009-Ex8", "10\n1\n2\n4\n6\nDone", "10 Cubic meters left.\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
