namespace Programs.Tests;

public class NestedLoopsTests
{
    [Fact]
    public void Ex1_prints_every_minute_of_the_day() =>
        Assert.Equal(string.Concat(from h in Enumerable.Range(0, 24) from m in Enumerable.Range(0, 60) select $"{h}:{m}\n"),
            ProgramRunner.Run("011-Ex1"));

    [Fact]
    public void Ex2_prints_multiplication_table() =>
        Assert.Equal(
            string.Concat(from a in Enumerable.Range(1, 10) from b in Enumerable.Range(1, 10) select $"{a} * {b} = {a * b}\n"),
            ProgramRunner.Run("011-Ex2"));

    [Theory]
    [InlineData("011-Ex3", "25", "351\n")]
    [InlineData("011-Ex3", "5", "21\n")]
    [InlineData("011-Ex4", "1\n10\n5", "Combination N:4 (1 + 4 = 5)\n")]
    [InlineData("011-Ex4", "23\n24\n20", "4 combinations - neither equals 20\n")]
    [InlineData("011-Ex5", "Greece\n1000\n200\n200\n300\n100\n150\n240\nSpain\n1200\n300\n500\n193\n423\nEnd",
        "Going to Greece!\nGoing to Spain!\n")]
    [InlineData("011-Ex6", "6\n4",
        "L60 L61 L62 L63 \nA50 A51 A52 A53 \nO40 O41 O42 O43 \nA30 A31 A32 A33 \nO20 O21 O22 O23 \nA10 A11 A12 A13 \n")]
    [InlineData("011-Ex7",
        "Taxi\n10\nstandard\nkid\nstudent\nstudent\nstandard\nstandard\nEnd\nScary Movie\n6\nstudent\nstudent\nstudent\nstudent\nstudent\nstudent\nFinish",
        "Taxi - 60.00% full.\nScary Movie - 100.00% full.\nTotal tickets: 12\n66.67% student tickets.\n25.00% standard tickets.\n8.33% kids tickets.\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));
}
