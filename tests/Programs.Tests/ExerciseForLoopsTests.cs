namespace Programs.Tests;

public class ExerciseForLoopsTests
{
    [Fact]
    public void Ex1_prints_numbers_ending_in_7() =>
        Assert.Equal(string.Concat(Enumerable.Range(1, 1000).Where(i => i % 10 == 7).Select(i => $"{i}\n")),
            ProgramRunner.Run("008-Ex1"));

    [Theory]
    [InlineData("008-Ex2", "7\n3\n4\n1\n1\n2\n12\n1", "Yes\nSum = 12\n")]
    [InlineData("008-Ex2", "3\n1\n1\n10", "No\nDiff = 8\n")]
    [InlineData("008-Ex3", "6\n2\n3\n5\n4\n2\n1",
        "OddSum=9.00,\nOddMin=2.00,\nOddMax=5.00,\nEvenSum=8.00,\nEvenMin=1.00,\nEvenMax=4.00\n")]
    [InlineData("008-Ex3", "1\n1", "OddSum=1.00,\nOddMin=1.00,\nOddMax=1.00,\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No\n")]
    [InlineData("008-Ex3", "0", "OddSum=0.00,\nOddMin=No,\nOddMax=No,\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No\n")]
    [InlineData("008-Ex4", "3\n1\n2\n999", "66.67%\n0.00%\n0.00%\n0.00%\n33.33%\n")]
    [InlineData("008-Ex4", "5\n250\n450\n650\n850\n150", "20.00%\n20.00%\n20.00%\n20.00%\n20.00%\n")]
    [InlineData("008-Ex5", "3\n3\n6\n9", "33.33%\n100.00%\n0.00%\n")]
    [InlineData("008-Ex6", "10\n750\nFacebook\nDev.bg\nInstagram\nFacebook\nReddit\nFacebook\nFacebook",
        "You have lost your salary.\n")]
    [InlineData("008-Ex6", "3\n500\nGithub.com\nStackoverflow.com\nsoftuni.bg", "500\n")]
    [InlineData("008-Ex6", "2\n100\nFacebook\nReddit", "You have lost your salary.\n")]
    [InlineData("008-Ex7", "50000\n1802", "Yes! He will live a carefree life and will have 13050.00 dollars left.\n")]
    [InlineData("008-Ex7", "100000.15\n1808", "He will need 12399.85 dollars to survive.\n")]
    [InlineData("008-Ex8", "4\n7\n27\n9\n1", "Treated patients: 23.\nUntreated patients: 21.\n")]
    [InlineData("008-Ex9", "4\n1\n5\n16\n3", "143.80\n16.00%\n20.00%\n64.00%\n")]
    [InlineData("008-Ex10", "10\n3.00\n2.99\n5.68\n3.01\n4\n4\n6.00\n4.50\n2.44\n5",
        "Top students: 30.00%\nBetween 4.00 and 4.99: 30.00%\nBetween 3.00 and 3.99: 20.00%\nFail: 20.00%\nAverage: 4.06\n")]
    [InlineData("008-Ex11", "10\n43\n57\n-12\n23\n12\n0\n50\n44\n7\n6",
        "240.40\nFrom 0 to 9: 30.00%\nFrom 10 to 19: 10.00%\nFrom 20 to 29: 10.00%\nFrom 30 to 39: 0.00%\nFrom 40 to 50: 30.00%\nInvalid numbers: 20.00%\n")]
    [InlineData("008-Ex12", "5\n68.63\n89.25\n132.53\n93.53\n63.22",
        "Electricity: 447.16 lv\nWater: 100.00 lv\nInternet: 75.00 lv\nOthers: 746.59 lv\nAverage: 273.75 lv\n")]
    [InlineData("008-Ex13", "76\n10\nA\nV\nV\nV\nG\nB\nA\nV\nB\nB", "20.00%\n30.00%\n40.00%\n10.00%\n13.16%\n")]
    [InlineData("008-Ex14", "76\n10\nA\nV\nV\nV\nG\nB\nA\nV\nB\nB", "20.00%\n30.00%\n40.00%\n10.00%\n13.16%\n")]
    public void Prints_expected_output(string program, string input, string expected) =>
        Assert.Equal(expected, ProgramRunner.Run(program, input));

    [Fact]
    public void Ex15_prints_every_millisecond_of_the_day()
    {
        // 86.4M lines is too much to buffer, so only count them and keep the ends.
        var output = new LineCounter();
        ProgramRunner.Run("008-Ex15", "", output);

        Assert.Equal(24 * 60 * 60 * 1000, output.Count);
        Assert.Equal("0 : 0 : 0 : 0", output.First);
        Assert.Equal("23 : 59 : 59 : 999", output.Last);
    }

    private sealed class LineCounter : TextWriter
    {
        public int Count { get; private set; }
        public string? First { get; private set; }
        public string? Last { get; private set; }
        public override System.Text.Encoding Encoding => System.Text.Encoding.UTF8;

        public override void WriteLine(string? value)
        {
            First ??= value;
            Last = value;
            Count++;
        }
    }
}
